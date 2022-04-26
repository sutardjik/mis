namespace test
{
    partial class TeacherDisplayData
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
            this.choosecourse = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tidbox = new System.Windows.Forms.ComboBox();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new test.masterDataSet();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInfoTableAdapter = new test.masterDataSetTableAdapters.TeacherInfoTableAdapter();
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // choosecourse
            // 
            this.choosecourse.Location = new System.Drawing.Point(152, 417);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(140, 66);
            this.choosecourse.TabIndex = 28;
            this.choosecourse.Text = "QUERY COURSE CHOOSING";
            this.choosecourse.UseVisualStyleBackColor = true;
            this.choosecourse.Click += new System.EventHandler(this.choosecourse_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(332, 420);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 27;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Teacher ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 307);
            this.dataGridView1.TabIndex = 24;
            // 
            // tidbox
            // 
            this.tidbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chooseCourseBindingSource, "TeacherID", true));
            this.tidbox.DataSource = this.teacherInfoBindingSource;
            this.tidbox.DisplayMember = "TeacherID";
            this.tidbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tidbox.FormattingEnabled = true;
            this.tidbox.Location = new System.Drawing.Point(286, 31);
            this.tidbox.Name = "tidbox";
            this.tidbox.Size = new System.Drawing.Size(121, 21);
            this.tidbox.TabIndex = 29;
            this.tidbox.ValueMember = "TeacherID";
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
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // chooseCourseTableAdapter
            // 
            this.chooseCourseTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherDisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.tidbox);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 557);
            this.MinimumSize = new System.Drawing.Size(638, 557);
            this.Name = "TeacherDisplayData";
            this.Text = "TeacherDisplayData";
            this.Load += new System.EventHandler(this.TeacherDisplayData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosecourse;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tidbox;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private masterDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
    }
}