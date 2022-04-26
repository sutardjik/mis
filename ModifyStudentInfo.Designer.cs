namespace test
{
    partial class ModifyStudentInfo
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
            System.Windows.Forms.Label label2;
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.stuname = new System.Windows.Forms.RadioButton();
            this.sex = new System.Windows.Forms.RadioButton();
            this.entage = new System.Windows.Forms.RadioButton();
            this.entyear = new System.Windows.Forms.RadioButton();
            this.grade = new System.Windows.Forms.RadioButton();
            this.stuclass = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 30;
            label2.Text = "Column to Modify:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(184, 136);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 28;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 136);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 27;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            // stuname
            // 
            this.stuname.AutoSize = true;
            this.stuname.Location = new System.Drawing.Point(144, 26);
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(69, 17);
            this.stuname.TabIndex = 31;
            this.stuname.TabStop = true;
            this.stuname.Text = "StuName";
            this.stuname.UseVisualStyleBackColor = true;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(232, 26);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(43, 17);
            this.sex.TabIndex = 32;
            this.sex.TabStop = true;
            this.sex.Text = "Sex";
            this.sex.UseVisualStyleBackColor = true;
            // 
            // entage
            // 
            this.entage.AutoSize = true;
            this.entage.Location = new System.Drawing.Point(144, 58);
            this.entage.Name = "entage";
            this.entage.Size = new System.Drawing.Size(60, 17);
            this.entage.TabIndex = 33;
            this.entage.TabStop = true;
            this.entage.Text = "EntAge";
            this.entage.UseVisualStyleBackColor = true;
            // 
            // entyear
            // 
            this.entyear.AutoSize = true;
            this.entyear.Location = new System.Drawing.Point(232, 58);
            this.entyear.Name = "entyear";
            this.entyear.Size = new System.Drawing.Size(63, 17);
            this.entyear.TabIndex = 34;
            this.entyear.TabStop = true;
            this.entyear.Text = "EntYear";
            this.entyear.UseVisualStyleBackColor = true;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(143, 91);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(70, 17);
            this.grade.TabIndex = 35;
            this.grade.TabStop = true;
            this.grade.Text = "StuGrade";
            this.grade.UseVisualStyleBackColor = true;
            // 
            // stuclass
            // 
            this.stuclass.AutoSize = true;
            this.stuclass.Location = new System.Drawing.Point(232, 91);
            this.stuclass.Name = "stuclass";
            this.stuclass.Size = new System.Drawing.Size(50, 17);
            this.stuclass.TabIndex = 36;
            this.stuclass.TabStop = true;
            this.stuclass.Text = "Class";
            this.stuclass.UseVisualStyleBackColor = true;
            // 
            // ModifyStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 221);
            this.Controls.Add(this.stuclass);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.entyear);
            this.Controls.Add(this.entage);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.stuname);
            this.Controls.Add(label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 260);
            this.MinimumSize = new System.Drawing.Size(365, 260);
            this.Name = "ModifyStudentInfo";
            this.Text = "ModifyStudentInfo";
            this.Load += new System.EventHandler(this.ModifyStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.RadioButton stuname;
        private System.Windows.Forms.RadioButton sex;
        private System.Windows.Forms.RadioButton entage;
        private System.Windows.Forms.RadioButton entyear;
        private System.Windows.Forms.RadioButton grade;
        private System.Windows.Forms.RadioButton stuclass;
    }
}