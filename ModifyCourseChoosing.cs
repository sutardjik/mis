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
    public partial class ModifyCourseChoosing : Form
    {
        public ModifyCourseChoosing()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify m = new Modify();
            m.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (courseid.Checked == true)
            {
                this.Hide();
                ModifyCourseID mci = new ModifyCourseID();
                mci.Show();
            }else if(teacherid.Checked == true)
            {
                this.Hide();
                ModifyCourseTeacherID mti = new ModifyCourseTeacherID();
                mti.Show();
            }else if(chosenyear.Checked == true)
            {
                this.Hide();
                ModifyChosenYear mcy = new ModifyChosenYear();
                mcy.Show();
            }
            else
            {
                MessageBox.Show("Select a column modify.", "FAILED TO SELECT A COLUMN");
            }
        }
    }
}
