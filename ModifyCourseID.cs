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
    public partial class ModifyCourseID : Form{
        public ModifyCourseID(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void ModifyCourseID_Load(object sender, EventArgs e){
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            modvalue.SelectedIndex = -1;
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            ModifyCourseChoosing mcc = new ModifyCourseChoosing();
            mcc.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == "" || modvalue.Text == "" || teacherIDTextBox.Text==""){
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE ChooseCourse SET CourseID='" + modvalue.Text + "' WHERE StuID='" + stuIDTextBox.Text + "' AND TeacherID='"+teacherIDTextBox.Text+"'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("CourseID updated.", "TABLE VALUE UPDATED");
            }
        }
    }
}
