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
    public partial class DeleteStudent : Form{
        public DeleteStudent(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void DeleteStudent_Load(object sender, EventArgs e){
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
            stuIDTextBox.Clear();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            Delete d = new Delete();
            d.Show();
        }
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == ""){
                MessageBox.Show("The text field must be filled.", "EMPTY TEXT FIELD");
            }else{
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [ChooseCourse] WHERE StuID='" + stuIDTextBox.Text + "'", connection);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM [StudentInfo] WHERE StuID='" + stuIDTextBox.Text + "'", connection);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(@"DELETE FROM [StudentAuthority] WHERE StuID='" + stuIDTextBox.Text + "'", connection);
                cmd2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted row from ChooseCourse, StudentInfo, and StudentAuthority tables.", "ROW DELETED FROM TABLES");
            }
        }
    }
}
