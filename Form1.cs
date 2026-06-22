using System;
using System.Windows.Forms;

namespace DoggyPalour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Doggy Palour - Main Menu";
            lblTitle.Text = "Welcome to Doggy Palour";
            lblStudentInfo.Text = "Student: 24865745";
            lblAbout.Text = "Dog Grooming and Salon Services";
        }

        private void btnStartBooking_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doggy Palour - Professional Dog Grooming Services\n\n" +
                          "Student Number: 24865745\n" +
                          "Assessment 2 Project\n\n" +
                          "Services include:\n" +
                          "- Dog Grooming\n" +
                          "- Dog Bathing\n" +
                          "- Dog Styling\n" +
                          "- Nail Trimming\n" +
                          "- Ear Cleaning",
                          "About Doggy Palour");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
