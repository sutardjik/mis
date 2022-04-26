namespace test
{
    partial class ModifyCourseChoosing
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
            this.teacherid = new System.Windows.Forms.RadioButton();
            this.chosenyear = new System.Windows.Forms.RadioButton();
            this.courseid = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 61;
            label1.Text = "Column to Modify:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(200, 92);
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
            this.save.Location = new System.Drawing.Point(32, 92);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 51;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // teacherid
            // 
            this.teacherid.AutoSize = true;
            this.teacherid.Location = new System.Drawing.Point(264, 21);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(76, 17);
            this.teacherid.TabIndex = 66;
            this.teacherid.TabStop = true;
            this.teacherid.Text = "TeacherID";
            this.teacherid.UseVisualStyleBackColor = true;
            // 
            // chosenyear
            // 
            this.chosenyear.AutoSize = true;
            this.chosenyear.Location = new System.Drawing.Point(200, 55);
            this.chosenyear.Name = "chosenyear";
            this.chosenyear.Size = new System.Drawing.Size(83, 17);
            this.chosenyear.TabIndex = 65;
            this.chosenyear.TabStop = true;
            this.chosenyear.Text = "ChosenYear";
            this.chosenyear.UseVisualStyleBackColor = true;
            // 
            // courseid
            // 
            this.courseid.AutoSize = true;
            this.courseid.Location = new System.Drawing.Point(148, 23);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(69, 17);
            this.courseid.TabIndex = 62;
            this.courseid.TabStop = true;
            this.courseid.Text = "CourseID";
            this.courseid.UseVisualStyleBackColor = true;
            // 
            // ModifyCourseChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 186);
            this.Controls.Add(this.teacherid);
            this.Controls.Add(this.chosenyear);
            this.Controls.Add(this.courseid);
            this.Controls.Add(label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 225);
            this.MinimumSize = new System.Drawing.Size(389, 225);
            this.Name = "ModifyCourseChoosing";
            this.Text = "ModifyCourseChoosing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton teacherid;
        private System.Windows.Forms.RadioButton chosenyear;
        private System.Windows.Forms.RadioButton courseid;
    }
}