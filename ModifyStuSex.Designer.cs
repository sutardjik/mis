namespace test
{
    partial class ModifyStuSex
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
            System.Windows.Forms.Label stuIDLabel;
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.stuIDTextBox = new System.Windows.Forms.TextBox();
            this.modvalue = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 13);
            label1.TabIndex = 44;
            label1.Text = "Modified Sex:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(106, 33);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(40, 13);
            stuIDLabel.TabIndex = 42;
            stuIDLabel.Text = "Stu ID:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(195, 117);
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
            this.save.Location = new System.Drawing.Point(27, 117);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 45;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // stuIDTextBox
            // 
            this.stuIDTextBox.Location = new System.Drawing.Point(151, 30);
            this.stuIDTextBox.Name = "stuIDTextBox";
            this.stuIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.stuIDTextBox.TabIndex = 43;
            // 
            // modvalue
            // 
            this.modvalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modvalue.FormattingEnabled = true;
            this.modvalue.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.modvalue.Location = new System.Drawing.Point(151, 69);
            this.modvalue.MaximumSize = new System.Drawing.Size(127, 0);
            this.modvalue.MinimumSize = new System.Drawing.Size(127, 0);
            this.modvalue.Name = "modvalue";
            this.modvalue.Size = new System.Drawing.Size(127, 21);
            this.modvalue.TabIndex = 47;
            // 
            // ModifyStuSex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.modvalue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(label1);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.stuIDTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 250);
            this.MinimumSize = new System.Drawing.Size(378, 250);
            this.Name = "ModifyStuSex";
            this.Text = "ModifyStuSex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox stuIDTextBox;
        private System.Windows.Forms.ComboBox modvalue;
    }
}