namespace BlackJackApplication
{
    partial class frmLogin
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.incorrectLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(206, 32);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(389, 111);
            this.signInLabel.TabIndex = 1;
            this.signInLabel.Text = "Sign In";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(316, 198);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(316, 239);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password: ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(384, 198);
            this.usernameTextBox.MaxLength = 10;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(384, 232);
            this.passwordTextBox.MaxLength = 10;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(384, 268);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(100, 23);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // createProfileButton
            // 
            this.createProfileButton.Location = new System.Drawing.Point(384, 297);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(100, 23);
            this.createProfileButton.TabIndex = 7;
            this.createProfileButton.Text = "Create Profile";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // incorrectLoginLabel
            // 
            this.incorrectLoginLabel.AutoSize = true;
            this.incorrectLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLoginLabel.Location = new System.Drawing.Point(507, 235);
            this.incorrectLoginLabel.Name = "incorrectLoginLabel";
            this.incorrectLoginLabel.Size = new System.Drawing.Size(0, 20);
            this.incorrectLoginLabel.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incorrectLoginLabel);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signInLabel);
            this.Name = "frmLogin";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.Label incorrectLoginLabel;
    }
}