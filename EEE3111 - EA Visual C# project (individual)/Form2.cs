using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EEE3111___EA_Visual_C__project__individual_
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Timer logoutTimer;
        private SqlConnection sqlConnection;

        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database1.mdf;Integrated Security=True");
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
            // Close Form2 and show Form1
            this.Close();
            form1.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.produ);
            //LoadData();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Mod = Convert.ToString(brandComboBox.Text);
            ptextBox1.Text = Convert.ToString(Mod);
        }

        private void LoadData()
        {
            try
            {
                // Create a SQL command to select data from the 'Products' table SqlCommand
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);
                // Create a DataAdapter to fill the DataTable
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();
                // Fill the DataTable with data
                sqlDataAdapter.Fill(dataTable);
                // Bind the DataGridView to the DataTable
                dataGridView1.DataSource = database1DataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
