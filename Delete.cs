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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface admin = new AdminInterface();
            admin.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (student.Checked == true)
            {
                this.Hide();
                DeleteStudent ds = new DeleteStudent();
                ds.Show();
            }else if(course.Checked == true)
            {
                this.Hide();
                DeleteCourse dc = new DeleteCourse();
                dc.Show();
            }
            else if(choosecourse.Checked == true)
            {
                this.Hide();
                DeleteCourseChoosing dcc = new DeleteCourseChoosing();
                dcc.Show();
            }
            else
            {
                MessageBox.Show("Select a table to delete data from.", "FAILED TO SELECT A TABLE");
            }
        }
    }
}
