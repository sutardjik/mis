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
    public partial class QueryCourseChoosingAndScore : Form
    {
        public QueryCourseChoosingAndScore()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void chooseCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chooseCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void QueryCourseChoosingAndScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.ChooseCourse' table. You can move, or remove it, as needed.
            //this.chooseCourseTableAdapter.Fill(this.masterDataSet.ChooseCourse);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface admin = new AdminInterface();
            admin.Show();
        }
        private void confirm_Click_1(object sender, EventArgs e)
        {
            if (student.Checked == true)
            {
                this.Hide();
                StuDisplayData sdd = new StuDisplayData();
                sdd.Show();
            }
            else if(teacher.Checked == true)
            {
                this.Hide();
                TeacherDisplayData tdd = new TeacherDisplayData();
                tdd.Show();
            }
            else if(course.Checked == true)
            {
                this.Hide();
                CourseDisplayData cdd = new CourseDisplayData();
                cdd.Show();
            }else if(score.Checked == true)
            {
                this.Hide();
                ScoreDataDisplay sdd = new ScoreDataDisplay();
                sdd.Show();
            }
            else
            {
                MessageBox.Show("Select an option to query by.", "FAILED TO SELECT AN OPTION");
            }
        }
    }
}
