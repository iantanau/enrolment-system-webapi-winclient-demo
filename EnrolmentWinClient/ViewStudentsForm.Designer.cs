namespace EnrolmentWinClient
{
    partial class ViewStudentsForm
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
            studentListBox = new ListBox();
            showStudentsButton = new Button();
            SuspendLayout();
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.Location = new Point(12, 11);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(500, 364);
            studentListBox.TabIndex = 0;
            // 
            // showStudentsButton
            // 
            showStudentsButton.Location = new Point(174, 398);
            showStudentsButton.Name = "showStudentsButton";
            showStudentsButton.Size = new Size(162, 29);
            showStudentsButton.TabIndex = 1;
            showStudentsButton.Text = "Show All Students";
            showStudentsButton.UseVisualStyleBackColor = true;
            showStudentsButton.Click += showStudentsButton_Click;
            // 
            // ViewStudentsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(showStudentsButton);
            Controls.Add(studentListBox);
            Name = "ViewStudentsForm";
            Text = "View Students";
            ResumeLayout(false);
        }

        #endregion

        private ListBox studentListBox;
        private Button showStudentsButton;
    }
}