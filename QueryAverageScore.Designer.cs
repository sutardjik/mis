namespace test
{
    partial class QueryAverageScore
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
            this.individual = new System.Windows.Forms.Button();
            this.overallscore = new System.Windows.Forms.Button();
            this.classgpa = new System.Windows.Forms.Button();
            this.coursescore = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // individual
            // 
            this.individual.Location = new System.Drawing.Point(32, 38);
            this.individual.Name = "individual";
            this.individual.Size = new System.Drawing.Size(140, 66);
            this.individual.TabIndex = 3;
            this.individual.Text = "INDIVIDUAL STUDENT";
            this.individual.UseVisualStyleBackColor = true;
            this.individual.Click += new System.EventHandler(this.gpa_Click);
            // 
            // overallscore
            // 
            this.overallscore.Location = new System.Drawing.Point(32, 138);
            this.overallscore.Name = "overallscore";
            this.overallscore.Size = new System.Drawing.Size(140, 66);
            this.overallscore.TabIndex = 4;
            this.overallscore.Text = "ALL STUDENTS";
            this.overallscore.UseVisualStyleBackColor = true;
            this.overallscore.Click += new System.EventHandler(this.overallgpa_Click);
            // 
            // classgpa
            // 
            this.classgpa.Location = new System.Drawing.Point(32, 237);
            this.classgpa.Name = "classgpa";
            this.classgpa.Size = new System.Drawing.Size(140, 66);
            this.classgpa.TabIndex = 5;
            this.classgpa.Text = "CLASS";
            this.classgpa.UseVisualStyleBackColor = true;
            this.classgpa.Click += new System.EventHandler(this.classgpa_Click);
            // 
            // coursescore
            // 
            this.coursescore.Location = new System.Drawing.Point(32, 340);
            this.coursescore.Name = "coursescore";
            this.coursescore.Size = new System.Drawing.Size(140, 66);
            this.coursescore.TabIndex = 6;
            this.coursescore.Text = "COURSE";
            this.coursescore.UseVisualStyleBackColor = true;
            this.coursescore.Click += new System.EventHandler(this.coursescore_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(289, 447);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(140, 20);
            this.id.TabIndex = 12;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(76, 447);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 20);
            this.name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 368);
            this.dataGridView1.TabIndex = 13;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(612, 428);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 16;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // QueryAverageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 518);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coursescore);
            this.Controls.Add(this.classgpa);
            this.Controls.Add(this.overallscore);
            this.Controls.Add(this.individual);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 557);
            this.MinimumSize = new System.Drawing.Size(810, 557);
            this.Name = "QueryAverageScore";
            this.Text = "QueryAverageScore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button individual;
        private System.Windows.Forms.Button overallscore;
        private System.Windows.Forms.Button classgpa;
        private System.Windows.Forms.Button coursescore;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
    }
}