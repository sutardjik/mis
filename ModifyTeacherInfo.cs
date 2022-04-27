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

namespace test{
    public partial class ModifyTeacherInfo : Form{
        public ModifyTeacherInfo(){
            InitializeComponent();
            this.CenterToScreen();
        }
        private void exit_Click(object sender, EventArgs e){
            this.Hide();
            Modify m = new Modify();
            m.Show();
        }
        private void save_Click(object sender, EventArgs e){
            if (teachname.Checked == true){
                this.Hide();
                ModifyTeacherName mtn = new ModifyTeacherName();
                mtn.Show();
            }else if(teachcourse.Checked == true){
                this.Hide();
                ModifyTeachCourse mtc = new ModifyTeachCourse();
                mtc.Show();
            }else{
                MessageBox.Show("Select a column to modify.", "FAILED TO SELECT A COLUMN");
            }
        }
    }
}
