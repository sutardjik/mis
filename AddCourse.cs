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
    public partial class AddCourse : Form{
        public AddCourse(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void teacherAuthorityBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.teacherAuthorityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void AddTeacher_Load(object sender, EventArgs e){
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            this.teacherAuthorityTableAdapter.Fill(this.masterDataSet.TeacherAuthority);
            courseIDTextBox.Clear();
            courseNameTextBox.SelectedIndex = -1;
            teacherid.SelectedIndex = -1;
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            Add add = new Add();
            add.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (courseIDTextBox.Text == "" || courseNameTextBox.Text == "" || teacherid.Text=="" || credit.Text=="" || coursegrade.Text == ""){
                MessageBox.Show("All text fields must be filled. If there is no CancelYear, its field can be left blank or NULL.", "EMPTY TEXT FIELD(S)");
            }else{
                if(cancelYearTextBox.Text=="" || cancelYearTextBox.Text == "NULL" || cancelYearTextBox.Text=="null"){
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[CourseInfo]([CourseID],[CourseName],[TeacherID],[Credit],[CourseGrade],[CancelYear]) VALUES ('" + courseIDTextBox.Text + "','" + courseNameTextBox.Text + "','" + teacherid.Text + "','" + credit.Text + "','" + coursegrade.Text + "',NULL)", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Added to CourseInfo table.", "ROW ADDED TO TABLE");
                }else{
                    if (Int32.Parse(cancelYearTextBox.Text) < 2018){
                        MessageBox.Show("Canceled year can't be earlier than 2018.", "ENTERED YEAR BEYOND RANGE");
                    }else{
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[CourseInfo]([CourseID],[CourseName],[TeacherID],[Credit],[CourseGrade],[CancelYear]) VALUES ('" + courseIDTextBox.Text + "','" + courseNameTextBox.Text + "','" + teacherid.Text + "','" + credit.Text + "','" + coursegrade.Text + "','" + cancelYearTextBox.Text + "')", connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Added to CourseInfo table.", "ROW ADDED TO TABLE");
                    }
                }
            }
        }
    }
}
