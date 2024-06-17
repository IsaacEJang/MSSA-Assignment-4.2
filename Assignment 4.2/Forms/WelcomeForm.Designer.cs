namespace Assignment_4._2
{
    partial class WelcomeForm
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
            this.LogInToAccount = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SaveStudentListByGPA = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInToAccount
            // 
            this.LogInToAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInToAccount.Location = new System.Drawing.Point(12, 12);
            this.LogInToAccount.Name = "LogInToAccount";
            this.LogInToAccount.Size = new System.Drawing.Size(177, 96);
            this.LogInToAccount.TabIndex = 0;
            this.LogInToAccount.Text = "Log In to Account";
            this.LogInToAccount.UseVisualStyleBackColor = true;
            this.LogInToAccount.Click += new System.EventHandler(this.LogInToAccount_Click_1);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(215, 12);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(177, 96);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // SaveStudentListByGPA
            // 
            this.SaveStudentListByGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveStudentListByGPA.Location = new System.Drawing.Point(215, 125);
            this.SaveStudentListByGPA.Name = "SaveStudentListByGPA";
            this.SaveStudentListByGPA.Size = new System.Drawing.Size(177, 119);
            this.SaveStudentListByGPA.TabIndex = 2;
            this.SaveStudentListByGPA.Text = "Save Student List";
            this.SaveStudentListByGPA.UseVisualStyleBackColor = true;
            this.SaveStudentListByGPA.Click += new System.EventHandler(this.SaveStudentListByGPA_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 148);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 96);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 260);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveStudentListByGPA);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.LogInToAccount);
            this.Name = "WelcomeForm";
            this.Text = "Teacher\'s Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInToAccount;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button SaveStudentListByGPA;
        private System.Windows.Forms.Button ExitButton;
    }
}

