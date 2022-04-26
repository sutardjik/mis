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

namespace test
{
    public partial class ModifyCourseTeacherID : Form
    {
        public ModifyCourseTeacherID()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyCourseChoosing mcc = new ModifyCourseChoosing();
            mcc.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-DCOJKS07\MSSQLSERVER01;Initial Catalog=master;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            if (stuIDTextBox.Text == "" || modvalue.Text == "")
            {
                MessageBox.Show("All fields must be filled.", "EMPTY TEXT FIELD(S)");
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "UPDATE ChooseCourse SET TeacherID='" + modvalue.Text + "' WHERE StuID='" + stuIDTextBox.Text + "'";
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("TeacherID updated.", "TABLE VALUE UPDATED");
            }
        }

        private void ModifyCourseTeacherID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.ChooseCourse' table. You can move, or remove it, as needed.
            //this.chooseCourseTableAdapter.Fill(this.masterDataSet.ChooseCourse);
            // TODO: This line of code loads data into the 'masterDataSet.TeacherInfo' table. You can move, or remove it, as needed.
            this.teacherInfoTableAdapter.Fill(this.masterDataSet.TeacherInfo);
            modvalue.SelectedIndex = -1;

        }
    }
}
