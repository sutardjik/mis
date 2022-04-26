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
    public partial class TeacherInterface : Form
    {
        public TeacherInterface()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void TeacherInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.ChooseCourse' table. You can move, or remove it, as needed.
            //this.chooseCourseTableAdapter.Fill(this.masterDataSet.ChooseCourse);
            // TODO: This line of code loads data into the 'masterDataSet.StudentInfo' table. You can move, or remove it, as needed.
            //this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInterface login = new LoginInterface();
            login.Show();
        }

        private void personalinfo_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherInfo] WHERE TeacherID='" + LoginInterface.strtxt1 + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void score_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT C.CourseID, C.CourseName, CH.TeacherID, CH.Score FROM CourseInfo C, ChooseCourse CH WHERE CH.TeacherID='" + LoginInterface.strtxt1 + "' AND C.TeacherID=CH.TeacherID", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void avgscore_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT C.CourseID, C.CourseName, CH.TeacherID, AVG(CH.Score) 'AvgScore' FROM CourseInfo C, ChooseCourse CH WHERE CH.TeacherID='" + LoginInterface.strtxt1 + "' AND C.TeacherID=CH.TeacherID GROUP BY C.CourseID, C.CourseName, CH.TeacherID", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void modifyscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyScore ms = new ModifyScore();
            ms.Show();
        }
    }
}
