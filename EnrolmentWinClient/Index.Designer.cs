namespace EnrolmentWinClient
{
    partial class Index
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
            addStudentButton = new Button();
            viewStudentsButton = new Button();
            viewCoursesButton = new Button();
            addCourseButton = new Button();
            addEnrolmentButton = new Button();
            viewEnrolmentButton = new Button();
            SuspendLayout();
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(69, 45);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(180, 29);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // viewStudentsButton
            // 
            viewStudentsButton.Location = new Point(69, 93);
            viewStudentsButton.Name = "viewStudentsButton";
            viewStudentsButton.Size = new Size(180, 29);
            viewStudentsButton.TabIndex = 0;
            viewStudentsButton.Text = "View All Students";
            viewStudentsButton.UseVisualStyleBackColor = true;
            viewStudentsButton.Click += viewStudentsButton_Click;
            // 
            // viewCoursesButton
            // 
            viewCoursesButton.Location = new Point(69, 185);
            viewCoursesButton.Name = "viewCoursesButton";
            viewCoursesButton.Size = new Size(180, 29);
            viewCoursesButton.TabIndex = 0;
            viewCoursesButton.Text = "View All Courses";
            viewCoursesButton.UseVisualStyleBackColor = true;
            viewCoursesButton.Click += viewCoursesButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(69, 139);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(180, 29);
            addCourseButton.TabIndex = 0;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // addEnrolmentButton
            // 
            addEnrolmentButton.Location = new Point(69, 231);
            addEnrolmentButton.Name = "addEnrolmentButton";
            addEnrolmentButton.Size = new Size(180, 29);
            addEnrolmentButton.TabIndex = 0;
            addEnrolmentButton.Text = "Create Enrolment";
            addEnrolmentButton.UseVisualStyleBackColor = true;
            addEnrolmentButton.Click += addEnrolmentButton_Click;
            // 
            // viewEnrolmentButton
            // 
            viewEnrolmentButton.Location = new Point(69, 277);
            viewEnrolmentButton.Name = "viewEnrolmentButton";
            viewEnrolmentButton.Size = new Size(180, 48);
            viewEnrolmentButton.TabIndex = 0;
            viewEnrolmentButton.Text = "View Course Enrolment";
            viewEnrolmentButton.UseVisualStyleBackColor = true;
            viewEnrolmentButton.Click += viewEnrolmentButton_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 368);
            Controls.Add(viewEnrolmentButton);
            Controls.Add(viewCoursesButton);
            Controls.Add(viewStudentsButton);
            Controls.Add(addEnrolmentButton);
            Controls.Add(addCourseButton);
            Controls.Add(addStudentButton);
            Name = "Index";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button addStudentButton;
        private Button viewStudentsButton;
        private Button viewCoursesButton;
        private Button addCourseButton;
        private Button addEnrolmentButton;
        private Button viewEnrolmentButton;
    }
}