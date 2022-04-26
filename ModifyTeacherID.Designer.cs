namespace test
{
    partial class ModifyTeacherID
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
            System.Windows.Forms.Label coursename;
            System.Windows.Forms.Label stuIDLabel;
            this.modvalue = new System.Windows.Forms.ComboBox();
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new test.masterDataSet();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.teacherInfoTableAdapter = new test.masterDataSetTableAdapters.TeacherInfoTableAdapter();
            this.courseInfoTableAdapter = new test.masterDataSetTableAdapters.CourseInfoTableAdapter();
            coursename = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // coursename
            // 
            coursename.AutoSize = true;
            coursename.Location = new System.Drawing.Point(54, 72);
            coursename.Name = "coursename";
            coursename.Size = new System.Drawing.Size(104, 13);
            coursename.TabIndex = 57;
            coursename.Text = "Modified TeacherID:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(101, 30);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(57, 13);
            stuIDLabel.TabIndex = 55;
            stuIDLabel.Text = "Course ID:";
            // 
            // modvalue
            // 
            this.modvalue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseInfoBindingSource, "TeacherID", true));
            this.modvalue.DataSource = this.teacherInfoBindingSource;
            this.modvalue.DisplayMember = "TeacherID";
            this.modvalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modvalue.FormattingEnabled = true;
            this.modvalue.Location = new System.Drawing.Point(171, 69);
            this.modvalue.MaximumSize = new System.Drawing.Size(127, 0);
            this.modvalue.MinimumSize = new System.Drawing.Size(127, 0);
            this.modvalue.Name = "modvalue";
            this.modvalue.Size = new System.Drawing.Size(127, 21);
            this.modvalue.TabIndex = 60;
            this.modvalue.ValueMember = "TeacherID";
            // 
            // courseInfoBindingSource
            // 
            this.courseInfoBindingSource.DataMember = "CourseInfo";
            this.courseInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(193, 118);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 59;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(25, 118);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 58;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(171, 27);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.courseIDTextBox.TabIndex = 56;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // courseInfoTableAdapter
            // 
            this.courseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyTeacherID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.modvalue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(coursename);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 250);
            this.MinimumSize = new System.Drawing.Size(378, 250);
            this.Name = "ModifyTeacherID";
            this.Text = "ModifyTeacherID";
            this.Load += new System.EventHandler(this.ModifyTeacherID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modvalue;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private masterDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private masterDataSetTableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
    }
}