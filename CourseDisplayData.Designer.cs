namespace test
{
    partial class CourseDisplayData
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
            this.choosecourse = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.masterDataSet = new test.masterDataSet();
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInfoTableAdapter = new test.masterDataSetTableAdapters.CourseInfoTableAdapter();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            this.cid = new System.Windows.Forms.TextBox();
            this.courseInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chooseCourseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 307);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Course ID:";
            // 
            // choosecourse
            // 
            this.choosecourse.Location = new System.Drawing.Point(152, 418);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(140, 66);
            this.choosecourse.TabIndex = 30;
            this.choosecourse.Text = "QUERY COURSE CHOOSING";
            this.choosecourse.UseVisualStyleBackColor = true;
            this.choosecourse.Click += new System.EventHandler(this.choosecourse_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(332, 421);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 29;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInfoBindingSource
            // 
            this.courseInfoBindingSource.DataMember = "CourseInfo";
            this.courseInfoBindingSource.DataSource = this.masterDataSet;
            // 
            // courseInfoTableAdapter
            // 
            this.courseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // chooseCourseBindingSource
            // 
            this.chooseCourseBindingSource.DataMember = "ChooseCourse";
            this.chooseCourseBindingSource.DataSource = this.masterDataSet;
            // 
            // chooseCourseTableAdapter
            // 
            this.chooseCourseTableAdapter.ClearBeforeFill = true;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(289, 34);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(121, 20);
            this.cid.TabIndex = 32;
            // 
            // courseInfoBindingSource1
            // 
            this.courseInfoBindingSource1.DataMember = "CourseInfo";
            this.courseInfoBindingSource1.DataSource = this.masterDataSet;
            // 
            // chooseCourseBindingSource1
            // 
            this.chooseCourseBindingSource1.DataMember = "ChooseCourse";
            this.chooseCourseBindingSource1.DataSource = this.masterDataSet;
            // 
            // CourseDisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 557);
            this.MinimumSize = new System.Drawing.Size(638, 557);
            this.Name = "CourseDisplayData";
            this.Text = "CourseDisplayData";
            this.Load += new System.EventHandler(this.CourseDisplayData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choosecourse;
        private System.Windows.Forms.Button exit;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private masterDataSetTableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource1;
        private System.Windows.Forms.BindingSource courseInfoBindingSource1;
    }
}