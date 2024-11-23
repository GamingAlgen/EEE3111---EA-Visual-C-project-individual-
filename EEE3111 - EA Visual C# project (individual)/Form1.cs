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
                MessageBox.Show("Error, invalid username or password.", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact support to reset your password.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
