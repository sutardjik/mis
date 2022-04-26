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
    public partial class QueryAverageScore : Form
    {
        public QueryAverageScore()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void gpa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (name.Text == "" && id.Text == "")
            {
                MessageBox.Show("Student's Name or ID can't be empty.", "EMPTY TEXT FIELDS");
            }else if (name.Text == ""){
                SqlDataAdapter sda = new SqlDataAdapter("SELECT StuID, AVG(CH.Score) 'AvgScore' FROM ChooseCourse CH WHERE StuID='" + id.Text + "' GROUP BY StuID" , connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else if (id.Text == ""){
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S.StuName, AVG(CH.Score) 'AvgScore' FROM StudentInfo S, ChooseCourse CH WHERE S.StuName='" + name.Text + "' AND S.StuID=CH.StuID GROUP BY S.StuName", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else if(name.Text != "" && id.Text != ""){
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S.StuID, S.StuName, AVG(CH.Score) 'AvgScore' FROM StudentInfo S, ChooseCourse CH WHERE S.StuName='" + name.Text + "' AND S.StuID=CH.StuID GROUP BY S.StuID, S.StuName", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name.Clear();
            id.Clear();
        }

        private void overallgpa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT AVG(CH.Score) 'AvgScore' FROM ChooseCourse CH",connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface admin = new AdminInterface();
            admin.Show();
        }

        private void coursescore_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (name.Text == "" && id.Text == "")
            {
                MessageBox.Show("Course's Name or ID can't be empty.", "EMPTY TEXT FIELDS");
            }
            else if(id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT C.CourseName, AVG(CH.Score) 'AvgScore' FROM CourseInfo C, ChooseCourse CH WHERE CourseName='" + name.Text + "' AND C.CourseID=CH.CourseID GROUP BY C.CourseName", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if(name.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CourseID, AVG(CH.Score) 'AvgScore' FROM ChooseCourse CH WHERE CourseID='" + id.Text + "' GROUP BY CourseID", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if(name.Text != "" && id.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CH.CourseID, C.CourseName, AVG(CH.Score) 'AvgScore' FROM CourseInfo C, ChooseCourse CH WHERE CourseName='"+name.Text+"' AND C.CourseID=CH.CourseID GROUP BY CH.CourseID, C.CourseName", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void classgpa_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryAverageScoreClass asc = new QueryAverageScoreClass();
            asc.Show();
        }
    }
}
