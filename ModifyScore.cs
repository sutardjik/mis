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
    public partial class ModifyScore : Form{
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True");
        public ModifyScore(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void chooseCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.chooseCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void ModifyScore_Load(object sender, EventArgs e){
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
            stuIDTextBox.Clear();
            courseIDTextBox.Clear();
            scoreTextBox.Clear();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if(stuIDTextBox.Text=="" || courseIDTextBox.Text==""){
                MessageBox.Show("Stu ID and/or Course ID text fields must be filled. If there is no Score, its field can be left blank or NULL.", "EMPTY TEXT FIELD(S)");
            }else{
                if (scoreTextBox.Text == "" || scoreTextBox.Text=="NULL" || scoreTextBox.Text == "null"){
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE ChooseCourse SET Score=NULL WHERE StuID='" + stuIDTextBox.Text + "' AND CourseID='" + courseIDTextBox.Text + "'";
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Score updated.", "TABLE VALUE UPDATED");
                }else{
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "UPDATE ChooseCourse SET Score='" + scoreTextBox.Text + "' WHERE StuID='" + stuIDTextBox.Text + "' AND CourseID='"+courseIDTextBox.Text+"'";
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Score updated.", "TABLE VALUE UPDATED");
                }
            }
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            TeacherInterface ti = new TeacherInterface();
            ti.Show();
        }
    }
}
