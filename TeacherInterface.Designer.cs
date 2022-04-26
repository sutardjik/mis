namespace test
{
    partial class TeacherInterface
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
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.chooseCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseCourseTableAdapter = new test.masterDataSetTableAdapters.ChooseCourseTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personalinfo = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.avgscore = new System.Windows.Forms.Button();
            this.modifyscore = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // chooseCourseBindingSource
            // 
            this.chooseCourseBindingSource.DataMember = "ChooseCourse";
            this.chooseCourseBindingSource.DataSource = this.masterDataSet;
            // 
            // chooseCourseTableAdapter
            // 
            this.chooseCourseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = this.chooseCourseTableAdapter;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // personalinfo
            // 
            this.personalinfo.Location = new System.Drawing.Point(34, 48);
            this.personalinfo.Name = "personalinfo";
            this.personalinfo.Size = new System.Drawing.Size(140, 66);
            this.personalinfo.TabIndex = 2;
            this.personalinfo.Text = "QUERY PERSONAL INFO";
            this.personalinfo.UseVisualStyleBackColor = true;
            this.personalinfo.Click += new System.EventHandler(this.personalinfo_Click);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(34, 146);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(140, 63);
            this.score.TabIndex = 3;
            this.score.Text = "QUERY COURSE SCORE";
            this.score.UseVisualStyleBackColor = true;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // avgscore
            // 
            this.avgscore.Location = new System.Drawing.Point(34, 245);
            this.avgscore.Name = "avgscore";
            this.avgscore.Size = new System.Drawing.Size(140, 63);
            this.avgscore.TabIndex = 4;
            this.avgscore.Text = "QUERY AVERAGE SCORE";
            this.avgscore.UseVisualStyleBackColor = true;
            this.avgscore.Click += new System.EventHandler(this.avgscore_Click);
            // 
            // modifyscore
            // 
            this.modifyscore.Location = new System.Drawing.Point(34, 341);
            this.modifyscore.Name = "modifyscore";
            this.modifyscore.Size = new System.Drawing.Size(140, 63);
            this.modifyscore.TabIndex = 5;
            this.modifyscore.Text = "MODIFY SCORE";
            this.modifyscore.UseVisualStyleBackColor = true;
            this.modifyscore.Click += new System.EventHandler(this.modifyscore_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(750, 437);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 6;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TeacherInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.modifyscore);
            this.Controls.Add(this.avgscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.personalinfo);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 569);
            this.MinimumSize = new System.Drawing.Size(960, 569);
            this.Name = "TeacherInterface";
            this.Text = "TeacherInterface";
            this.Load += new System.EventHandler(this.TeacherInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.BindingSource chooseCourseBindingSource;
        private masterDataSetTableAdapters.ChooseCourseTableAdapter chooseCourseTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button personalinfo;
        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Button avgscore;
        private System.Windows.Forms.Button modifyscore;
        private System.Windows.Forms.Button exit;
    }
}