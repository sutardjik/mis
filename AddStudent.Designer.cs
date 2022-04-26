namespace test
{
    partial class AddStudent
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
            System.Windows.Forms.Label stuIDLabel;
            System.Windows.Forms.Label stuNameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label entAgeLabel;
            System.Windows.Forms.Label entYearLabel;
            System.Windows.Forms.Label stuGradeLabel;
            System.Windows.Forms.Label classLabel;
            this.masterDataSet = new test.masterDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new test.masterDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new test.masterDataSetTableAdapters.TableAdapterManager();
            this.stuIDTextBox = new System.Windows.Forms.TextBox();
            this.stuNameTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entage = new System.Windows.Forms.ComboBox();
            this.entyear = new System.Windows.Forms.ComboBox();
            this.stugrade = new System.Windows.Forms.ComboBox();
            this.stuclass = new System.Windows.Forms.ComboBox();
            stuIDLabel = new System.Windows.Forms.Label();
            stuNameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            entAgeLabel = new System.Windows.Forms.Label();
            entYearLabel = new System.Windows.Forms.Label();
            stuGradeLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuIDLabel
            // 
            stuIDLabel.AutoSize = true;
            stuIDLabel.Location = new System.Drawing.Point(98, 27);
            stuIDLabel.Name = "stuIDLabel";
            stuIDLabel.Size = new System.Drawing.Size(40, 13);
            stuIDLabel.TabIndex = 1;
            stuIDLabel.Text = "Stu ID:";
            stuIDLabel.Click += new System.EventHandler(this.stuIDLabel_Click);
            // 
            // stuNameLabel
            // 
            stuNameLabel.AutoSize = true;
            stuNameLabel.Location = new System.Drawing.Point(81, 53);
            stuNameLabel.Name = "stuNameLabel";
            stuNameLabel.Size = new System.Drawing.Size(57, 13);
            stuNameLabel.TabIndex = 3;
            stuNameLabel.Text = "Stu Name:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(110, 79);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 5;
            sexLabel.Text = "Sex:";
            // 
            // entAgeLabel
            // 
            entAgeLabel.AutoSize = true;
            entAgeLabel.Location = new System.Drawing.Point(91, 106);
            entAgeLabel.Name = "entAgeLabel";
            entAgeLabel.Size = new System.Drawing.Size(48, 13);
            entAgeLabel.TabIndex = 7;
            entAgeLabel.Text = "Ent Age:";
            // 
            // entYearLabel
            // 
            entYearLabel.AutoSize = true;
            entYearLabel.Location = new System.Drawing.Point(87, 131);
            entYearLabel.Name = "entYearLabel";
            entYearLabel.Size = new System.Drawing.Size(51, 13);
            entYearLabel.TabIndex = 9;
            entYearLabel.Text = "Ent Year:";
            // 
            // stuGradeLabel
            // 
            stuGradeLabel.AutoSize = true;
            stuGradeLabel.Location = new System.Drawing.Point(81, 157);
            stuGradeLabel.Name = "stuGradeLabel";
            stuGradeLabel.Size = new System.Drawing.Size(58, 13);
            stuGradeLabel.TabIndex = 11;
            stuGradeLabel.Text = "Stu Grade:";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(103, 185);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(35, 13);
            classLabel.TabIndex = 13;
            classLabel.Text = "Class:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminAuthorityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChooseCourseTableAdapter = null;
            this.tableAdapterManager.CourseInfoTableAdapter = null;
            this.tableAdapterManager.StudentAuthorityTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.TeacherAuthorityTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stuIDTextBox
            // 
            this.stuIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StuID", true));
            this.stuIDTextBox.Location = new System.Drawing.Point(145, 24);
            this.stuIDTextBox.Name = "stuIDTextBox";
            this.stuIDTextBox.Size = new System.Drawing.Size(118, 20);
            this.stuIDTextBox.TabIndex = 2;
            // 
            // stuNameTextBox
            // 
            this.stuNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StuName", true));
            this.stuNameTextBox.Location = new System.Drawing.Point(145, 50);
            this.stuNameTextBox.Name = "stuNameTextBox";
            this.stuNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.stuNameTextBox.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(29, 232);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 66);
            this.save.TabIndex = 44;
            this.save.Text = "CONFIRM";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(198, 235);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 63);
            this.exit.TabIndex = 43;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(145, 76);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(118, 21);
            this.sex.TabIndex = 45;
            // 
            // studentInfoBindingSource1
            // 
            this.studentInfoBindingSource1.DataMember = "StudentInfo";
            this.studentInfoBindingSource1.DataSource = this.masterDataSet;
            // 
            // entage
            // 
            this.entage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entage.FormattingEnabled = true;
            this.entage.Items.AddRange(new object[] {
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
            this.entage.Location = new System.Drawing.Point(145, 103);
            this.entage.Name = "entage";
            this.entage.Size = new System.Drawing.Size(118, 21);
            this.entage.TabIndex = 46;
            // 
            // entyear
            // 
            this.entyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entyear.FormattingEnabled = true;
            this.entyear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.entyear.Location = new System.Drawing.Point(145, 128);
            this.entyear.Name = "entyear";
            this.entyear.Size = new System.Drawing.Size(118, 21);
            this.entyear.TabIndex = 47;
            // 
            // stugrade
            // 
            this.stugrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stugrade.FormattingEnabled = true;
            this.stugrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.stugrade.Location = new System.Drawing.Point(145, 155);
            this.stugrade.Name = "stugrade";
            this.stugrade.Size = new System.Drawing.Size(118, 21);
            this.stugrade.TabIndex = 48;
            // 
            // stuclass
            // 
            this.stuclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuclass.FormattingEnabled = true;
            this.stuclass.Items.AddRange(new object[] {
            "International",
            "Excellent Engineer",
            "Innovation"});
            this.stuclass.Location = new System.Drawing.Point(145, 182);
            this.stuclass.Name = "stuclass";
            this.stuclass.Size = new System.Drawing.Size(118, 21);
            this.stuclass.TabIndex = 49;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 323);
            this.Controls.Add(this.stuclass);
            this.Controls.Add(this.stugrade);
            this.Controls.Add(this.entyear);
            this.Controls.Add(this.entage);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(stuIDLabel);
            this.Controls.Add(this.stuIDTextBox);
            this.Controls.Add(stuNameLabel);
            this.Controls.Add(this.stuNameTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(entAgeLabel);
            this.Controls.Add(entYearLabel);
            this.Controls.Add(stuGradeLabel);
            this.Controls.Add(classLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 362);
            this.MinimumSize = new System.Drawing.Size(388, 362);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private masterDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stuIDTextBox;
        private System.Windows.Forms.TextBox stuNameTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        private System.Windows.Forms.ComboBox entage;
        private System.Windows.Forms.ComboBox entyear;
        private System.Windows.Forms.ComboBox stugrade;
        private System.Windows.Forms.ComboBox stuclass;
    }
}