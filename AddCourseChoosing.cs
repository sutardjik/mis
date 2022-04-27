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
    public partial class AddCourseChoosing : Form{
        public AddCourseChoosing(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void chooseCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.chooseCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }
        private void AddCourseChoosing_Load(object sender, EventArgs e){
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            stuid.SelectedIndex = -1;
            cid.SelectedIndex = -1;
            tid.SelectedIndex = -1;
            chosenyear.SelectedIndex = -1;
            scoreTextBox.Clear();
        }
        private void exit_Click_1(object sender, EventArgs e){
            this.Hide();
            Add add = new Add();
            add.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuid.Text == "" || cid.Text == "" || tid.Text == "" || chosenyear.Text == ""){
                MessageBox.Show("Stu ID and/or Course ID and/or Teacher ID and/or ChosenYear text fields must be filled. If there is no Score, its field can be left blank or NULL.", "EMPTY TEXT FIELD(S)");
            }else{   
                if(scoreTextBox.Text=="" || scoreTextBox.Text == "NULL" || scoreTextBox.Text == "null"){
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ChooseCourse]([StuID],[CourseID],[TeacherID],[ChosenYear],[Score]) VALUES ('" + stuid.Text + "','" + cid.Text + "','" + tid.Text + "','" + chosenyear.Text + "',NULL)", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Added to ChooseCourse table.", "ROW ADDED TO TABLE");
                }else{
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ChooseCourse]([StuID],[CourseID],[TeacherID],[ChosenYear],[Score]) VALUES ('"+stuid.Text+"','"+cid.Text+"','"+tid.Text+"','"+chosenyear.Text+"','"+scoreTextBox.Text+"')",connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Added to ChooseCourse table.", "ROW ADDED TO TABLE");
                }
            }
        }
    }
}
