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
    public partial class ModifyCancelYear : Form{
        public ModifyCancelYear(){
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
            if (courseIDTextBox.Text == ""){
                MessageBox.Show("Course ID text field must be filled. If there is no CancelYear, its field can be left blank or NULL.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (modifyvalue.Text == "" || modifyvalue.Text=="NULL"){
                    String sql = "UPDATE CourseInfo SET CancelYear=NULL WHERE CourseID='" + courseIDTextBox.Text + "'";
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("CancelYear updated.", "TABLE VALUE UPDATED");
                }else{
                    if (Int32.Parse(modifyvalue.Text) < 2018){
                        MessageBox.Show("Canceled year can't be earlier than 2018.", "ENTERED YEAR BEYOND RANGE");
                    }else{
                        String sql = "UPDATE CourseInfo SET CancelYear='" + modifyvalue.Text + "' WHERE CourseID='" + courseIDTextBox.Text + "'";
                        adapter.UpdateCommand = connection.CreateCommand();
                        adapter.UpdateCommand.CommandText = sql;
                        adapter.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("CancelYear updated.", "TABLE VALUE UPDATED");
                    }
                }
            }
        }
        private void ModifyCancelYear_Load(object sender, EventArgs e){
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
            this.teacherAuthorityTableAdapter.Fill(this.masterDataSet.TeacherAuthority);
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
        }
    }
}
