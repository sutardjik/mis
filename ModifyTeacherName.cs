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
    public partial class ModifyTeacherName : Form{
        public ModifyTeacherName(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void ModifyTeacherName_Load(object sender, EventArgs e){}
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            ModifyTeacherInfo mti = new ModifyTeacherInfo();
            mti.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (teacherIDTextBox.Text == "" || modifyvalue.Text == ""){
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE TeacherInfo SET TeacherName='" + modifyvalue.Text + "' WHERE TeacherID='" + teacherIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                String sql1 = "UPDATE TeacherAuthority SET TeacherPassword='" + modifyvalue.Text + "' WHERE TeacherID='" + teacherIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql1;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("TeacherName updated in TeacherInfo table and TeacherPassword updated in TeacherAuthority table.", "TABLES' VALUE UPDATED");
            }
        }
    }
}
