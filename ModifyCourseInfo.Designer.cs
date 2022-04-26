namespace test
{
    partial class ModifyCourseInfo
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
            System.Windows.Forms.Label label1;
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancelyear = new System.Windows.Forms.RadioButton();
            this.coursegrade = new System.Windows.Forms.RadioButton();
            this.credit = new System.Windows.Forms.RadioButton();
            this.coursename = new System.Windows.Forms.RadioButton();
            this.teacherid = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 55;
            label1.Text = "Column to Modify:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(225, 101);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 52;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(52, 101);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 51;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancelyear
            // 
            this.cancelyear.AutoSize = true;
            this.cancelyear.Location = new System.Drawing.Point(164, 63);
            this.cancelyear.Name = "cancelyear";
            this.cancelyear.Size = new System.Drawing.Size(80, 17);
            this.cancelyear.TabIndex = 59;
            this.cancelyear.TabStop = true;
            this.cancelyear.Text = "CancelYear";
            this.cancelyear.UseVisualStyleBackColor = true;
            // 
            // coursegrade
            // 
            this.coursegrade.AutoSize = true;
            this.coursegrade.Location = new System.Drawing.Point(278, 63);
            this.coursegrade.Name = "coursegrade";
            this.coursegrade.Size = new System.Drawing.Size(87, 17);
            this.coursegrade.TabIndex = 58;
            this.coursegrade.TabStop = true;
            this.coursegrade.Text = "CourseGrade";
            this.coursegrade.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(340, 27);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(52, 17);
            this.credit.TabIndex = 57;
            this.credit.TabStop = true;
            this.credit.Text = "Credit";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Location = new System.Drawing.Point(131, 27);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(86, 17);
            this.coursename.TabIndex = 56;
            this.coursename.TabStop = true;
            this.coursename.Text = "CourseName";
            this.coursename.UseVisualStyleBackColor = true;
            // 
            // teacherid
            // 
            this.teacherid.AutoSize = true;
            this.teacherid.Location = new System.Drawing.Point(237, 27);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(76, 17);
            this.teacherid.TabIndex = 60;
            this.teacherid.TabStop = true;
            this.teacherid.Text = "TeacherID";
            this.teacherid.UseVisualStyleBackColor = true;
            // 
            // ModifyCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 186);
            this.Controls.Add(this.teacherid);
            this.Controls.Add(this.cancelyear);
            this.Controls.Add(this.coursegrade);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.coursename);
            this.Controls.Add(label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 225);
            this.MinimumSize = new System.Drawing.Size(434, 225);
            this.Name = "ModifyCourseInfo";
            this.Text = "ModifyCourseInfo";
            this.Load += new System.EventHandler(this.ModifyCourseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton cancelyear;
        private System.Windows.Forms.RadioButton coursegrade;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.RadioButton coursename;
        private System.Windows.Forms.RadioButton teacherid;
    }
}