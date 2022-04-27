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
    public partial class ModifyCourseName : Form{
        public ModifyCourseName(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            ModifyCourseInfo mti = new ModifyCourseInfo();
            mti.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (courseIDTextBox.Text == "" || modvalue.Text == ""){
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE CourseInfo SET CourseName='" + modvalue.Text + "' WHERE CourseID='" + courseIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("CourseName updated.", "TABLE VALUE UPDATED");
            }
        }
        private void ModifyCourseName_Load(object sender, EventArgs e){
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            modvalue.SelectedIndex = -1;
        }
    }
}
