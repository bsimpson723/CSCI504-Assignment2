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
            this.Title = new System.Windows.Forms.Label();
            this.studnetList = new System.Windows.Forms.ListBox();
            this.courseList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(308, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "NIU Enrollment Management System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studnetList
            // 
            this.studnetList.FormattingEnabled = true;
            this.studnetList.Location = new System.Drawing.Point(575, 59);
            this.studnetList.Name = "studnetList";
            this.studnetList.Size = new System.Drawing.Size(192, 433);
            this.studnetList.TabIndex = 1;
            // 
            // courseList
            // 
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(782, 59);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(192, 433);
            this.courseList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 656);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.studnetList);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox studnetList;
        private System.Windows.Forms.ListBox courseList;
    }
}

