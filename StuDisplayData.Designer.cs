namespace test
{
    partial class StuDisplayData
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.choosecourse = new System.Windows.Forms.Button();
            this.sidbox = new System.Windows.Forms.ComboBox();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stu ID:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(334, 423);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 22;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // choosecourse
            // 
            this.choosecourse.Location = new System.Drawing.Point(154, 420);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(140, 66);
            this.choosecourse.TabIndex = 23;
            this.choosecourse.Text = "QUERY COURSE CHOOSING";
            this.choosecourse.UseVisualStyleBackColor = true;
            this.choosecourse.Click += new System.EventHandler(this.choosecourse_Click);
            // 
            // sidbox
            // 
            this.sidbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "StuID", true));
            this.sidbox.DataSource = this.studentInfoBindingSource;
            this.sidbox.DisplayMember = "StuID";
            this.sidbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sidbox.FormattingEnabled = true;
            this.sidbox.Location = new System.Drawing.Point(273, 31);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(121, 21);
            this.sidbox.TabIndex = 24;
            this.sidbox.ValueMember = "StuID";
            // 
            // chooseCourseBindingSource
            // 
            this.chooseCourseBindingSource.DataMember = "ChooseCourse";
            this.chooseCourseBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // chooseCourseTableAdapter
            // 
            this.chooseCourseTableAdapter.ClearBeforeFill = true;
            // 
            // StuDisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.sidbox);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 557);
            this.MinimumSize = new System.Drawing.Size(638, 557);
            this.Name = "StuDisplayData";
            this.Text = "StuDisplayData";
            this.Load += new System.EventHandler(this.DisplayData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button choosecourse;
        private System.Windows.Forms.ComboBox sidbox;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
    }
}