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
    public partial class ModifyStuEntYear : Form{
        public ModifyStuEntYear(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void ModifyStuEntYear_Load(object sender, EventArgs e){}
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            ModifyStudentInfo mis = new ModifyStudentInfo();
            mis.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == "" || modvalue.Text == ""){
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE StudentInfo SET EntYear='" + modvalue.Text + "' WHERE StuID='" + stuIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("EntYear updated.", "TABLE VALUE UPDATED");
            }
        }
    }
}
