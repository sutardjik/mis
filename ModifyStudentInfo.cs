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
    public partial class ModifyStudentInfo : Form
    {
        public ModifyStudentInfo()
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
            if (stuname.Checked == true)
            {
                this.Hide();
                ModifyStuName msn = new ModifyStuName();
                msn.Show();
            }
            else if (stuclass.Checked == true)
            {
                this.Hide();
                ModifyStuClass msc = new ModifyStuClass();
                msc.Show();

            }
            else if (sex.Checked == true)
            {
                this.Hide();
                ModifyStuSex mss = new ModifyStuSex();
                mss.Show();
            }
            else if (grade.Checked == true)
            {
                this.Hide();
                ModifyStuGrade msg = new ModifyStuGrade();
                msg.Show();
            }else if (entyear.Checked == true)
            {
                this.Hide();
                ModifyStuEntYear msy = new ModifyStuEntYear();
                msy.Show();
            }else if(entage.Checked == true)
            {
                this.Hide();
                ModifyStuEntAge msa = new ModifyStuEntAge();
                msa.Show();
            }
            else
            {
                MessageBox.Show("Select a column modify.", "FAILED TO SELECT AN COLUMN");
            }

        }

        private void ModifyStudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
