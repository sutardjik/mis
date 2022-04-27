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
    public partial class QueryAverageScoreClass : Form{
        public QueryAverageScoreClass(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void enter_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (comboBox1.Text == ""){
                MessageBox.Show("Class field can't be empty.", "EMPTY TEXT FIELD");
            }else{
                SqlDataAdapter sda = new SqlDataAdapter("SELECT S.Class, AVG(CH.Score) 'AvgScore' FROM StudentInfo S, ChooseCourse CH WHERE Class='" + comboBox1.Text + "' AND S.StuID=CH.StuID GROUP BY S.Class", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void QueryAverageScoreClass_Load(object sender, EventArgs e){this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);}
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            QueryAverageScore queryAverageScore = new QueryAverageScore();
            queryAverageScore.Show();
        }
    }
}
