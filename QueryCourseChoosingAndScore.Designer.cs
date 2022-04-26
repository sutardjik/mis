namespace test
{
    partial class QueryCourseChoosingAndScore
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
            this.masterDataSet = new test.masterDataSet();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.exit = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.RadioButton();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(131, 13);
            label3.TabIndex = 36;
            label3.Text = "Select a Method to Query:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chooseCourseBindingSource
            // 
            this.chooseCourseBindingSource.DataMember = "ChooseCourse";
            this.chooseCourseBindingSource.DataSource = this.masterDataSet;
            // 
            // chooseCourseTableAdapter
            // 
            this.chooseCourseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = this.chooseCourseTableAdapter;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(208, 128);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 16;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(46, 128);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(140, 63);
            this.confirm.TabIndex = 37;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(273, 82);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(53, 17);
            this.score.TabIndex = 35;
            this.score.TabStop = true;
            this.score.Text = "Score";
            this.score.UseVisualStyleBackColor = true;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(178, 82);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(72, 17);
            this.course.TabIndex = 34;
            this.course.TabStop = true;
            this.course.Text = "Course ID";
            this.course.UseVisualStyleBackColor = true;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(273, 43);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(79, 17);
            this.teacher.TabIndex = 33;
            this.teacher.TabStop = true;
            this.teacher.Text = "Teacher ID";
            this.teacher.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(178, 43);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(76, 17);
            this.student.TabIndex = 32;
            this.student.TabStop = true;
            this.student.Text = "Student ID";
            this.student.UseVisualStyleBackColor = true;
            // 
            // QueryCourseChoosingAndScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.confirm);
            this.Controls.Add(label3);
            this.Controls.Add(this.score);
            this.Controls.Add(this.course);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.student);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 262);
            this.MinimumSize = new System.Drawing.Size(418, 262);
            this.Name = "QueryCourseChoosingAndScore";
            this.Text = "QueryCourseChoosingAndScore";
            this.Load += new System.EventHandler(this.QueryCourseChoosingAndScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.RadioButton score;
        private System.Windows.Forms.RadioButton course;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton student;
    }
}