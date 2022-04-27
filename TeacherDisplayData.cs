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
    public partial class TeacherDisplayData : Form{
        public TeacherDisplayData(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void choosecourse_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if(tidbox.Text == ""){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse]", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else{
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] WHERE TeacherID='" + tidbox.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            QueryCourseChoosingAndScore qccs = new QueryCourseChoosingAndScore();
            qccs.Show();
        }
        private void TeacherDisplayData_Load(object sender, EventArgs e){
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            tidbox.SelectedIndex = -1;
        }
    }
}
