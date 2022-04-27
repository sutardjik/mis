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
    public partial class ChooseCourse : Form{
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True");
        public ChooseCourse(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void chooseCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.chooseCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void EnrollCourse_Load(object sender, EventArgs e){
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            cid.Clear();
        }
        private void add_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (cid.Text == "" || tid.Text==""){
                MessageBox.Show("The text fields must be filled.", "EMPTY TEXT FIELD");
            }else{
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ChooseCourse]([StuID],[CourseID],[TeacherID],[ChosenYear],[Score]) VALUES ('" + LoginInterface.strtxt1 + "','" + cid.Text + "','" + tid.Text + "',2022,NULL)", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added to ChooseCourse table.", "ROW ADDED TO TABLE");
            }
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            StudentInterface studentInterface = new StudentInterface();
            studentInterface.Show();
        }
        private void view_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT DISTINCT C.CourseID, C.CourseName, C.TeacherID, C.CancelYear FROM CourseInfo C, StudentInfo S WHERE S.StuID='" + LoginInterface.strtxt1 + "' AND (S.StuGrade > C.CourseGrade) AND (C.CancelYear > S.EntYear OR C.CancelYear IS NULL)", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
