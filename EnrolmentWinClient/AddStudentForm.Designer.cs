namespace EnrolmentWinClient
{
    partial class AddStudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentIdLabel = new Label();
            studentNameLabel = new Label();
            enrolledDateLabel = new Label();
            studentIdTextBox = new TextBox();
            studentNameTextBox = new TextBox();
            enrolledDatePicker = new DateTimePicker();
            addStudentButton = new Button();
            SuspendLayout();
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new Point(64, 49);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(24, 20);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "ID";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(64, 99);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(52, 20);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "Name";
            // 
            // enrolledDateLabel
            // 
            enrolledDateLabel.AutoSize = true;
            enrolledDateLabel.Location = new Point(64, 149);
            enrolledDateLabel.Name = "enrolledDateLabel";
            enrolledDateLabel.Size = new Size(107, 20);
            enrolledDateLabel.TabIndex = 2;
            enrolledDateLabel.Text = "Date Enrolled";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Enabled = false;
            studentIdTextBox.Location = new Point(193, 42);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(125, 27);
            studentIdTextBox.TabIndex = 3;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(193, 92);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(125, 27);
            studentNameTextBox.TabIndex = 4;
            // 
            // enrolledDatePicker
            // 
            enrolledDatePicker.Location = new Point(195, 147);
            enrolledDatePicker.Name = "enrolledDatePicker";
            enrolledDatePicker.Size = new Size(173, 27);
            enrolledDatePicker.TabIndex = 5;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(172, 202);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(94, 29);
            addStudentButton.TabIndex = 6;
            addStudentButton.Text = "Add";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 254);
            Controls.Add(addStudentButton);
            Controls.Add(enrolledDatePicker);
            Controls.Add(studentNameTextBox);
            Controls.Add(studentIdTextBox);
            Controls.Add(enrolledDateLabel);
            Controls.Add(studentNameLabel);
            Controls.Add(studentIdLabel);
            Name = "AddStudentForm";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentIdLabel;
        private Label studentNameLabel;
        private Label enrolledDateLabel;
        private TextBox studentIdTextBox;
        private TextBox studentNameTextBox;
        private DateTimePicker enrolledDatePicker;
        private Button addStudentButton;
    }
}
