namespace EnrolmentWinClient
{
    partial class AddEnrolmentForm
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
            courseGroupBox = new GroupBox();
            courseCostLabel = new Label();
            courseNameLabel = new Label();
            courseComboBox = new ComboBox();
            studentGroupBox = new GroupBox();
            enrolledDateLabel = new Label();
            studentComboBox = new ComboBox();
            studentNameLabel = new Label();
            addEnrolmentButton = new Button();
            courseGroupBox.SuspendLayout();
            studentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // courseGroupBox
            // 
            courseGroupBox.Controls.Add(courseCostLabel);
            courseGroupBox.Controls.Add(courseNameLabel);
            courseGroupBox.Controls.Add(courseComboBox);
            courseGroupBox.Location = new Point(25, 47);
            courseGroupBox.Name = "courseGroupBox";
            courseGroupBox.Size = new Size(344, 282);
            courseGroupBox.TabIndex = 0;
            courseGroupBox.TabStop = false;
            courseGroupBox.Text = "Course";
            // 
            // courseCostLabel
            // 
            courseCostLabel.AutoSize = true;
            courseCostLabel.Location = new Point(28, 198);
            courseCostLabel.Name = "courseCostLabel";
            courseCostLabel.Size = new Size(97, 20);
            courseCostLabel.TabIndex = 2;
            courseCostLabel.Text = "Course Cost";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(28, 123);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(107, 20);
            courseNameLabel.TabIndex = 1;
            courseNameLabel.Text = "Course Name";
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(28, 43);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(154, 28);
            courseComboBox.TabIndex = 0;
            // 
            // studentGroupBox
            // 
            studentGroupBox.Controls.Add(enrolledDateLabel);
            studentGroupBox.Controls.Add(studentComboBox);
            studentGroupBox.Controls.Add(studentNameLabel);
            studentGroupBox.Location = new Point(385, 47);
            studentGroupBox.Name = "studentGroupBox";
            studentGroupBox.Size = new Size(344, 282);
            studentGroupBox.TabIndex = 1;
            studentGroupBox.TabStop = false;
            studentGroupBox.Text = "Student";
            // 
            // enrolledDateLabel
            // 
            enrolledDateLabel.AutoSize = true;
            enrolledDateLabel.Location = new Point(38, 198);
            enrolledDateLabel.Name = "enrolledDateLabel";
            enrolledDateLabel.Size = new Size(107, 20);
            enrolledDateLabel.TabIndex = 5;
            enrolledDateLabel.Text = "Date Enrolled";
            // 
            // studentComboBox
            // 
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(38, 43);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(151, 28);
            studentComboBox.TabIndex = 3;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(38, 123);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(114, 20);
            studentNameLabel.TabIndex = 4;
            studentNameLabel.Text = "Student Name";
            // 
            // addEnrolmentButton
            // 
            addEnrolmentButton.Location = new Point(312, 377);
            addEnrolmentButton.Name = "addEnrolmentButton";
            addEnrolmentButton.Size = new Size(130, 29);
            addEnrolmentButton.TabIndex = 16;
            addEnrolmentButton.Text = "Enroll Student";
            addEnrolmentButton.UseVisualStyleBackColor = true;
            addEnrolmentButton.Click += addEnrolmentButton_Click;
            // 
            // AddEnrolmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(studentGroupBox);
            Controls.Add(addEnrolmentButton);
            Controls.Add(courseGroupBox);
            Name = "AddEnrolmentForm";
            Text = "Enrolment Form";
            courseGroupBox.ResumeLayout(false);
            courseGroupBox.PerformLayout();
            studentGroupBox.ResumeLayout(false);
            studentGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox courseGroupBox;
        private ComboBox courseComboBox;
        private GroupBox studentGroupBox;
        private Label courseNameLabel;
        private Label courseCostLabel;
        private Label enrolledDateLabel;
        private ComboBox studentComboBox;
        private Label studentNameLabel;
        private Button addEnrolmentButton;
    }
}