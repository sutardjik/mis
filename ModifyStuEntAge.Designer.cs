namespace test
{
    partial class ModifyStuEntAge
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
            this.modvalue = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.stuIDTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            stuIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 13);
            label1.TabIndex = 38;
            label1.Text = "Modified EntAge:";
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(104, 32);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(40, 13);
            stuIDLabel.TabIndex = 36;
            stuIDLabel.Text = "Stu ID:";
            // 
            // modvalue
            // 
            this.modvalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modvalue.FormattingEnabled = true;
            this.modvalue.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.modvalue.Location = new System.Drawing.Point(149, 65);
            this.modvalue.MaximumSize = new System.Drawing.Size(127, 0);
            this.modvalue.MinimumSize = new System.Drawing.Size(127, 0);
            this.modvalue.Name = "modvalue";
            this.modvalue.Size = new System.Drawing.Size(127, 21);
            this.modvalue.TabIndex = 41;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(193, 116);
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
            this.save.Location = new System.Drawing.Point(25, 116);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 63);
            this.save.TabIndex = 39;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // stuIDTextBox
            // 
            this.stuIDTextBox.Location = new System.Drawing.Point(149, 29);
            this.stuIDTextBox.Name = "stuIDTextBox";
            this.stuIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.stuIDTextBox.TabIndex = 37;
            // 
            // ModifyStuEntAge
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
            this.Name = "ModifyStuEntAge";
            this.Text = "ModifyStuEntAge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modvalue;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox stuIDTextBox;
    }
}