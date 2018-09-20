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
            this.Title_Label = new System.Windows.Forms.Label();
            this.Student_ListBox = new System.Windows.Forms.ListBox();
            this.Course_ListBox = new System.Windows.Forms.ListBox();
            this.PrintRoster_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Drop_Button = new System.Windows.Forms.Button();
            this.Enroll_Button = new System.Windows.Forms.Button();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(295, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(406, 26);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "NIU Enrollment Management System";
            // 
            // Student_ListBox
            // 
            this.Student_ListBox.FormattingEnabled = true;
            this.Student_ListBox.Location = new System.Drawing.Point(619, 57);
            this.Student_ListBox.Name = "Student_ListBox";
            this.Student_ListBox.Size = new System.Drawing.Size(156, 394);
            this.Student_ListBox.TabIndex = 1;
            // 
            // Course_ListBox
            // 
            this.Course_ListBox.FormattingEnabled = true;
            this.Course_ListBox.Location = new System.Drawing.Point(801, 57);
            this.Course_ListBox.Name = "Course_ListBox";
            this.Course_ListBox.Size = new System.Drawing.Size(156, 394);
            this.Course_ListBox.TabIndex = 2;
            // 
            // PrintRoster_Button
            // 
            this.PrintRoster_Button.Location = new System.Drawing.Point(37, 57);
            this.PrintRoster_Button.Name = "PrintRoster_Button";
            this.PrintRoster_Button.Size = new System.Drawing.Size(120, 27);
            this.PrintRoster_Button.TabIndex = 3;
            this.PrintRoster_Button.Text = "Print Course Roster";
            this.PrintRoster_Button.UseVisualStyleBackColor = true;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(37, 156);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(120, 27);
            this.Search_Button.TabIndex = 4;
            this.Search_Button.Text = "Apply Search Criteria";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // Drop_Button
            // 
            this.Drop_Button.Location = new System.Drawing.Point(37, 123);
            this.Drop_Button.Name = "Drop_Button";
            this.Drop_Button.Size = new System.Drawing.Size(120, 27);
            this.Drop_Button.TabIndex = 5;
            this.Drop_Button.Text = "Drop Student";
            this.Drop_Button.UseVisualStyleBackColor = true;
            // 
            // Enroll_Button
            // 
            this.Enroll_Button.Location = new System.Drawing.Point(37, 90);
            this.Enroll_Button.Name = "Enroll_Button";
            this.Enroll_Button.Size = new System.Drawing.Size(120, 27);
            this.Enroll_Button.TabIndex = 6;
            this.Enroll_Button.Text = "Enroll Student";
            this.Enroll_Button.UseVisualStyleBackColor = true;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Location = new System.Drawing.Point(12, 457);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.ReadOnly = true;
            this.Output_TextBox.Size = new System.Drawing.Size(945, 156);
            this.Output_TextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 625);
            this.Controls.Add(this.Output_TextBox);
            this.Controls.Add(this.Enroll_Button);
            this.Controls.Add(this.Drop_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.PrintRoster_Button);
            this.Controls.Add(this.Course_ListBox);
            this.Controls.Add(this.Student_ListBox);
            this.Controls.Add(this.Title_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.ListBox Student_ListBox;
        private System.Windows.Forms.ListBox Course_ListBox;
        private System.Windows.Forms.Button PrintRoster_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Drop_Button;
        private System.Windows.Forms.Button Enroll_Button;
        private System.Windows.Forms.TextBox Output_TextBox;
    }
}

