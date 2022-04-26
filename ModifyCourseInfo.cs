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
    public partial class ModifyCourseInfo : Form
    {
        public ModifyCourseInfo()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ModifyCourseInfo_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify m = new Modify();
            m.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (coursename.Checked == true)
            {
                this.Hide();
                ModifyCourseName mcn = new ModifyCourseName();
                mcn.Show();
            } else if (coursegrade.Checked == true)
            {
                this.Hide();
                ModifyCourseGrade mg = new ModifyCourseGrade();
                mg.Show();
            }
            else if (credit.Checked == true)
            {
                this.Hide();
                ModifyCredit mc = new ModifyCredit();
                mc.Show();
            }
            else if (cancelyear.Checked == true)
            {
                this.Hide();
                ModifyCancelYear mcy = new ModifyCancelYear();
                mcy.Show();
            } else if (teacherid.Checked == true)
            {
                this.Hide();
                ModifyTeacherID mt = new ModifyTeacherID();
                mt.Show();
            }
            else
            {
                MessageBox.Show("Select a column to modify.", "FAILED TO SELECT A COLUMN");
            }
        }
    }
}
