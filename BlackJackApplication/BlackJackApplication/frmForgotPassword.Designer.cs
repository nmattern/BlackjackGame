namespace BlackJackApplication
{
    partial class frmForgotPassword
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.recovATextBox = new System.Windows.Forms.TextBox();
            this.sumbitButton = new System.Windows.Forms.Button();
            this.recovQLabel = new System.Windows.Forms.Label();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.confPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.wrongAnswerLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pullQButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(84, 34);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(639, 76);
            this.signInLabel.TabIndex = 2;
            this.signInLabel.Text = "Forgot Password";
            // 
            // recovATextBox
            // 
            this.recovATextBox.Location = new System.Drawing.Point(345, 192);
            this.recovATextBox.Name = "recovATextBox";
            this.recovATextBox.Size = new System.Drawing.Size(100, 20);
            this.recovATextBox.TabIndex = 3;
            // 
            // sumbitButton
            // 
            this.sumbitButton.Location = new System.Drawing.Point(344, 217);
            this.sumbitButton.Name = "sumbitButton";
            this.sumbitButton.Size = new System.Drawing.Size(100, 23);
            this.sumbitButton.TabIndex = 4;
            this.sumbitButton.Text = "Submit";
            this.sumbitButton.UseVisualStyleBackColor = true;
            this.sumbitButton.Click += new System.EventHandler(this.sumbitButton_Click);
            // 
            // recovQLabel
            // 
            this.recovQLabel.AutoSize = true;
            this.recovQLabel.Location = new System.Drawing.Point(94, 217);
            this.recovQLabel.Name = "recovQLabel";
            this.recovQLabel.Size = new System.Drawing.Size(104, 13);
            this.recovQLabel.TabIndex = 5;
            this.recovQLabel.Text = "Recovery Question: ";
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(344, 245);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPassTextBox.TabIndex = 6;
            this.newPassTextBox.Text = "New Password:";
            this.newPassTextBox.Visible = false;
            this.newPassTextBox.Click += new System.EventHandler(this.newPassTextBox_Click);
            // 
            // confPassTextBox
            // 
            this.confPassTextBox.Location = new System.Drawing.Point(344, 270);
            this.confPassTextBox.Name = "confPassTextBox";
            this.confPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.confPassTextBox.TabIndex = 7;
            this.confPassTextBox.Text = "Confirm Password:";
            this.confPassTextBox.Visible = false;
            this.confPassTextBox.Click += new System.EventHandler(this.confPassTextBox_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(344, 295);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(345, 139);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 9;
            this.usernameTextBox.Text = "Username: ";
            this.usernameTextBox.Click += new System.EventHandler(this.usernameTextBox_Click);
            // 
            // wrongAnswerLabel
            // 
            this.wrongAnswerLabel.AutoSize = true;
            this.wrongAnswerLabel.Location = new System.Drawing.Point(450, 206);
            this.wrongAnswerLabel.Name = "wrongAnswerLabel";
            this.wrongAnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.wrongAnswerLabel.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(450, 309);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel.TabIndex = 11;
            // 
            // pullQButton
            // 
            this.pullQButton.Location = new System.Drawing.Point(345, 164);
            this.pullQButton.Name = "pullQButton";
            this.pullQButton.Size = new System.Drawing.Size(100, 23);
            this.pullQButton.TabIndex = 12;
            this.pullQButton.Text = "Pull Question";
            this.pullQButton.UseVisualStyleBackColor = true;
            this.pullQButton.Click += new System.EventHandler(this.pullQButton_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pullQButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.wrongAnswerLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.recovQLabel);
            this.Controls.Add(this.sumbitButton);
            this.Controls.Add(this.recovATextBox);
            this.Controls.Add(this.signInLabel);
            this.Name = "frmForgotPassword";
            this.Text = "frmForgotPassword";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.TextBox recovATextBox;
        private System.Windows.Forms.Button sumbitButton;
        private System.Windows.Forms.Label recovQLabel;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox confPassTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label wrongAnswerLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button pullQButton;
    }
}