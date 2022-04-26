namespace test
{
    partial class StudentInterface
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.personalinfo = new System.Windows.Forms.Button();
            this.coursechoosinginfo = new System.Windows.Forms.Button();
            this.chooseclass = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(835, 447);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 7;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // personalinfo
            // 
            this.personalinfo.Location = new System.Drawing.Point(31, 140);
            this.personalinfo.Name = "personalinfo";
            this.personalinfo.Size = new System.Drawing.Size(140, 66);
            this.personalinfo.TabIndex = 8;
            this.personalinfo.Text = "QUERY PERSONAL INFO";
            this.personalinfo.UseVisualStyleBackColor = true;
            this.personalinfo.Click += new System.EventHandler(this.personalinfo_Click);
            // 
            // coursechoosinginfo
            // 
            this.coursechoosinginfo.Location = new System.Drawing.Point(31, 243);
            this.coursechoosinginfo.Name = "coursechoosinginfo";
            this.coursechoosinginfo.Size = new System.Drawing.Size(140, 66);
            this.coursechoosinginfo.TabIndex = 10;
            this.coursechoosinginfo.Text = "QUERY COURSE CHOOSING INFO";
            this.coursechoosinginfo.UseVisualStyleBackColor = true;
            this.coursechoosinginfo.Click += new System.EventHandler(this.coursechoosinginfo_Click);
            // 
            // chooseclass
            // 
            this.chooseclass.Location = new System.Drawing.Point(31, 42);
            this.chooseclass.Name = "chooseclass";
            this.chooseclass.Size = new System.Drawing.Size(140, 66);
            this.chooseclass.TabIndex = 11;
            this.chooseclass.Text = "CHOOSE CLASS";
            this.chooseclass.UseVisualStyleBackColor = true;
            this.chooseclass.Click += new System.EventHandler(this.chooseclass_Click);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(31, 349);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(140, 66);
            this.score.TabIndex = 12;
            this.score.Text = "QUERY SCORE";
            this.score.UseVisualStyleBackColor = true;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // StudentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 539);
            this.Controls.Add(this.score);
            this.Controls.Add(this.chooseclass);
            this.Controls.Add(this.coursechoosinginfo);
            this.Controls.Add(this.personalinfo);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1036, 578);
            this.MinimumSize = new System.Drawing.Size(1036, 578);
            this.Name = "StudentInterface";
            this.Text = "StudentInterface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button personalinfo;
        private System.Windows.Forms.Button coursechoosinginfo;
        private System.Windows.Forms.Button chooseclass;
        private System.Windows.Forms.Button score;
    }
}