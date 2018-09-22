namespace Assignment2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title_Lable = new System.Windows.Forms.Label();
            this.Student_ListBox = new System.Windows.Forms.ListBox();
            this.Course_ListBox = new System.Windows.Forms.ListBox();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.PrintRoster_Button = new System.Windows.Forms.Button();
            this.EnrollStudent_Button = new System.Windows.Forms.Button();
            this.DropStudent_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.AddName_Label = new System.Windows.Forms.Label();
            this.AddName_TextBox = new System.Windows.Forms.TextBox();
            this.AddZid_TextBox = new System.Windows.Forms.TextBox();
            this.AddZid_Label = new System.Windows.Forms.Label();
            this.AddYear_Label = new System.Windows.Forms.Label();
            this.AddMajor_Label = new System.Windows.Forms.Label();
            this.AddMajor_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddYear_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.AddCapacity_label = new System.Windows.Forms.Label();
            this.AddSection_Label = new System.Windows.Forms.Label();
            this.AddCourse_TextBox = new System.Windows.Forms.TextBox();
            this.AddCourse_Label = new System.Windows.Forms.Label();
            this.AddSection_TextBox = new System.Windows.Forms.TextBox();
            this.AddDept_Label = new System.Windows.Forms.Label();
            this.AddDept_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddCourse_Button = new System.Windows.Forms.Button();
            this.AddCapacity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AddCapacity_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Lable
            // 
            this.Title_Lable.AutoSize = true;
            this.Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lable.Location = new System.Drawing.Point(291, 9);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(406, 26);
            this.Title_Lable.TabIndex = 0;
            this.Title_Lable.Text = "NIU Enrollment Management System";
            this.Title_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_ListBox
            // 
            this.Student_ListBox.DisplayMember = "StudentInfo";
            this.Student_ListBox.FormattingEnabled = true;
            this.Student_ListBox.Location = new System.Drawing.Point(565, 59);
            this.Student_ListBox.Name = "Student_ListBox";
            this.Student_ListBox.Size = new System.Drawing.Size(192, 433);
            this.Student_ListBox.TabIndex = 1;
            this.Student_ListBox.DataSource = Program.m_students;
            this.Student_ListBox.DisplayMember = "StudentInfo";
            this.Student_ListBox.SelectedIndexChanged += new System.EventHandler(this.StudentSelected);
            // 
            // Course_ListBox
            // 
            this.Course_ListBox.FormattingEnabled = true;
            this.Course_ListBox.Location = new System.Drawing.Point(772, 59);
            this.Course_ListBox.Name = "Course_ListBox";
            this.Course_ListBox.Size = new System.Drawing.Size(192, 433);
            this.Course_ListBox.TabIndex = 2;
            this.Course_ListBox.DataSource = Program.m_courses;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Location = new System.Drawing.Point(45, 512);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_TextBox.Size = new System.Drawing.Size(919, 132);
            this.Output_TextBox.TabIndex = 3;
            // 
            // PrintRoster_Button
            // 
            this.PrintRoster_Button.Location = new System.Drawing.Point(45, 59);
            this.PrintRoster_Button.Name = "PrintRoster_Button";
            this.PrintRoster_Button.Size = new System.Drawing.Size(126, 31);
            this.PrintRoster_Button.TabIndex = 4;
            this.PrintRoster_Button.Text = "Print Course Roster";
            this.PrintRoster_Button.UseVisualStyleBackColor = true;
            this.PrintRoster_Button.Click += new System.EventHandler(this.PrintCourseClicked);
            // 
            // EnrollStudent_Button
            // 
            this.EnrollStudent_Button.Location = new System.Drawing.Point(45, 96);
            this.EnrollStudent_Button.Name = "EnrollStudent_Button";
            this.EnrollStudent_Button.Size = new System.Drawing.Size(126, 31);
            this.EnrollStudent_Button.TabIndex = 5;
            this.EnrollStudent_Button.Text = "Enroll Student";
            this.EnrollStudent_Button.UseVisualStyleBackColor = true;
            this.EnrollStudent_Button.Click += new System.EventHandler(this.EnrollStudent_Button_Click);
            // 
            // DropStudent_Button
            // 
            this.DropStudent_Button.Location = new System.Drawing.Point(45, 133);
            this.DropStudent_Button.Name = "DropStudent_Button";
            this.DropStudent_Button.Size = new System.Drawing.Size(126, 31);
            this.DropStudent_Button.TabIndex = 6;
            this.DropStudent_Button.Text = "Drop Student";
            this.DropStudent_Button.UseVisualStyleBackColor = true;
            this.DropStudent_Button.Click += new System.EventHandler(this.DropStudent_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(45, 170);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(126, 31);
            this.Search_Button.TabIndex = 7;
            this.Search_Button.Text = "Apply Search Criteria";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // AddName_Label
            // 
            this.AddName_Label.AutoSize = true;
            this.AddName_Label.Location = new System.Drawing.Point(42, 232);
            this.AddName_Label.Name = "AddName_Label";
            this.AddName_Label.Size = new System.Drawing.Size(114, 13);
            this.AddName_Label.TabIndex = 8;
            this.AddName_Label.Text = "Last Name, First Name";
            // 
            // AddName_TextBox
            // 
            this.AddName_TextBox.Location = new System.Drawing.Point(45, 248);
            this.AddName_TextBox.Name = "AddName_TextBox";
            this.AddName_TextBox.Size = new System.Drawing.Size(126, 20);
            this.AddName_TextBox.TabIndex = 9;
            // 
            // AddZid_TextBox
            // 
            this.AddZid_TextBox.Location = new System.Drawing.Point(182, 248);
            this.AddZid_TextBox.Name = "AddZid_TextBox";
            this.AddZid_TextBox.Size = new System.Drawing.Size(126, 20);
            this.AddZid_TextBox.TabIndex = 11;
            // 
            // AddZid_Label
            // 
            this.AddZid_Label.AutoSize = true;
            this.AddZid_Label.Location = new System.Drawing.Point(179, 232);
            this.AddZid_Label.Name = "AddZid_Label";
            this.AddZid_Label.Size = new System.Drawing.Size(28, 13);
            this.AddZid_Label.TabIndex = 10;
            this.AddZid_Label.Text = "Z-ID";
            // 
            // AddYear_Label
            // 
            this.AddYear_Label.AutoSize = true;
            this.AddYear_Label.Location = new System.Drawing.Point(179, 272);
            this.AddYear_Label.Name = "AddYear_Label";
            this.AddYear_Label.Size = new System.Drawing.Size(79, 13);
            this.AddYear_Label.TabIndex = 13;
            this.AddYear_Label.Text = "Academic Year";
            // 
            // AddMajor_Label
            // 
            this.AddMajor_Label.AutoSize = true;
            this.AddMajor_Label.Location = new System.Drawing.Point(42, 272);
            this.AddMajor_Label.Name = "AddMajor_Label";
            this.AddMajor_Label.Size = new System.Drawing.Size(33, 13);
            this.AddMajor_Label.TabIndex = 12;
            this.AddMajor_Label.Text = "Major";
            // 
            // AddMajor_ComboBox
            // 
            this.AddMajor_ComboBox.AllowDrop = true;
            this.AddMajor_ComboBox.FormattingEnabled = true;
            this.AddMajor_ComboBox.Location = new System.Drawing.Point(45, 288);
            this.AddMajor_ComboBox.Name = "AddMajor_ComboBox";
            this.AddMajor_ComboBox.Size = new System.Drawing.Size(126, 21);
            this.AddMajor_ComboBox.TabIndex = 14;
            this.AddMajor_ComboBox.SelectedIndex = -1;
            this.AddMajor_ComboBox.Text = "Select Major";
            // 
            // AddYear_ComboBox
            // 
            this.AddYear_ComboBox.FormattingEnabled = true;
            this.AddYear_ComboBox.Location = new System.Drawing.Point(182, 288);
            this.AddYear_ComboBox.Name = "AddYear_ComboBox";
            this.AddYear_ComboBox.Size = new System.Drawing.Size(126, 21);
            this.AddYear_ComboBox.TabIndex = 15;
            this.AddYear_ComboBox.SelectedIndex = -1;
            this.AddYear_ComboBox.Text = "Select Academic Year";
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.Location = new System.Drawing.Point(45, 315);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Size = new System.Drawing.Size(98, 24);
            this.AddStudent_Button.TabIndex = 16;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.UseVisualStyleBackColor = true;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // AddCapacity_label
            // 
            this.AddCapacity_label.AutoSize = true;
            this.AddCapacity_label.Location = new System.Drawing.Point(179, 411);
            this.AddCapacity_label.Name = "AddCapacity_label";
            this.AddCapacity_label.Size = new System.Drawing.Size(48, 13);
            this.AddCapacity_label.TabIndex = 22;
            this.AddCapacity_label.Text = "Capacity";
            // 
            // AddSection_Label
            // 
            this.AddSection_Label.AutoSize = true;
            this.AddSection_Label.Location = new System.Drawing.Point(42, 411);
            this.AddSection_Label.Name = "AddSection_Label";
            this.AddSection_Label.Size = new System.Drawing.Size(83, 13);
            this.AddSection_Label.TabIndex = 21;
            this.AddSection_Label.Text = "Section Number";
            // 
            // AddCourse_TextBox
            // 
            this.AddCourse_TextBox.Location = new System.Drawing.Point(182, 387);
            this.AddCourse_TextBox.Name = "AddCourse_TextBox";
            this.AddCourse_TextBox.Size = new System.Drawing.Size(126, 20);
            this.AddCourse_TextBox.TabIndex = 20;
            // 
            // AddCourse_Label
            // 
            this.AddCourse_Label.AutoSize = true;
            this.AddCourse_Label.Location = new System.Drawing.Point(179, 371);
            this.AddCourse_Label.Name = "AddCourse_Label";
            this.AddCourse_Label.Size = new System.Drawing.Size(80, 13);
            this.AddCourse_Label.TabIndex = 19;
            this.AddCourse_Label.Text = "Course Number";
            // 
            // AddSection_TextBox
            // 
            this.AddSection_TextBox.Location = new System.Drawing.Point(45, 427);
            this.AddSection_TextBox.Name = "AddSection_TextBox";
            this.AddSection_TextBox.Size = new System.Drawing.Size(126, 20);
            this.AddSection_TextBox.TabIndex = 18;
            // 
            // AddDept_Label
            // 
            this.AddDept_Label.AutoSize = true;
            this.AddDept_Label.Location = new System.Drawing.Point(42, 371);
            this.AddDept_Label.Name = "AddDept_Label";
            this.AddDept_Label.Size = new System.Drawing.Size(90, 13);
            this.AddDept_Label.TabIndex = 17;
            this.AddDept_Label.Text = "Department Code";
            // 
            // AddDept_ComboBox
            // 
            this.AddDept_ComboBox.FormattingEnabled = true;
            this.AddDept_ComboBox.Location = new System.Drawing.Point(45, 386);
            this.AddDept_ComboBox.Name = "AddDept_ComboBox";
            this.AddDept_ComboBox.Size = new System.Drawing.Size(126, 21);
            this.AddDept_ComboBox.TabIndex = 23;
            this.AddDept_ComboBox.Text = "Select Department";
            // 
            // AddCourse_Button
            // 
            this.AddCourse_Button.Location = new System.Drawing.Point(45, 453);
            this.AddCourse_Button.Name = "AddCourse_Button";
            this.AddCourse_Button.Size = new System.Drawing.Size(98, 24);
            this.AddCourse_Button.TabIndex = 25;
            this.AddCourse_Button.Text = "AddCourse";
            this.AddCourse_Button.UseVisualStyleBackColor = true;
            this.AddCourse_Button.Click += new System.EventHandler(this.AddCourse_Button_Click);
            // 
            // AddCapacity_NumericUpDown
            // 
            this.AddCapacity_NumericUpDown.Location = new System.Drawing.Point(182, 428);
            this.AddCapacity_NumericUpDown.Name = "AddCapacity_NumericUpDown";
            this.AddCapacity_NumericUpDown.Size = new System.Drawing.Size(126, 20);
            this.AddCapacity_NumericUpDown.TabIndex = 26;
            this.AddCapacity_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 656);
            this.Controls.Add(this.AddCapacity_NumericUpDown);
            this.Controls.Add(this.AddCourse_Button);
            this.Controls.Add(this.AddDept_ComboBox);
            this.Controls.Add(this.AddCapacity_label);
            this.Controls.Add(this.AddSection_Label);
            this.Controls.Add(this.AddCourse_TextBox);
            this.Controls.Add(this.AddCourse_Label);
            this.Controls.Add(this.AddSection_TextBox);
            this.Controls.Add(this.AddDept_Label);
            this.Controls.Add(this.AddStudent_Button);
            this.Controls.Add(this.AddYear_ComboBox);
            this.Controls.Add(this.AddMajor_ComboBox);
            this.Controls.Add(this.AddYear_Label);
            this.Controls.Add(this.AddMajor_Label);
            this.Controls.Add(this.AddZid_TextBox);
            this.Controls.Add(this.AddZid_Label);
            this.Controls.Add(this.AddName_TextBox);
            this.Controls.Add(this.AddName_Label);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.DropStudent_Button);
            this.Controls.Add(this.EnrollStudent_Button);
            this.Controls.Add(this.PrintRoster_Button);
            this.Controls.Add(this.Output_TextBox);
            this.Controls.Add(this.Course_ListBox);
            this.Controls.Add(this.Student_ListBox);
            this.Controls.Add(this.Title_Lable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AddCapacity_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Lable;
        private System.Windows.Forms.ListBox Student_ListBox;
        private System.Windows.Forms.ListBox Course_ListBox;
        private System.Windows.Forms.TextBox Output_TextBox;
        private System.Windows.Forms.Button PrintRoster_Button;
        private System.Windows.Forms.Button EnrollStudent_Button;
        private System.Windows.Forms.Button DropStudent_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label AddName_Label;
        private System.Windows.Forms.TextBox AddName_TextBox;
        private System.Windows.Forms.TextBox AddZid_TextBox;
        private System.Windows.Forms.Label AddZid_Label;
        private System.Windows.Forms.Label AddYear_Label;
        private System.Windows.Forms.Label AddMajor_Label;
        private System.Windows.Forms.ComboBox AddMajor_ComboBox;
        private System.Windows.Forms.ComboBox AddYear_ComboBox;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.Label AddCapacity_label;
        private System.Windows.Forms.Label AddSection_Label;
        private System.Windows.Forms.TextBox AddCourse_TextBox;
        private System.Windows.Forms.Label AddCourse_Label;
        private System.Windows.Forms.TextBox AddSection_TextBox;
        private System.Windows.Forms.Label AddDept_Label;
        private System.Windows.Forms.ComboBox AddDept_ComboBox;
        private System.Windows.Forms.Button AddCourse_Button;
        private System.Windows.Forms.NumericUpDown AddCapacity_NumericUpDown;
    }
}

