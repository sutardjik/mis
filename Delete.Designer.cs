namespace test
{
    partial class Delete
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
            System.Windows.Forms.Label label3;
            this.choosecourse = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 13);
            label3.TabIndex = 20;
            label3.Text = "Select an Item for Deletion:";
            // 
            // choosecourse
            // 
            this.choosecourse.AutoSize = true;
            this.choosecourse.Location = new System.Drawing.Point(190, 89);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(105, 17);
            this.choosecourse.TabIndex = 7;
            this.choosecourse.TabStop = true;
            this.choosecourse.Text = "Course Choosing";
            this.choosecourse.UseVisualStyleBackColor = true;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(190, 56);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(58, 17);
            this.course.TabIndex = 6;
            this.course.TabStop = true;
            this.course.Text = "Course";
            this.course.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(190, 23);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(62, 17);
            this.student.TabIndex = 4;
            this.student.TabStop = true;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(24, 127);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 25;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(190, 127);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 26;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 211);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(label3);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.course);
            this.Controls.Add(this.student);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 250);
            this.MinimumSize = new System.Drawing.Size(373, 250);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choosecourse;
        private System.Windows.Forms.RadioButton course;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
    }
}