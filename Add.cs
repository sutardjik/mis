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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.StudentInfo' table. You can move, or remove it, as needed.
            //this.studentInfoTableAdapter.Fill(this.masterDataSet.StudentInfo);

        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (student.Checked == true)
            {
                this.Hide();
                AddStudent student = new AddStudent();
                student.Show();
            }
            else if(course.Checked == true) 
            {
                this.Hide();
                AddCourse course = new AddCourse();
                course.Show();
            }else if(teacher.Checked == true)
            {
                this.Hide();
                AddTeacher teacher = new AddTeacher();
                teacher.Show();
            }else if(choosecourse.Checked == true)
            {
                this.Hide();
                AddCourseChoosing choose = new AddCourseChoosing();
                choose.Show();
            }
            else
            {
                MessageBox.Show("Select a table to add data to.", "FAILED TO SELECT A TABLE");
            }
        }
        //temp location
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface main = new AdminInterface();
            main.Show();
        }
    }
}
