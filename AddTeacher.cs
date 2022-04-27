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
    public partial class AddTeacher : Form{
        public AddTeacher(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void teacherInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.teacherInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void AddTeacher_Load(object sender, EventArgs e){
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            teacherIDTextBox.Clear();
            teacherNameTextBox.Clear();
            teachCourseTextBox.Clear();
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
            if(teacherIDTextBox.Text=="" || teacherNameTextBox.Text=="" || teachCourseTextBox.Text == ""){
                MessageBox.Show("All text fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TeacherInfo]([TeacherID],[TeacherName],[TeachCourse]) VALUES ('" + teacherIDTextBox.Text + "','" + teacherNameTextBox.Text + "','" + teachCourseTextBox.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added to TeacherInfo table.", "ROW ADDED TO TABLE");
            }
        }
    }
}
