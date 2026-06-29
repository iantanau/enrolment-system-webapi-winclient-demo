namespace EnrolmentWinClient
{
    partial class AddCourseForm
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
            addCourseButton = new Button();
            courseIdTextBox = new TextBox();
            courseCostLabel = new Label();
            courseNameTextBox = new TextBox();
            courseNameLabel = new Label();
            courseIdLabel = new Label();
            courseCostTextBox = new TextBox();
            SuspendLayout();
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(172, 212);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(94, 29);
            addCourseButton.TabIndex = 14;
            addCourseButton.Text = "Add";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Enabled = false;
            courseIdTextBox.Location = new Point(195, 49);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(125, 27);
            courseIdTextBox.TabIndex = 11;
            // 
            // courseCostLabel
            // 
            courseCostLabel.AutoSize = true;
            courseCostLabel.Location = new Point(66, 156);
            courseCostLabel.Name = "courseCostLabel";
            courseCostLabel.Size = new Size(42, 20);
            courseCostLabel.TabIndex = 10;
            courseCostLabel.Text = "Cost";
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(195, 99);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(125, 27);
            courseNameTextBox.TabIndex = 12;
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(66, 106);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(107, 20);
            courseNameLabel.TabIndex = 9;
            courseNameLabel.Text = "Course Name";
            // 
            // courseIdLabel
            // 
            courseIdLabel.AutoSize = true;
            courseIdLabel.Location = new Point(66, 56);
            courseIdLabel.Name = "courseIdLabel";
            courseIdLabel.Size = new Size(79, 20);
            courseIdLabel.TabIndex = 8;
            courseIdLabel.Text = "Course ID";
            // 
            // courseCostTextBox
            // 
            courseCostTextBox.Location = new Point(195, 149);
            courseCostTextBox.Name = "courseCostTextBox";
            courseCostTextBox.Size = new Size(125, 27);
            courseCostTextBox.TabIndex = 16;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 272);
            Controls.Add(courseCostTextBox);
            Controls.Add(addCourseButton);
            Controls.Add(courseNameTextBox);
            Controls.Add(courseIdTextBox);
            Controls.Add(courseCostLabel);
            Controls.Add(courseNameLabel);
            Controls.Add(courseIdLabel);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addCourseButton;
        private DateTimePicker datePicker;
        private TextBox nameTextBox;
        private TextBox courseIdTextBox;
        private Label courseCostLabel;
        private TextBox courseNameTextBox;
        private Label courseNameLabel;
        private Label courseIdLabel;
        private TextBox courseCostTextBox;
    }
}