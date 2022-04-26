namespace test
{
    partial class AddCourse
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
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label courseNameLabel;
            System.Windows.Forms.Label teacherIDLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label courseGradeLabel;
            System.Windows.Forms.Label cancelYearLabel;
            this.masterDataSet = new test.masterDataSet();
            this.teacherAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherAuthorityTableAdapter = new test.masterDataSetTableAdapters.TeacherAuthorityTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.courseInfoTableAdapter = new test.masterDataSetTableAdapters.CourseInfoTableAdapter();
            this.teacherInfoTableAdapter = new test.masterDataSetTableAdapters.TeacherInfoTableAdapter();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.ComboBox();
            this.coursegrade = new System.Windows.Forms.ComboBox();
            this.teacherid = new System.Windows.Forms.ComboBox();
            this.cancelYearTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.ComboBox();
            this.teacherInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            courseIDLabel = new System.Windows.Forms.Label();
            courseNameLabel = new System.Windows.Forms.Label();
            teacherIDLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            courseGradeLabel = new System.Windows.Forms.Label();
            cancelYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(98, 31);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(57, 13);
            courseIDLabel.TabIndex = 29;
            courseIDLabel.Text = "Course ID:";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new System.Drawing.Point(81, 57);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new System.Drawing.Size(74, 13);
            courseNameLabel.TabIndex = 31;
            courseNameLabel.Text = "Course Name:";
            // 
            // teacherIDLabel
            // 
            teacherIDLabel.AutoSize = true;
            teacherIDLabel.Location = new System.Drawing.Point(91, 83);
            teacherIDLabel.Name = "teacherIDLabel";
            teacherIDLabel.Size = new System.Drawing.Size(64, 13);
            teacherIDLabel.TabIndex = 33;
            teacherIDLabel.Text = "Teacher ID:";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Location = new System.Drawing.Point(118, 109);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(37, 13);
            creditLabel.TabIndex = 35;
            creditLabel.Text = "Credit:";
            // 
            // courseGradeLabel
            // 
            courseGradeLabel.AutoSize = true;
            courseGradeLabel.Location = new System.Drawing.Point(81, 135);
            courseGradeLabel.Name = "courseGradeLabel";
            courseGradeLabel.Size = new System.Drawing.Size(75, 13);
            courseGradeLabel.TabIndex = 37;
            courseGradeLabel.Text = "Course Grade:";
            // 
            // cancelYearLabel
            // 
            cancelYearLabel.AutoSize = true;
            cancelYearLabel.Location = new System.Drawing.Point(88, 161);
            cancelYearLabel.Name = "cancelYearLabel";
            cancelYearLabel.Size = new System.Drawing.Size(68, 13);
            cancelYearLabel.TabIndex = 39;
            cancelYearLabel.Text = "Cancel Year:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherAuthorityBindingSource
            // 
            this.teacherAuthorityBindingSource.DataMember = "TeacherAuthority";
            this.teacherAuthorityBindingSource.DataSource = this.masterDataSet;
            // 
            // teacherAuthorityTableAdapter
            // 
            this.teacherAuthorityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = null;
            this.tableAdapterManager.CourseInfoTableAdapter = this.courseInfoTableAdapter;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = this.teacherAuthorityTableAdapter;
            this.tableAdapterManager.TeacherInfoTableAdapter = this.teacherInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseInfoTableAdapter
            // 
            this.courseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // courseInfoBindingSource
            // 
            this.courseInfoBindingSource.DataMember = "CourseInfo";
            this.courseInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(187, 208);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 29;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseInfoBindingSource, "CourseID", true));
            this.courseIDTextBox.Location = new System.Drawing.Point(162, 28);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIDTextBox.TabIndex = 30;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 205);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 66);
            this.save.TabIndex = 41;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // credit
            // 
            this.credit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.credit.FormattingEnabled = true;
            this.credit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.credit.Location = new System.Drawing.Point(162, 106);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(100, 21);
            this.credit.TabIndex = 42;
            // 
            // coursegrade
            // 
            this.coursegrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursegrade.FormattingEnabled = true;
            this.coursegrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.coursegrade.Location = new System.Drawing.Point(162, 131);
            this.coursegrade.Name = "coursegrade";
            this.coursegrade.Size = new System.Drawing.Size(100, 21);
            this.coursegrade.TabIndex = 43;
            // 
            // teacherid
            // 
            this.teacherid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseInfoBindingSource, "TeacherID", true));
            this.teacherid.DataSource = this.teacherInfoBindingSource;
            this.teacherid.DisplayMember = "TeacherID";
            this.teacherid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherid.FormattingEnabled = true;
            this.teacherid.Location = new System.Drawing.Point(162, 80);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(100, 21);
            this.teacherid.TabIndex = 44;
            this.teacherid.ValueMember = "TeacherID";
            // 
            // cancelYearTextBox
            // 
            this.cancelYearTextBox.Location = new System.Drawing.Point(162, 158);
            this.cancelYearTextBox.Name = "cancelYearTextBox";
            this.cancelYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.cancelYearTextBox.TabIndex = 45;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseInfoBindingSource, "CourseName", true));
            this.courseNameTextBox.DataSource = this.teacherInfoBindingSource1;
            this.courseNameTextBox.DisplayMember = "TeachCourse";
            this.courseNameTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseNameTextBox.FormattingEnabled = true;
            this.courseNameTextBox.Location = new System.Drawing.Point(161, 54);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.courseNameTextBox.TabIndex = 46;
            this.courseNameTextBox.ValueMember = "TeachCourse";
            // 
            // teacherInfoBindingSource1
            // 
            this.teacherInfoBindingSource1.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource1.DataSource = this.masterDataSet;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 293);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.cancelYearTextBox);
            this.Controls.Add(this.teacherid);
            this.Controls.Add(this.coursegrade);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.save);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(courseNameLabel);
            this.Controls.Add(teacherIDLabel);
            this.Controls.Add(creditLabel);
            this.Controls.Add(courseGradeLabel);
            this.Controls.Add(cancelYearLabel);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 332);
            this.MinimumSize = new System.Drawing.Size(367, 332);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource teacherAuthorityBindingSource;
        private masterDataSetTableAdapters.TeacherAuthorityTableAdapter teacherAuthorityTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private masterDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private masterDataSetTableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox credit;
        private System.Windows.Forms.ComboBox coursegrade;
        private System.Windows.Forms.ComboBox teacherid;
        private System.Windows.Forms.TextBox cancelYearTextBox;
        private System.Windows.Forms.ComboBox courseNameTextBox;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource1;
    }
}