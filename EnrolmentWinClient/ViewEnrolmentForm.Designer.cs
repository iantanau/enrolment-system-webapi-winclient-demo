namespace EnrolmentWinClient
{
    partial class ViewEnrolmentForm
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
            courseCostLabel = new Label();
            courseNameLabel = new Label();
            courseComboBox = new ComboBox();
            retrieveStudentButton = new Button();
            studentListBox = new ListBox();
            SuspendLayout();
            // 
            // courseCostLabel
            // 
            courseCostLabel.AutoSize = true;
            courseCostLabel.Location = new Point(33, 142);
            courseCostLabel.Name = "courseCostLabel";
            courseCostLabel.Size = new Size(97, 20);
            courseCostLabel.TabIndex = 5;
            courseCostLabel.Text = "Course Cost";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(33, 93);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(107, 20);
            courseNameLabel.TabIndex = 4;
            courseNameLabel.Text = "Course Name";
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(33, 36);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(151, 28);
            courseComboBox.TabIndex = 3;
            // 
            // retrieveStudentButton
            // 
            retrieveStudentButton.Location = new Point(33, 344);
            retrieveStudentButton.Name = "retrieveStudentButton";
            retrieveStudentButton.Size = new Size(208, 29);
            retrieveStudentButton.TabIndex = 6;
            retrieveStudentButton.Text = "View Student Enrolled";
            retrieveStudentButton.UseVisualStyleBackColor = true;
            retrieveStudentButton.Click += retrieveStudentButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.Location = new Point(269, 19);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(409, 404);
            studentListBox.TabIndex = 7;
            // 
            // ViewEnrolmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(studentListBox);
            Controls.Add(retrieveStudentButton);
            Controls.Add(courseCostLabel);
            Controls.Add(courseNameLabel);
            Controls.Add(courseComboBox);
            Name = "ViewEnrolmentForm";
            Text = "Enrolment Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courseCostLabel;
        private Label courseNameLabel;
        private ComboBox courseComboBox;
        private Button retrieveStudentButton;
        private ListBox studentListBox;
    }
}