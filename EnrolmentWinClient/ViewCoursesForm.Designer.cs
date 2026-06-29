namespace EnrolmentWinClient
{
    partial class ViewCoursesForm
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
            showCoursesButton = new Button();
            courseListBox = new ListBox();
            SuspendLayout();
            // 
            // showCoursesButton
            // 
            showCoursesButton.Location = new Point(176, 397);
            showCoursesButton.Name = "showCoursesButton";
            showCoursesButton.Size = new Size(162, 29);
            showCoursesButton.TabIndex = 4;
            showCoursesButton.Text = "Show All Courses";
            showCoursesButton.UseVisualStyleBackColor = true;
            showCoursesButton.Click += showCoursesButton_Click;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.Location = new Point(12, 12);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(509, 364);
            courseListBox.TabIndex = 3;
            // 
            // ViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(showCoursesButton);
            Controls.Add(courseListBox);
            Name = "ViewCoursesForm";
            Text = "View Courses";
            ResumeLayout(false);
        }

        #endregion
        private Button showCoursesButton;
        private ListBox courseListBox;
    }
}