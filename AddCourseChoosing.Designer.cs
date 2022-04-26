namespace test
{
    partial class AddCourseChoosing
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
            System.Windows.Forms.Label stuIDLabel;
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label teacherIDLabel;
            System.Windows.Forms.Label chosenYearLabel;
            System.Windows.Forms.Label scoreLabel;
            this.masterDataSet = new test.masterDataSet();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tid = new System.Windows.Forms.ComboBox();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInfoTableAdapter = new test.masterDataSetTableAdapters.TeacherInfoTableAdapter();
            this.stuid = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.cid = new System.Windows.Forms.ComboBox();
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInfoTableAdapter = new test.masterDataSetTableAdapters.CourseInfoTableAdapter();
            this.chosenyear = new System.Windows.Forms.ComboBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            stuIDLabel = new System.Windows.Forms.Label();
            courseIDLabel = new System.Windows.Forms.Label();
            teacherIDLabel = new System.Windows.Forms.Label();
            chosenYearLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(95, 31);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(40, 13);
            stuIDLabel.TabIndex = 30;
            stuIDLabel.Text = "Stu ID:";
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(78, 57);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(57, 13);
            courseIDLabel.TabIndex = 32;
            courseIDLabel.Text = "Course ID:";
            // 
            // teacherIDLabel
            // 
            teacherIDLabel.AutoSize = true;
            teacherIDLabel.Location = new System.Drawing.Point(71, 84);
            teacherIDLabel.Name = "teacherIDLabel";
            teacherIDLabel.Size = new System.Drawing.Size(64, 13);
            teacherIDLabel.TabIndex = 34;
            teacherIDLabel.Text = "Teacher ID:";
            // 
            // chosenYearLabel
            // 
            chosenYearLabel.AutoSize = true;
            chosenYearLabel.Location = new System.Drawing.Point(64, 110);
            chosenYearLabel.Name = "chosenYearLabel";
            chosenYearLabel.Size = new System.Drawing.Size(71, 13);
            chosenYearLabel.TabIndex = 36;
            chosenYearLabel.Text = "Chosen Year:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(97, 136);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(38, 13);
            scoreLabel.TabIndex = 38;
            scoreLabel.Text = "Score:";
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
            // save
            // 
            this.save.Location = new System.Drawing.Point(24, 177);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 66);
            this.save.TabIndex = 46;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(193, 180);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 45;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // tid
            // 
            this.tid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "TeacherID", true));
            this.tid.DataSource = this.teacherInfoBindingSource;
            this.tid.DisplayMember = "TeacherID";
            this.tid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tid.FormattingEnabled = true;
            this.tid.Location = new System.Drawing.Point(141, 81);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(121, 21);
            this.tid.TabIndex = 47;
            this.tid.ValueMember = "TeacherID";
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // stuid
            // 
            this.stuid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "StuID", true));
            this.stuid.DataSource = this.studentInfoBindingSource;
            this.stuid.DisplayMember = "StuID";
            this.stuid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuid.FormattingEnabled = true;
            this.stuid.Location = new System.Drawing.Point(141, 28);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(121, 21);
            this.stuid.TabIndex = 48;
            this.stuid.ValueMember = "StuID";
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
            // cid
            // 
            this.cid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "CourseID", true));
            this.cid.DataSource = this.courseInfoBindingSource;
            this.cid.DisplayMember = "CourseID";
            this.cid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cid.FormattingEnabled = true;
            this.cid.Location = new System.Drawing.Point(141, 54);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(121, 21);
            this.cid.TabIndex = 49;
            this.cid.ValueMember = "CourseID";
            // 
            // courseInfoBindingSource
            // 
            this.courseInfoBindingSource.DataMember = "CourseInfo";
            this.courseInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // courseInfoTableAdapter
            // 
            this.courseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // chosenyear
            // 
            this.chosenyear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "TeacherID", true));
            this.chosenyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenyear.FormattingEnabled = true;
            this.chosenyear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.chosenyear.Location = new System.Drawing.Point(141, 107);
            this.chosenyear.Name = "chosenyear";
            this.chosenyear.Size = new System.Drawing.Size(121, 21);
            this.chosenyear.TabIndex = 50;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(141, 136);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(121, 20);
            this.scoreTextBox.TabIndex = 51;
            // 
            // AddCourseChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 268);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.chosenyear);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(teacherIDLabel);
            this.Controls.Add(chosenYearLabel);
            this.Controls.Add(scoreLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 307);
            this.MinimumSize = new System.Drawing.Size(378, 307);
            this.Name = "AddCourseChoosing";
            this.Text = "AddCourseChoosing";
            this.Load += new System.EventHandler(this.AddCourseChoosing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox tid;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private masterDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private System.Windows.Forms.ComboBox stuid;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.ComboBox cid;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private masterDataSetTableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
        private System.Windows.Forms.ComboBox chosenyear;
        private System.Windows.Forms.TextBox scoreTextBox;
    }
}