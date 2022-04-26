namespace test
{
    partial class AdminInterface
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
            System.Windows.Forms.Label IDLabel;
            System.Windows.Forms.Label label1;
            this.studentinfo = new System.Windows.Forms.Button();
            this.teacherinfo = new System.Windows.Forms.Button();
            this.courseinfo = new System.Windows.Forms.Button();
            this.masterDataSet = new test.masterDataSet();
            this.adminAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminAuthorityTableAdapter = new test.masterDataSetTableAdapters.AdminAuthorityTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.choosecourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.avgscore = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new System.Drawing.Point(340, 54);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new System.Drawing.Size(21, 13);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(152, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // studentinfo
            // 
            this.studentinfo.Location = new System.Drawing.Point(46, 98);
            this.studentinfo.Name = "studentinfo";
            this.studentinfo.Size = new System.Drawing.Size(140, 66);
            this.studentinfo.TabIndex = 2;
            this.studentinfo.Text = "QUERY STUDENT PERSONAL INFO";
            this.studentinfo.UseVisualStyleBackColor = true;
            this.studentinfo.Click += new System.EventHandler(this.studentinfo_Click);
            // 
            // teacherinfo
            // 
            this.teacherinfo.Location = new System.Drawing.Point(243, 98);
            this.teacherinfo.Name = "teacherinfo";
            this.teacherinfo.Size = new System.Drawing.Size(140, 66);
            this.teacherinfo.TabIndex = 3;
            this.teacherinfo.Text = "QUERY TEACHER PERSONAL INFO";
            this.teacherinfo.UseVisualStyleBackColor = true;
            this.teacherinfo.Click += new System.EventHandler(this.teacherinfo_Click);
            // 
            // courseinfo
            // 
            this.courseinfo.Location = new System.Drawing.Point(442, 98);
            this.courseinfo.Name = "courseinfo";
            this.courseinfo.Size = new System.Drawing.Size(140, 66);
            this.courseinfo.TabIndex = 4;
            this.courseinfo.Text = "QUERY COURSE INFO";
            this.courseinfo.UseVisualStyleBackColor = true;
            this.courseinfo.Click += new System.EventHandler(this.courseinfo_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminAuthorityBindingSource
            // 
            this.adminAuthorityBindingSource.DataMember = "AdminAuthority";
            this.adminAuthorityBindingSource.DataSource = this.masterDataSet;
            // 
            // adminAuthorityTableAdapter
            // 
            this.adminAuthorityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = this.adminAuthorityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = null;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminAuthorityBindingSource, "AdminID", true));
            this.id.Location = new System.Drawing.Point(367, 51);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 6;
            // 
            // name
            // 
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminAuthorityBindingSource, "AdminID", true));
            this.name.Location = new System.Drawing.Point(196, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 8;
            // 
            // choosecourse
            // 
            this.choosecourse.Location = new System.Drawing.Point(838, 199);
            this.choosecourse.Name = "choosecourse";
            this.choosecourse.Size = new System.Drawing.Size(140, 66);
            this.choosecourse.TabIndex = 9;
            this.choosecourse.Text = "QUERY COURSE CHOOSING/SCORE";
            this.choosecourse.UseVisualStyleBackColor = true;
            this.choosecourse.Click += new System.EventHandler(this.choosecourse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 278);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // avgscore
            // 
            this.avgscore.Location = new System.Drawing.Point(1027, 199);
            this.avgscore.Name = "avgscore";
            this.avgscore.Size = new System.Drawing.Size(140, 66);
            this.avgscore.TabIndex = 11;
            this.avgscore.Text = "QUERY AVERAGE SCORE";
            this.avgscore.UseVisualStyleBackColor = true;
            this.avgscore.Click += new System.EventHandler(this.avgscore_Click);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(838, 308);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(140, 63);
            this.modify.TabIndex = 12;
            this.modify.Text = "MODIFY";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1027, 308);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 63);
            this.delete.TabIndex = 13;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(838, 414);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(140, 63);
            this.add.TabIndex = 14;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1027, 414);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 15;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 522);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.avgscore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choosecourse);
            this.Controls.Add(label1);
            this.Controls.Add(this.name);
            this.Controls.Add(IDLabel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.courseinfo);
            this.Controls.Add(this.teacherinfo);
            this.Controls.Add(this.studentinfo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1231, 561);
            this.MinimumSize = new System.Drawing.Size(1231, 561);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentinfo;
        private System.Windows.Forms.Button teacherinfo;
        private System.Windows.Forms.Button courseinfo;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource adminAuthorityBindingSource;
        private masterDataSetTableAdapters.AdminAuthorityTableAdapter adminAuthorityTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button choosecourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button avgscore;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button exit;
    }
}