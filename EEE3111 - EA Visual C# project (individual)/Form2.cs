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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Timer logoutTimer;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If user confirms, start the timer
            if (result == DialogResult.Yes) 
            {
                // Close Form2 and show Form1
                this.Close();
                form1.Show();
            }
        }

        private void logoutTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            logoutTimer.Stop();

            // Close Form2 and show Form1
            this.Close();
            form1.Show();
        }
    }
}
