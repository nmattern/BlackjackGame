namespace BlackJackApplication
{
    partial class ProfileForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.creditCardErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.profilePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.profileAddressTextBox = new System.Windows.Forms.TextBox();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.recovQLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profileCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordErrorLabel = new System.Windows.Forms.Label();
            this.confirmPasswordErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(253, 462);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 28);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(428, 185);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nameErrorLabel.TabIndex = 14;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Location = new System.Drawing.Point(428, 381);
            this.addressErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.addressErrorLabel.TabIndex = 15;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(428, 413);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.phoneErrorLabel.TabIndex = 16;
            // 
            // creditCardErrorLabel
            // 
            this.creditCardErrorLabel.AutoSize = true;
            this.creditCardErrorLabel.Location = new System.Drawing.Point(428, 349);
            this.creditCardErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditCardErrorLabel.Name = "creditCardErrorLabel";
            this.creditCardErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.creditCardErrorLabel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Name:";
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(288, 182);
            this.profileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profileNameTextBox.MaxLength = 30;
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.profileNameTextBox.TabIndex = 20;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(208, 413);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 17);
            this.phoneLabel.TabIndex = 34;
            this.phoneLabel.Text = "Phone #: ";
            // 
            // profilePhoneNumberTextBox
            // 
            this.profilePhoneNumberTextBox.Location = new System.Drawing.Point(288, 410);
            this.profilePhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePhoneNumberTextBox.MaxLength = 11;
            this.profilePhoneNumberTextBox.Name = "profilePhoneNumberTextBox";
            this.profilePhoneNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.profilePhoneNumberTextBox.TabIndex = 28;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(212, 381);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 17);
            this.addressLabel.TabIndex = 33;
            this.addressLabel.Text = "Address: ";
            // 
            // profileAddressTextBox
            // 
            this.profileAddressTextBox.Location = new System.Drawing.Point(288, 378);
            this.profileAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profileAddressTextBox.MaxLength = 50;
            this.profileAddressTextBox.Name = "profileAddressTextBox";
            this.profileAddressTextBox.Size = new System.Drawing.Size(132, 22);
            this.profileAddressTextBox.TabIndex = 26;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(180, 349);
            this.creditCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(99, 17);
            this.creditCardLabel.TabIndex = 32;
            this.creditCardLabel.Text = "Credit Card #: ";
            // 
            // recovQLabel
            // 
            this.recovQLabel.AutoSize = true;
            this.recovQLabel.Location = new System.Drawing.Point(159, 315);
            this.recovQLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recovQLabel.Name = "recovQLabel";
            this.recovQLabel.Size = new System.Drawing.Size(121, 17);
            this.recovQLabel.TabIndex = 31;
            this.recovQLabel.Text = "ConfirmPassword:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(176, 283);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(104, 17);
            this.confirmPasswordLabel.TabIndex = 30;
            this.confirmPasswordLabel.Text = "New Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(156, 250);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 17);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "Current Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(203, 219);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 27;
            this.usernameLabel.Text = "Username:";
            // 
            // profileCreditCardTextBox
            // 
            this.profileCreditCardTextBox.Location = new System.Drawing.Point(288, 346);
            this.profileCreditCardTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profileCreditCardTextBox.MaxLength = 16;
            this.profileCreditCardTextBox.Name = "profileCreditCardTextBox";
            this.profileCreditCardTextBox.Size = new System.Drawing.Size(132, 22);
            this.profileCreditCardTextBox.TabIndex = 25;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(288, 312);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextBox.MaxLength = 50;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.confirmPasswordTextBox.TabIndex = 24;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(288, 280);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordTextBox.MaxLength = 20;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.newPasswordTextBox.TabIndex = 23;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Location = new System.Drawing.Point(288, 247);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentPasswordTextBox.MaxLength = 20;
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.currentPasswordTextBox.TabIndex = 22;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(288, 214);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.usernameTextBox.TabIndex = 21;
            // 
            // currentPasswordErrorLabel
            // 
            this.currentPasswordErrorLabel.AutoSize = true;
            this.currentPasswordErrorLabel.Location = new System.Drawing.Point(428, 250);
            this.currentPasswordErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPasswordErrorLabel.Name = "currentPasswordErrorLabel";
            this.currentPasswordErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.currentPasswordErrorLabel.TabIndex = 36;
            // 
            // confirmPasswordErrorLabel
            // 
            this.confirmPasswordErrorLabel.AutoSize = true;
            this.confirmPasswordErrorLabel.Location = new System.Drawing.Point(428, 315);
            this.confirmPasswordErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            this.confirmPasswordErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.confirmPasswordErrorLabel.TabIndex = 37;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(605, 544);
            this.Controls.Add(this.confirmPasswordErrorLabel);
            this.Controls.Add(this.currentPasswordErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.profilePhoneNumberTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.profileAddressTextBox);
            this.Controls.Add(this.creditCardLabel);
            this.Controls.Add(this.recovQLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.profileCreditCardTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.creditCardErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label creditCardErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox profilePhoneNumberTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox profileAddressTextBox;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label recovQLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox profileCreditCardTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label currentPasswordErrorLabel;
        private System.Windows.Forms.Label confirmPasswordErrorLabel;
    }
}