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
    public partial class ModifyStuName : Form{
        public ModifyStuName(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            ModifyStudentInfo mis = new ModifyStudentInfo();
            mis.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == "" || modifyvalue.Text == ""){
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE StudentInfo SET StuName='" + modifyvalue.Text + "' WHERE StuID='" + stuIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                String sql1 = "UPDATE StudentAuthority SET StuPassword='" + modifyvalue.Text + "' WHERE StuID='" + stuIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql1;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("StuName updated in StudentInfo table and StuPassword updated in StudentAuthority table.", "TABLES' VALUE UPDATED");
            }
        }
    }
}
