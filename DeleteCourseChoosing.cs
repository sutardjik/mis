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
    public partial class DeleteCourseChoosing : Form
    {
        public DeleteCourseChoosing()
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
            if (stuIDTextBox.Text == "" || courseIDTextBox.Text=="")
            {
                MessageBox.Show("All text fields must be filled.", "EMPTY TEXT FIELD(S)");
            }
            else{
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [ChooseCourse] WHERE StuID='" + stuIDTextBox.Text + "' AND CourseID='"+courseIDTextBox.Text+"'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted row from ChooseCourse table.", "ROW DELETED FROM TABLE");
            }
        }

        private void DeleteCourseChoosing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.CourseInfo' table. You can move, or remove it, as needed.
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            // TODO: This line of code loads data into the 'masterDataSet.ChooseCourse' table. You can move, or remove it, as needed.
            //this.chooseCourseTableAdapter.Fill(this.masterDataSet.ChooseCourse);
            stuIDTextBox.Clear();
            courseIDTextBox.Clear();
        }
    }
}
