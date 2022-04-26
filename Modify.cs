using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);

        }

        private void studentinfo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface adminInterface = new AdminInterface();
            adminInterface.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (studentinfo.Checked == true)
            {
                this.Hide();
                ModifyStudentInfo msi = new ModifyStudentInfo();
                msi.Show();
            }
            else if(teacherinfo.Checked==true)
            {
                this.Hide();
                ModifyTeacherInfo mti = new ModifyTeacherInfo();
                mti.Show();
            }
            else if (courseinfo.Checked == true)
            {
                this.Hide();
                ModifyCourseInfo mci = new ModifyCourseInfo();
                mci.Show();
            }
            else if(choosecourse.Checked == true)
            {
                this.Hide();
                ModifyCourseChoosing mcc = new ModifyCourseChoosing();
                mcc.Show();
            }
            else
            {
                MessageBox.Show("Select a table to modify.", "FAILED TO SELECT A TABLE");
            }
        }
    }
}
