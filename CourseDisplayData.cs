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
    public partial class CourseDisplayData : Form{
        public CourseDisplayData(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void CourseDisplayData_Load(object sender, EventArgs e){
            this.courseInfoTableAdapter.Fill(this.masterDataSet.CourseInfo);
            cid.Clear();
        }
        private void choosecourse_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (cid.Text==""){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] ORDER BY StuID", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else{
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] WHERE CourseID='" + cid.Text + "' ORDER BY StuID", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            QueryCourseChoosingAndScore qcc = new QueryCourseChoosingAndScore();
            qcc.Show();
        }
    }
}
