namespace BlackJackApplication
{
    partial class CreateProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.creditCardTextBox = new System.Windows.Forms.TextBox();
            this.recovATextBox = new System.Windows.Forms.TextBox();
            this.recovQTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.recovQLabel = new System.Windows.Forms.Label();
            this.recovALabel = new System.Windows.Forms.Label();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.confPasswordErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.recovAErrorLabel = new System.Windows.Forms.Label();
            this.recovQErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.creditCardErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(381, 168);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(381, 195);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(381, 222);
            this.confirmPasswordTextBox.MaxLength = 20;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTextBox.TabIndex = 4;
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Location = new System.Drawing.Point(381, 302);
            this.creditCardTextBox.MaxLength = 16;
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditCardTextBox.TabIndex = 7;
            // 
            // recovATextBox
            // 
            this.recovATextBox.Location = new System.Drawing.Point(381, 275);
            this.recovATextBox.MaxLength = 20;
            this.recovATextBox.Name = "recovATextBox";
            this.recovATextBox.Size = new System.Drawing.Size(100, 20);
            this.recovATextBox.TabIndex = 6;
            // 
            // recovQTextBox
            // 
            this.recovQTextBox.Location = new System.Drawing.Point(381, 248);
            this.recovQTextBox.MaxLength = 50;
            this.recovQTextBox.Name = "recovQTextBox";
            this.recovQTextBox.Size = new System.Drawing.Size(100, 20);
            this.recovQTextBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(314, 171);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(316, 198);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password: ";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(278, 225);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(97, 13);
            this.confirmPasswordLabel.TabIndex = 10;
            this.confirmPasswordLabel.Text = "Confirm Password: ";
            // 
            // recovQLabel
            // 
            this.recovQLabel.AutoSize = true;
            this.recovQLabel.Location = new System.Drawing.Point(271, 251);
            this.recovQLabel.Name = "recovQLabel";
            this.recovQLabel.Size = new System.Drawing.Size(104, 13);
            this.recovQLabel.TabIndex = 11;
            this.recovQLabel.Text = "Recovery Question: ";
            // 
            // recovALabel
            // 
            this.recovALabel.AutoSize = true;
            this.recovALabel.Location = new System.Drawing.Point(233, 278);
            this.recovALabel.Name = "recovALabel";
            this.recovALabel.Size = new System.Drawing.Size(142, 13);
            this.recovALabel.TabIndex = 12;
            this.recovALabel.Text = "Recovery Question Answer: ";
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(300, 305);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(75, 13);
            this.creditCardLabel.TabIndex = 13;
            this.creditCardLabel.Text = "Credit Card #: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(324, 331);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 13);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address: ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(381, 328);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(321, 357);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 13);
            this.phoneLabel.TabIndex = 17;
            this.phoneLabel.Text = "Phone #: ";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(381, 354);
            this.phoneTextBox.MaxLength = 11;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:  ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(381, 142);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(381, 380);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(487, 145);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.TabIndex = 20;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Location = new System.Drawing.Point(487, 171);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameErrorLabel.TabIndex = 21;
            // 
            // confPasswordErrorLabel
            // 
            this.confPasswordErrorLabel.AutoSize = true;
            this.confPasswordErrorLabel.Location = new System.Drawing.Point(487, 224);
            this.confPasswordErrorLabel.Name = "confPasswordErrorLabel";
            this.confPasswordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.confPasswordErrorLabel.TabIndex = 23;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Location = new System.Drawing.Point(487, 198);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordErrorLabel.TabIndex = 22;
            // 
            // recovAErrorLabel
            // 
            this.recovAErrorLabel.AutoSize = true;
            this.recovAErrorLabel.Location = new System.Drawing.Point(487, 277);
            this.recovAErrorLabel.Name = "recovAErrorLabel";
            this.recovAErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.recovAErrorLabel.TabIndex = 25;
            // 
            // recovQErrorLabel
            // 
            this.recovQErrorLabel.AutoSize = true;
            this.recovQErrorLabel.Location = new System.Drawing.Point(487, 251);
            this.recovQErrorLabel.Name = "recovQErrorLabel";
            this.recovQErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.recovQErrorLabel.TabIndex = 24;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Location = new System.Drawing.Point(487, 331);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addressErrorLabel.TabIndex = 27;
            // 
            // creditCardErrorLabel
            // 
            this.creditCardErrorLabel.AutoSize = true;
            this.creditCardErrorLabel.Location = new System.Drawing.Point(487, 305);
            this.creditCardErrorLabel.Name = "creditCardErrorLabel";
            this.creditCardErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.creditCardErrorLabel.TabIndex = 26;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(487, 357);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorLabel.TabIndex = 28;
            // 
            // CreateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.creditCardErrorLabel);
            this.Controls.Add(this.recovAErrorLabel);
            this.Controls.Add(this.recovQErrorLabel);
            this.Controls.Add(this.confPasswordErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.usernameErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.creditCardLabel);
            this.Controls.Add(this.recovALabel);
            this.Controls.Add(this.recovQLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.creditCardTextBox);
            this.Controls.Add(this.recovATextBox);
            this.Controls.Add(this.recovQTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateProfileForm";
            this.Text = "New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox creditCardTextBox;
        private System.Windows.Forms.TextBox recovATextBox;
        private System.Windows.Forms.TextBox recovQTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label recovQLabel;
        private System.Windows.Forms.Label recovALabel;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label confPasswordErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label recovAErrorLabel;
        private System.Windows.Forms.Label recovQErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label creditCardErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
    }
}