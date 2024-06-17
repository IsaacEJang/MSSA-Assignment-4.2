namespace Assignment_4._2
{
    partial class AddNewStudent
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
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentGPALabel = new System.Windows.Forms.Label();
            this.AddNewStudentButton = new System.Windows.Forms.Button();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentGPATextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(12, 18);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(155, 32);
            this.StudentIDLabel.TabIndex = 0;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 64);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(203, 32);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Student Name:";
            // 
            // StudentGPALabel
            // 
            this.StudentGPALabel.AutoSize = true;
            this.StudentGPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGPALabel.Location = new System.Drawing.Point(12, 114);
            this.StudentGPALabel.Name = "StudentGPALabel";
            this.StudentGPALabel.Size = new System.Drawing.Size(188, 32);
            this.StudentGPALabel.TabIndex = 2;
            this.StudentGPALabel.Text = "Student GPA:";
            // 
            // AddNewStudentButton
            // 
            this.AddNewStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewStudentButton.Location = new System.Drawing.Point(301, 166);
            this.AddNewStudentButton.Name = "AddNewStudentButton";
            this.AddNewStudentButton.Size = new System.Drawing.Size(274, 59);
            this.AddNewStudentButton.TabIndex = 3;
            this.AddNewStudentButton.Text = "Add New Student";
            this.AddNewStudentButton.UseVisualStyleBackColor = true;
            this.AddNewStudentButton.Click += new System.EventHandler(this.AddNewStudentButton_Click_1);
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdTextBox.Location = new System.Drawing.Point(225, 15);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(350, 38);
            this.StudentIdTextBox.TabIndex = 4;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameTextBox.Location = new System.Drawing.Point(225, 64);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(350, 38);
            this.StudentNameTextBox.TabIndex = 5;
            // 
            // StudentGPATextBox
            // 
            this.StudentGPATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGPATextBox.Location = new System.Drawing.Point(225, 113);
            this.StudentGPATextBox.Name = "StudentGPATextBox";
            this.StudentGPATextBox.Size = new System.Drawing.Size(350, 38);
            this.StudentGPATextBox.TabIndex = 6;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AllowDrop = true;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(18, 166);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(136, 59);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 246);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StudentGPATextBox);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.AddNewStudentButton);
            this.Controls.Add(this.StudentGPALabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Name = "AddNewStudent";
            this.Text = "AddNewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentGPALabel;
        private System.Windows.Forms.Button AddNewStudentButton;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox StudentGPATextBox;
        private System.Windows.Forms.Button CancelBtn;
    }
}