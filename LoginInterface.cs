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

namespace test{
    public partial class LoginInterface : Form{
        public static string strtxt1;
        public static string strtxt2;
        public LoginInterface(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void label1_Click(object sender, EventArgs e){}
        private void username_TextChanged(object sender, EventArgs e){strtxt1 = username.Text.ToString();}
        private void password_TextChanged(object sender, EventArgs e){strtxt2=password.Text.ToString();}
        private void login_Click(object sender, EventArgs e){
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (admin.Checked == true){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[AdminAuthority] WHERE AdminID='" + username.Text + "' AND AdminPassword='" + password.Text+"'",connection);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1){
                    MessageBox.Show("Logged in as administrator.", "ADMIN ENTRY");
                    this.Hide();
                    AdminInterface admin = new AdminInterface();
                    admin.Show();
                }else{
                    MessageBox.Show("Incorrect username/password. Try again.", "FAILED LOGIN");
                }
            }else if(teacher.Checked == true){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[TeacherAuthority] WHERE TeacherID='" + username.Text + "' AND TeacherPassword='" + password.Text + "'", connection);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1){
                    MessageBox.Show("Logged in as teacher.", "TEACHER ENTRY");
                    this.Hide();
                    TeacherInterface teacher = new TeacherInterface();
                    teacher.Show();
                }else{
                    MessageBox.Show("Incorrect username/password. Try again.", "FAILED LOGIN");
                }
            }else if(student.Checked == true){
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [master].[dbo].[StudentAuthority] WHERE StuID='" + username.Text + "' AND StuPassword='" + password.Text + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1){
                    MessageBox.Show("Logged in as student.", "STUDENT ENTRY");
                    this.Hide();
                    StudentInterface student = new StudentInterface();
                    student.Show();
                }else{
                    MessageBox.Show("Incorrect username/password. Try again.", "FAILED LOGIN");
                }
            }
        }
        private void exit_Click(object sender, EventArgs e){
            MessageBox.Show("Exited out of system.","EXIT");
            this.Close();
            System.Environment.Exit(0);
        }
    }
}
