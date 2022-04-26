namespace test
{
    partial class ModifyCancelYear
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label stuIDLabel;
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.masterDataSet = new test.masterDataSet();
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInfoTableAdapter = new test.masterDataSetTableAdapters.CourseInfoTableAdapter();
            this.modifyvalue = new System.Windows.Forms.TextBox();
            this.teacherAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherAuthorityTableAdapter = new test.masterDataSetTableAdapters.TeacherAuthorityTableAdapter();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            label1 = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(52, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 13);
            label1.TabIndex = 44;
            label1.Text = "Modified CancelYear:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(103, 31);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(57, 13);
            stuIDLabel.TabIndex = 42;
            stuIDLabel.Text = "Course ID:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(194, 115);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 46;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(26, 115);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 45;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(166, 28);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.courseIDTextBox.TabIndex = 43;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // modifyvalue
            // 
            this.modifyvalue.Location = new System.Drawing.Point(166, 64);
            this.modifyvalue.Name = "modifyvalue";
            this.modifyvalue.Size = new System.Drawing.Size(127, 20);
            this.modifyvalue.TabIndex = 48;
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
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyCancelYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.modifyvalue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(label1);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 250);
            this.MinimumSize = new System.Drawing.Size(378, 250);
            this.Name = "ModifyCancelYear";
            this.Text = "ModifyCancelYear";
            this.Load += new System.EventHandler(this.ModifyCancelYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private masterDataSetTableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
        private System.Windows.Forms.TextBox modifyvalue;
        private System.Windows.Forms.BindingSource teacherAuthorityBindingSource;
        private masterDataSetTableAdapters.TeacherAuthorityTableAdapter teacherAuthorityTableAdapter;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
    }
}