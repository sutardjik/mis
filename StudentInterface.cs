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

namespace test{
    public partial class StudentInterface : Form{
        public StudentInterface(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            LoginInterface login = new LoginInterface();
            login.Show();
        }
        private void chooseclass_Click(object sender, EventArgs e){
            this.Hide();
            ChooseCourse choose = new ChooseCourse();
            choose.Show();
        }
        private void personalinfo_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentInfo] WHERE StuID='" + LoginInterface.strtxt1 + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void coursechoosinginfo_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT CH.StuID, C.CourseName, T.TeacherName, CH.CourseID, CH.TeacherID FROM TeacherInfo T, CourseInfo C, ChooseCourse CH WHERE CH.StuID='" + LoginInterface.strtxt1 + "' AND C.CourseID=CH.CourseID AND T.TeacherID=C.TeacherID", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void score_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT CH.StuID, C.CourseName, CH.CourseID, CH.Score FROM CourseInfo C, ChooseCourse CH WHERE CH.StuID='" + LoginInterface.strtxt1 + "' AND C.CourseID=CH.CourseID", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
