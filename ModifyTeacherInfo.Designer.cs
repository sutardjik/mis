namespace test
{
    partial class ModifyTeacherInfo
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label stuIDLabel;
            System.Windows.Forms.Label teacherIDLabel;
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label label3;
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.modifyvalue = new System.Windows.Forms.TextBox();
            this.stuIDTextBox = new System.Windows.Forms.TextBox();
            this.teacherIDTextBox = new System.Windows.Forms.TextBox();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.teachcourse = new System.Windows.Forms.RadioButton();
            this.teachname = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            teacherIDLabel = new System.Windows.Forms.Label();
            courseIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(666, 150);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 42;
            label2.Text = "Column to Modify:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(541, 389);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 37;
            label1.Text = "Modified Value:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(584, 247);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(40, 13);
            stuIDLabel.TabIndex = 35;
            stuIDLabel.Text = "Stu ID:";
            // 
            // teacherIDLabel
            // 
            teacherIDLabel.AutoSize = true;
            teacherIDLabel.Location = new System.Drawing.Point(560, 290);
            teacherIDLabel.Name = "teacherIDLabel";
            teacherIDLabel.Size = new System.Drawing.Size(64, 13);
            teacherIDLabel.TabIndex = 33;
            teacherIDLabel.Text = "Teacher ID:";
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(567, 332);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(57, 13);
            courseIDLabel.TabIndex = 31;
            courseIDLabel.Text = "Course ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(61, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 13);
            label3.TabIndex = 43;
            label3.Text = "Column to Modify:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(185, 110);
            this.exit.MinimumSize = new System.Drawing.Size(140, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 40;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(17, 110);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 39;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // modifyvalue
            // 
            this.modifyvalue.Location = new System.Drawing.Point(630, 386);
            this.modifyvalue.Name = "modifyvalue";
            this.modifyvalue.Size = new System.Drawing.Size(127, 20);
            this.modifyvalue.TabIndex = 38;
            // 
            // stuIDTextBox
            // 
            this.stuIDTextBox.Location = new System.Drawing.Point(630, 244);
            this.stuIDTextBox.Name = "stuIDTextBox";
            this.stuIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.stuIDTextBox.TabIndex = 36;
            // 
            // teacherIDTextBox
            // 
            this.teacherIDTextBox.Location = new System.Drawing.Point(630, 287);
            this.teacherIDTextBox.Name = "teacherIDTextBox";
            this.teacherIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.teacherIDTextBox.TabIndex = 34;
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(630, 329);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.courseIDTextBox.TabIndex = 32;
            // 
            // teachcourse
            // 
            this.teachcourse.AutoSize = true;
            this.teachcourse.Location = new System.Drawing.Point(167, 64);
            this.teachcourse.Name = "teachcourse";
            this.teachcourse.Size = new System.Drawing.Size(89, 17);
            this.teachcourse.TabIndex = 45;
            this.teachcourse.TabStop = true;
            this.teachcourse.Text = "TeachCourse";
            this.teachcourse.UseVisualStyleBackColor = true;
            // 
            // teachname
            // 
            this.teachname.AutoSize = true;
            this.teachname.Location = new System.Drawing.Point(167, 32);
            this.teachname.Name = "teachname";
            this.teachname.Size = new System.Drawing.Size(93, 17);
            this.teachname.TabIndex = 44;
            this.teachname.TabStop = true;
            this.teachname.Text = "TeacherName";
            this.teachname.UseVisualStyleBackColor = true;
            // 
            // ModifyTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 199);
            this.Controls.Add(this.teachcourse);
            this.Controls.Add(this.teachname);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(label1);
            this.Controls.Add(this.modifyvalue);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.stuIDTextBox);
            this.Controls.Add(teacherIDLabel);
            this.Controls.Add(this.teacherIDTextBox);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 238);
            this.MinimumSize = new System.Drawing.Size(365, 238);
            this.Name = "ModifyTeacherInfo";
            this.Text = "ModifyTeacherInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox modifyvalue;
        private System.Windows.Forms.TextBox stuIDTextBox;
        private System.Windows.Forms.TextBox teacherIDTextBox;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.RadioButton teachcourse;
        private System.Windows.Forms.RadioButton teachname;
    }
}