using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;

            // Validate the email contains an '@' symbol
            bool isValidEmail = email.Contains("@");

            // Validate the phone contains only numbers
            bool isValidPhone = phone.All(char.IsDigit);

            // Check if all fields are not empty, email is valid, and phone is valid
            if (!string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(email) && isValidEmail && !string.IsNullOrEmpty(phone) && isValidPhone)
            {
                MessageBox.Show("Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter the correct information in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
