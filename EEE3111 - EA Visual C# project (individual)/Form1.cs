using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEE3111___EA_Visual_C__project__individual_
{
    public partial class Form1 : Form
    {
        private string password = "admin";
        private string username = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textboxUser.Text != username || textboxPassword.Text != password)
            {
                //fail input box, gives error warning pop-up
                MessageBox.Show("Error, invalid username or password.", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //success! gives succes message and opens Form2
                MessageBox.Show("Login Successful!", "Welcome " + username, MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form2 obj = new Form2(this);
                // Pass Form1 to Form2
                obj.Show();
                this.Hide();
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact support to reset your password.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if click, ask if user wants to end the program after prompt

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            // Show confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If user confirms, exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close all forms and exit the application
            }
        }

    }
}
