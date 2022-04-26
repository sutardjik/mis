using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void adminAuthorityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminAuthorityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.AdminAuthority' table. You can move, or remove it, as needed.
            this.adminAuthorityTableAdapter.Fill(this.masterDataSet.AdminAuthority);
            name.Clear();
            id.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInterface login = new LoginInterface();
            login.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add();
            add.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete delete = new Delete();  
            delete.Show(); 
        }

        private void modify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify modify = new Modify();
            modify.Show();
        }

        private void studentinfo_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (name.Text=="" && id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentInfo]", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else if(name.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentInfo] WHERE StuID='" + id.Text +"'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if(id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentInfo] WHERE StuName='" + name.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else if(name.Text!="" && id.Text !="")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentInfo] WHERE StuName='" + name.Text + "' AND StuID='"+id.Text+"'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            
        }

        private void teacherinfo_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (name.Text == "" && id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherInfo]", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (name.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherInfo] WHERE TeacherID='" + id.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherInfo] WHERE TeacherName='" + name.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else if(name.Text != "" && id.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherInfo] WHERE TeacherName='" + name.Text + "' AND TeacherID='"+ id.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void courseinfo_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (name.Text == "" && id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[CourseInfo]", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (name.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[CourseInfo] WHERE CourseID='" + id.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (id.Text == "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[CourseInfo] WHERE CourseName='" + name.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }else if(name.Text!="" && id.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[CourseInfo] WHERE CourseName='" + name.Text + "' AND CourseID='" + id.Text + "'", connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void choosecourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryCourseChoosingAndScore ccscore = new QueryCourseChoosingAndScore();
            ccscore.Show();
        }

        private void avgscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryAverageScore avgscore = new QueryAverageScore();
            avgscore.Show();
        }
    }
}
