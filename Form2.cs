using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DoggyPalour
{
    public partial class Form2 : Form
    {
        private decimal totalPrice = 0m;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Doggy Palour - Service Selection";
            lblTitle.Text = "Select Your Services";
            lblStudentInfo.Text = "Student: 24865745";

            // Initialize RadioButtons with services
            rbBathing.Text = "Dog Bathing - R150.00";
            rbBathing.Tag = 150m;
            
            rbGrooming.Text = "Dog Grooming - R250.00";
            rbGrooming.Tag = 250m;
            
            rbStyling.Text = "Dog Styling - R300.00";
            rbStyling.Tag = 300m;

            // Initialize CheckedListBox with additional services
            checkedListBox1.Items.Add("Nail Trimming - R50.00", false);
            checkedListBox1.Items.Add("Ear Cleaning - R40.00", false);
            checkedListBox1.Items.Add("Teeth Brushing - R60.00", false);
            checkedListBox1.Items.Add("Paw Care - R35.00", false);

            txtTotal.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtTotal.Text = "R0.00";
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Method to extract price from string
        private decimal ExtractPrice(string text)
        {
            // Extract number from text like "Service - R150.00"
            Match match = Regex.Match(text, @"R?([\d.]+)");
            if (match.Success && decimal.TryParse(match.Groups[1].Value, out decimal price))
            {
                return price;
            }
            return 0m;
        }

        // RadioButton CheckedChanged event listener
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        // Method for radioButton_CheckedChanged
        private void HandleRadioButtonChange(RadioButton rb)
        {
            if (rb.Checked && rb.Tag is decimal price)
            {
                UpdateTotal();
            }
        }

        // CheckedListBox ItemChecked event listener
        private void checkedListBox1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateTotal();
        }

        // Method for checkedListBox_ItemChecked
        private void HandleCheckedListBoxChange()
        {
            UpdateTotal();
        }

        // checkedListBox1_ItemCheck code
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // This will be called before ItemChecked event
            UpdateTotal();
        }

        // Update Total text field - correctly
        private void UpdateTotal()
        {
            totalPrice = 0m;

            // Add RadioButton price
            if (rbBathing.Checked)
            {
                totalPrice += ExtractPrice(rbBathing.Text);
            }
            else if (rbGrooming.Checked)
            {
                totalPrice += ExtractPrice(rbGrooming.Text);
            }
            else if (rbStyling.Checked)
            {
                totalPrice += ExtractPrice(rbStyling.Text);
            }

            // Add CheckedListBox prices
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string item = checkedListBox1.CheckedItems[i].ToString();
                totalPrice += ExtractPrice(item);
            }

            // Update Total text field - correctly
            txtTotal.Text = "R" + totalPrice.ToString("F2");
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!rbBathing.Checked && !rbGrooming.Checked && !rbStyling.Checked)
            {
                MessageBox.Show("Please select a main service.", "Selection Required");
                return;
            }

            Form3 form3 = new Form3();
            form3.TotalPrice = totalPrice;
            form3.SelectedDate = txtDate.Text;
            form3.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
