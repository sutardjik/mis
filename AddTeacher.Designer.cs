namespace test
{
    partial class AddTeacher
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
            System.Windows.Forms.Label teacherIDLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label teachCourseLabel;
            this.masterDataSet = new test.masterDataSet();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInfoTableAdapter = new test.masterDataSetTableAdapters.TeacherInfoTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.teacherIDTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teachCourseTextBox = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            teacherIDLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            teachCourseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherIDLabel
            // 
            teacherIDLabel.AutoSize = true;
            teacherIDLabel.Location = new System.Drawing.Point(100, 27);
            teacherIDLabel.Name = "teacherIDLabel";
            teacherIDLabel.Size = new System.Drawing.Size(64, 13);
            teacherIDLabel.TabIndex = 1;
            teacherIDLabel.Text = "Teacher ID:";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(82, 53);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 3;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // teachCourseLabel
            // 
            teachCourseLabel.AutoSize = true;
            teachCourseLabel.Location = new System.Drawing.Point(87, 79);
            teachCourseLabel.Name = "teachCourseLabel";
            teachCourseLabel.Size = new System.Drawing.Size(77, 13);
            teachCourseLabel.TabIndex = 5;
            teachCourseLabel.Text = "Teach Course:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = null;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = this.teacherInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacherIDTextBox
            // 
            this.teacherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "TeacherID", true));
            this.teacherIDTextBox.Location = new System.Drawing.Point(169, 24);
            this.teacherIDTextBox.Name = "teacherIDTextBox";
            this.teacherIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherIDTextBox.TabIndex = 2;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "TeacherName", true));
            this.teacherNameTextBox.Location = new System.Drawing.Point(169, 50);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameTextBox.TabIndex = 4;
            // 
            // teachCourseTextBox
            // 
            this.teachCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "TeachCourse", true));
            this.teachCourseTextBox.Location = new System.Drawing.Point(169, 76);
            this.teachCourseTextBox.Name = "teachCourseTextBox";
            this.teachCourseTextBox.Size = new System.Drawing.Size(100, 20);
            this.teachCourseTextBox.TabIndex = 6;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(194, 125);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 30;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(24, 122);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 66);
            this.save.TabIndex = 42;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 213);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(teacherIDLabel);
            this.Controls.Add(this.teacherIDTextBox);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(teachCourseLabel);
            this.Controls.Add(this.teachCourseTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 252);
            this.MinimumSize = new System.Drawing.Size(376, 252);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private masterDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox teacherIDTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teachCourseTextBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
    }
}