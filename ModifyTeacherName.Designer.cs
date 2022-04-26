namespace test
{
    partial class ModifyTeacherName
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
            System.Windows.Forms.Label teachname;
            System.Windows.Forms.Label stuIDLabel;
            this.modifyvalue = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.teacherIDTextBox = new System.Windows.Forms.TextBox();
            teachname = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teachname
            // 
            teachname.AutoSize = true;
            teachname.Location = new System.Drawing.Point(47, 69);
            teachname.Name = "teachname";
            teachname.Size = new System.Drawing.Size(121, 13);
            teachname.TabIndex = 44;
            teachname.Text = "Modified TeacherName:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(103, 30);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(64, 13);
            stuIDLabel.TabIndex = 42;
            stuIDLabel.Text = "Teacher ID:";
            // 
            // modifyvalue
            // 
            this.modifyvalue.Location = new System.Drawing.Point(173, 66);
            this.modifyvalue.Name = "modifyvalue";
            this.modifyvalue.Size = new System.Drawing.Size(127, 20);
            this.modifyvalue.TabIndex = 47;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(195, 118);
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
            this.save.Location = new System.Drawing.Point(27, 118);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 45;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // teacherIDTextBox
            // 
            this.teacherIDTextBox.Location = new System.Drawing.Point(173, 27);
            this.teacherIDTextBox.Name = "teacherIDTextBox";
            this.teacherIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.teacherIDTextBox.TabIndex = 43;
            // 
            // ModifyTeacherName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.modifyvalue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(teachname);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.teacherIDTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 250);
            this.MinimumSize = new System.Drawing.Size(378, 250);
            this.Name = "ModifyTeacherName";
            this.Text = "ModifyTeacherName";
            this.Load += new System.EventHandler(this.ModifyTeacherName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifyvalue;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox teacherIDTextBox;
    }
}