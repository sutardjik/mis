using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete d = new Delete();
            d.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (courseIDTextBox.Text == "")
            {
                MessageBox.Show("The text field must be filled.", "EMPTY TEXT FIELD");
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [ChooseCourse] WHERE CourseID='" + courseIDTextBox.Text + "'", connection);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM [CourseInfo] WHERE CourseID='" + courseIDTextBox.Text + "'", connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted row from ChooseCourse and CourseInfo tables.", "ROW DELETED FROM TABLES");
            }
        }

        private void DeleteCourse_Load(object sender, EventArgs e)
        {
            courseIDTextBox.Clear();
        }
    }
}
