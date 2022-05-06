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
    public partial class ScoreDataDisplay : Form{
        public ScoreDataDisplay(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            QueryCourseChoosingAndScore qcc = new QueryCourseChoosingAndScore();
            qcc.Show();
        }
        private void ScoreDataDisplay_Load(object sender, EventArgs e){score.Clear();}
        private void choosecourse_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (score.Text == ""){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] ORDER BY StuID", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else if (score.Text == "NULL" || score.Text == "null"){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] WHERE Score IS NULL ORDER BY StuID", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else{
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[ChooseCourse] WHERE Score='" + score.Text + "' ORDER BY StuID", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
