namespace test
{
    partial class DeleteCourse
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
            System.Windows.Forms.Label stuIDLabel;
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            stuIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(95, 25);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(57, 13);
            stuIDLabel.TabIndex = 49;
            stuIDLabel.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(158, 22);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIDTextBox.TabIndex = 50;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(29, 57);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 66);
            this.save.TabIndex = 48;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(199, 60);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 47;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 147);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 186);
            this.MinimumSize = new System.Drawing.Size(379, 186);
            this.Name = "DeleteCourse";
            this.Text = "DeleteCourse";
            this.Load += new System.EventHandler(this.DeleteCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
    }
}