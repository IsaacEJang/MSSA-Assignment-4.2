namespace Assignment_4._2
{
    partial class SignInScreen
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
            this.TeacherPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TeacherUserNameTextBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeacherPasswordTextBox
            // 
            this.TeacherPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherPasswordTextBox.Location = new System.Drawing.Point(237, 80);
            this.TeacherPasswordTextBox.Name = "TeacherPasswordTextBox";
            this.TeacherPasswordTextBox.Size = new System.Drawing.Size(350, 38);
            this.TeacherPasswordTextBox.TabIndex = 13;
            // 
            // TeacherUserNameTextBox
            // 
            this.TeacherUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherUserNameTextBox.Location = new System.Drawing.Point(237, 32);
            this.TeacherUserNameTextBox.Name = "TeacherUserNameTextBox";
            this.TeacherUserNameTextBox.Size = new System.Drawing.Size(350, 38);
            this.TeacherUserNameTextBox.TabIndex = 12;
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(140, 142);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(274, 59);
            this.SignInButton.TabIndex = 11;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 80);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(146, 32);
            this.StudentNameLabel.TabIndex = 9;
            this.StudentNameLabel.Text = "Password:";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(12, 32);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(163, 32);
            this.StudentIDLabel.TabIndex = 8;
            this.StudentIDLabel.Text = "User Name:";
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 225);
            this.Controls.Add(this.TeacherPasswordTextBox);
            this.Controls.Add(this.TeacherUserNameTextBox);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Name = "SignInScreen";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeacherPasswordTextBox;
        private System.Windows.Forms.TextBox TeacherUserNameTextBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentIDLabel;
    }
}