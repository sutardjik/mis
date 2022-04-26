namespace test
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            this.student = new System.Windows.Forms.RadioButton();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.RadioButton();
            this.choosecourse = new System.Windows.Forms.RadioButton();
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.confirm = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 13);
            label3.TabIndex = 20;
            label3.Text = "Select a Table:";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(114, 30);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(83, 17);
            this.student.TabIndex = 0;
            this.student.TabStop = true;
            this.student.Text = "Student Info";
            this.student.UseVisualStyleBackColor = true;
            this.student.CheckedChanged += new System.EventHandler(this.student_CheckedChanged);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(215, 30);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(86, 17);
            this.teacher.TabIndex = 2;
            this.teacher.TabStop = true;
            this.teacher.Text = "Teacher Info";
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.CheckedChanged += new System.EventHandler(this.teacher_CheckedChanged);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(114, 69);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(79, 17);
            this.course.TabIndex = 3;
            this.course.TabStop = true;
            this.course.Text = "Course Info";
            this.course.UseVisualStyleBackColor = true;
            // 
            // choosecourse
            // 
            this.choosecourse.AutoSize = true;
            this.choosecourse.Location = new System.Drawing.Point(215, 69);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(105, 17);
            this.choosecourse.TabIndex = 4;
            this.choosecourse.TabStop = true;
            this.choosecourse.Text = "Course Choosing";
            this.choosecourse.UseVisualStyleBackColor = true;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = null;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(26, 114);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(140, 63);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(180, 114);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 31;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 209);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.confirm);
            this.Controls.Add(label3);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.course);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.student);
            this.MaximumSize = new System.Drawing.Size(368, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 248);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton course;
        private System.Windows.Forms.RadioButton choosecourse;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button exit;
    }
}