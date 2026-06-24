using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DoggyPalour
{
    public class Task
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; } // High, Medium, Low
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreatedDate { get; set; }

        public Task()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
            IsComplete = false;
            Priority = "Medium";
            DueDate = DateTime.Now.AddDays(1);
        }
    }

    public class TaskManager
    {
        private string _dataFilePath;
        private List<Task> _tasks;

        public TaskManager()
        {
            // Store data in user's AppData folder
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DoggyPalour");
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            _dataFilePath = Path.Combine(appDataPath, "tasks.xml");
            _tasks = new List<Task>();
            LoadTasks();
        }

        // Load tasks from XML file
        private void LoadTasks()
        {
            try
            {
                if (File.Exists(_dataFilePath))
                {
                    XDocument doc = XDocument.Load(_dataFilePath);
                    var taskElements = doc.Root.Elements("Task");

                    foreach (var element in taskElements)
                    {
                        Task task = new Task
                        {
                            Id = element.Element("Id")?.Value ?? Guid.NewGuid().ToString(),
                            Title = element.Element("Title")?.Value ?? "",
                            Description = element.Element("Description")?.Value ?? "",
                            Priority = element.Element("Priority")?.Value ?? "Medium",
                            DueDate = DateTime.Parse(element.Element("DueDate")?.Value ?? DateTime.Now.AddDays(1).ToString()),
                            IsComplete = bool.Parse(element.Element("IsComplete")?.Value ?? "false"),
                            CreatedDate = DateTime.Parse(element.Element("CreatedDate")?.Value ?? DateTime.Now.ToString())
                        };
                        _tasks.Add(task);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        // Save tasks to XML file
        public void SaveTasks()
        {
            try
            {
                XDocument doc = new XDocument(
                    new XElement("Tasks",
                        _tasks.Select(t => new XElement("Task",
                            new XElement("Id", t.Id),
                            new XElement("Title", t.Title),
                            new XElement("Description", t.Description),
                            new XElement("Priority", t.Priority),
                            new XElement("DueDate", t.DueDate.ToString("yyyy-MM-dd HH:mm:ss")),
                            new XElement("IsComplete", t.IsComplete),
                            new XElement("CreatedDate", t.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"))
                        ))
                    )
                );
                doc.Save(_dataFilePath);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error saving tasks: " + ex.Message);
            }
        }

        // Add new task
        public void AddTask(Task task)
        {
            _tasks.Add(task);
            SaveTasks();
        }

        // Update existing task
        public void UpdateTask(Task task)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.Priority = task.Priority;
                existingTask.DueDate = task.DueDate;
                existingTask.IsComplete = task.IsComplete;
                SaveTasks();
            }
        }

        // Delete task
        public void DeleteTask(string taskId)
        {
            _tasks.RemoveAll(t => t.Id == taskId);
            SaveTasks();
        }

        // Get all tasks
        public List<Task> GetAllTasks()
        {
            return _tasks.OrderByDescending(t => t.CreatedDate).ToList();
        }

        // Get tasks by status
        public List<Task> GetTasksByStatus(bool isComplete)
        {
            return _tasks.Where(t => t.IsComplete == isComplete).OrderByDescending(t => t.CreatedDate).ToList();
        }

        // Get tasks by priority
        public List<Task> GetTasksByPriority(string priority)
        {
            return _tasks.Where(t => t.Priority == priority).OrderByDescending(t => t.CreatedDate).ToList();
        }

        // Mark task as complete
        public void MarkTaskComplete(string taskId, bool isComplete)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                task.IsComplete = isComplete;
                SaveTasks();
            }
        }

        // Get task count
        public int GetTaskCount()
        {
            return _tasks.Count;
        }

        // Get completed task count
        public int GetCompletedTaskCount()
        {
            return _tasks.Count(t => t.IsComplete);
        }
    }
}
