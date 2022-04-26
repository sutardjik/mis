namespace test
{
    partial class Modify
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
            this.studentinfo = new System.Windows.Forms.RadioButton();
            this.courseinfo = new System.Windows.Forms.RadioButton();
            this.teacherinfo = new System.Windows.Forms.RadioButton();
            this.choosecourse = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Button();
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.confirm = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 13);
            label3.TabIndex = 19;
            label3.Text = "Select a Table:";
            // 
            // studentinfo
            // 
            this.studentinfo.AutoSize = true;
            this.studentinfo.Location = new System.Drawing.Point(120, 30);
            this.studentinfo.Name = "studentinfo";
            this.studentinfo.Size = new System.Drawing.Size(83, 17);
            this.studentinfo.TabIndex = 0;
            this.studentinfo.TabStop = true;
            this.studentinfo.Text = "Student Info";
            this.studentinfo.UseVisualStyleBackColor = true;
            this.studentinfo.CheckedChanged += new System.EventHandler(this.studentinfo_CheckedChanged);
            // 
            // courseinfo
            // 
            this.courseinfo.AutoSize = true;
            this.courseinfo.Location = new System.Drawing.Point(120, 67);
            this.courseinfo.Name = "courseinfo";
            this.courseinfo.Size = new System.Drawing.Size(79, 17);
            this.courseinfo.TabIndex = 1;
            this.courseinfo.TabStop = true;
            this.courseinfo.Text = "Course Info";
            this.courseinfo.UseVisualStyleBackColor = true;
            // 
            // teacherinfo
            // 
            this.teacherinfo.AutoSize = true;
            this.teacherinfo.Location = new System.Drawing.Point(228, 30);
            this.teacherinfo.Name = "teacherinfo";
            this.teacherinfo.Size = new System.Drawing.Size(86, 17);
            this.teacherinfo.TabIndex = 2;
            this.teacherinfo.TabStop = true;
            this.teacherinfo.Text = "Teacher Info";
            this.teacherinfo.UseVisualStyleBackColor = true;
            // 
            // choosecourse
            // 
            this.choosecourse.AutoSize = true;
            this.choosecourse.Location = new System.Drawing.Point(228, 67);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(105, 17);
            this.choosecourse.TabIndex = 3;
            this.choosecourse.TabStop = true;
            this.choosecourse.Text = "Course Choosing";
            this.choosecourse.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(193, 111);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 16;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(25, 111);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(140, 63);
            this.confirm.TabIndex = 15;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 200);
            this.Controls.Add(label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.teacherinfo);
            this.Controls.Add(this.courseinfo);
            this.Controls.Add(this.studentinfo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 239);
            this.MinimumSize = new System.Drawing.Size(380, 239);
            this.Name = "Modify";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton studentinfo;
        private System.Windows.Forms.RadioButton courseinfo;
        private System.Windows.Forms.RadioButton teacherinfo;
        private System.Windows.Forms.RadioButton choosecourse;
        private System.Windows.Forms.Button exit;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.Button confirm;
    }
}