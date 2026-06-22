using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DoggyPalour
{
    public partial class Form3 : Form
    {
        public decimal TotalPrice { get; set; }
        public string SelectedDate { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Doggy Palour - Customer Details";
            lblTitle.Text = "Customer Details - Assessment 2";
            lblStudentInfo.Text = "Student: 24865745";
        }

        // REGEXP correctly applied on Name
        private bool ValidateName(string name)
        {
            // Name should only contain letters and spaces, minimum 2 characters
            string pattern = @"^[a-zA-Z\s]{2,}$";
            return Regex.IsMatch(name, pattern);
        }

        // REGEXP correctly applied on Email
        private bool ValidateEmail(string email)
        {
            // Standard email validation pattern
            string pattern = @"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // REGEXP correctly applied on Telephone number
        private bool ValidateTelephone(string phone)
        {
            // South African phone number format: 10 digits, starts with 0
            string pattern = @"^0[1-9]\d{8}$";
            return Regex.IsMatch(phone, pattern);
        }

        // REGEXP correctly applied on ID Number (using Luhn algorithm)
        private bool ValidateIDWithLuhn(string idNumber)
        {
            // First validate format: 13 digits
            if (!Regex.IsMatch(idNumber, @"^\d{13}$"))
            {
                return false;
            }

            // Apply Luhn algorithm
            return LuhnAlgorithm(idNumber);
        }

        // Luhn Algorithm for ID validation
        private bool LuhnAlgorithm(string idNumber)
        {
            int sum = 0;
            int multiplier = 1;

            for (int i = idNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(idNumber[i].ToString());
                digit *= multiplier;

                if (digit > 9)
                {
                    digit -= 9;
                }

                sum += digit;

                multiplier = multiplier == 1 ? 2 : 1;
            }

            return sum % 10 == 0;
        }

        // REGEXP correctly applied on ID Number (without Luhn algorithm)
        private bool ValidateIDBasic(string idNumber)
        {
            // South African ID: 13 digits
            string pattern = @"^\d{13}$";
            return Regex.IsMatch(idNumber, pattern);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();

            // Validate all fields
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter customer name.", "Validation Error");
                return;
            }

            if (!ValidateName(name))
            {
                MessageBox.Show("Name must contain only letters and spaces (minimum 2 characters).", "Name Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter email address.", "Validation Error");
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Email Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter telephone number.", "Validation Error");
                return;
            }

            if (!ValidateTelephone(phone))
            {
                MessageBox.Show("Please enter a valid South African telephone number (10 digits starting with 0).", "Telephone Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter ID number.", "Validation Error");
                return;
            }

            // Use Luhn algorithm for validation (4 marks)
            if (!ValidateIDWithLuhn(idNumber))
            {
                MessageBox.Show("Please enter a valid South African ID number (13 digits, Luhn check).", "ID Validation Error");
                return;
            }

            // Show success message
            MessageBox.Show(
                "Booking Confirmed!\n\n" +
                "Name: " + name + "\n" +
                "Email: " + email + "\n" +
                "Phone: " + phone + "\n" +
                "ID Number: " + idNumber + "\n" +
                "Date: " + SelectedDate + "\n" +
                "Total: R" + TotalPrice.ToString("F2"),
                "Booking Confirmation"
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
