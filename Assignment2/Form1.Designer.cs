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
            this.Title_Lable = new System.Windows.Forms.Label();
            this.Student_ListBox = new System.Windows.Forms.ListBox();
            this.Course_ListBox = new System.Windows.Forms.ListBox();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.PrintRoster_Button = new System.Windows.Forms.Button();
            this.EnrollStudent_Button = new System.Windows.Forms.Button();
            this.DropStudent_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
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
            this.Student_ListBox.FormattingEnabled = true;
            this.Student_ListBox.Location = new System.Drawing.Point(575, 59);
            this.Student_ListBox.Name = "Student_ListBox";
            this.Student_ListBox.Size = new System.Drawing.Size(192, 433);
            this.Student_ListBox.TabIndex = 1;
            // 
            // Course_ListBox
            // 
            this.Course_ListBox.FormattingEnabled = true;
            this.Course_ListBox.Location = new System.Drawing.Point(782, 59);
            this.Course_ListBox.Name = "Course_ListBox";
            this.Course_ListBox.Size = new System.Drawing.Size(192, 433);
            this.Course_ListBox.TabIndex = 2;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Location = new System.Drawing.Point(12, 512);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.Size = new System.Drawing.Size(962, 132);
            this.Output_TextBox.TabIndex = 3;
            // 
            // PrintRoster_Button
            // 
            this.PrintRoster_Button.Location = new System.Drawing.Point(12, 59);
            this.PrintRoster_Button.Name = "PrintRoster_Button";
            this.PrintRoster_Button.Size = new System.Drawing.Size(126, 31);
            this.PrintRoster_Button.TabIndex = 4;
            this.PrintRoster_Button.Text = "Print Course Roster";
            this.PrintRoster_Button.UseVisualStyleBackColor = true;
            // 
            // EnrollStudent_Button
            // 
            this.EnrollStudent_Button.Location = new System.Drawing.Point(12, 96);
            this.EnrollStudent_Button.Name = "EnrollStudent_Button";
            this.EnrollStudent_Button.Size = new System.Drawing.Size(126, 31);
            this.EnrollStudent_Button.TabIndex = 5;
            this.EnrollStudent_Button.Text = "Enroll Student";
            this.EnrollStudent_Button.UseVisualStyleBackColor = true;
            // 
            // DropStudent_Button
            // 
            this.DropStudent_Button.Location = new System.Drawing.Point(12, 133);
            this.DropStudent_Button.Name = "DropStudent_Button";
            this.DropStudent_Button.Size = new System.Drawing.Size(126, 31);
            this.DropStudent_Button.TabIndex = 6;
            this.DropStudent_Button.Text = "Drop Student";
            this.DropStudent_Button.UseVisualStyleBackColor = true;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(12, 170);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(126, 31);
            this.Search_Button.TabIndex = 7;
            this.Search_Button.Text = "Apply Search Criteria";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 656);
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
    }
}

