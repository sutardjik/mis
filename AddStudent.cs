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
    public partial class AddStudent : Form{
        public AddStudent(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e){
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);
            stuIDTextBox.Clear();
            stuNameTextBox.Clear();
        }
        private void stuIDLabel_Click(object sender, EventArgs e){}
        private void save_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == "" || stuNameTextBox.Text == "" || sex.Text == "" || entage.Text == "" || entyear.Text=="" || stugrade.Text == "" || stuclass.Text==""){
                MessageBox.Show("All text fields must be filled.", "EMPTY TEXT FIELD(S)");
            }else{
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[StudentInfo]([StuID],[StuName],[Sex],[EntAge],[EntYear],[StuGrade],[Class]) VALUES ('"+stuIDTextBox.Text+"','"+stuNameTextBox.Text+"','"+sex.Text+"','"+entage.Text+"','"+entyear.Text+"','"+stugrade.Text+"','"+stuclass.Text+"')",connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added to StudentInfo table.", "ROW ADDED TO TABLE");
            }
        }
        private void exit_Click_1(object sender, EventArgs e){
            this.Hide();
            Add add = new Add();
            add.Show();
        }
    }
}
