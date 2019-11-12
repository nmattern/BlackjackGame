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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileAddressLabel = new System.Windows.Forms.Label();
            this.profilePhoneNumberLabel = new System.Windows.Forms.Label();
            this.profileCreditCardLabel = new System.Windows.Forms.Label();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.profileAddressTextBox = new System.Windows.Forms.TextBox();
            this.profilePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.profileCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credit Card:";
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Location = new System.Drawing.Point(157, 210);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(123, 17);
            this.profileNameLabel.TabIndex = 5;
            this.profileNameLabel.Text = "no name available";
            this.profileNameLabel.Click += new System.EventHandler(this.profileNameLabel_Click);
            // 
            // profileAddressLabel
            // 
            this.profileAddressLabel.AutoSize = true;
            this.profileAddressLabel.Location = new System.Drawing.Point(175, 282);
            this.profileAddressLabel.Name = "profileAddressLabel";
            this.profileAddressLabel.Size = new System.Drawing.Size(139, 17);
            this.profileAddressLabel.TabIndex = 6;
            this.profileAddressLabel.Text = "no address available";
            this.profileAddressLabel.Click += new System.EventHandler(this.profileAddressLabel_Click);
            // 
            // profilePhoneNumberLabel
            // 
            this.profilePhoneNumberLabel.AutoSize = true;
            this.profilePhoneNumberLabel.Location = new System.Drawing.Point(249, 359);
            this.profilePhoneNumberLabel.Name = "profilePhoneNumberLabel";
            this.profilePhoneNumberLabel.Size = new System.Drawing.Size(180, 17);
            this.profilePhoneNumberLabel.TabIndex = 7;
            this.profilePhoneNumberLabel.Text = "no phone number available";
            this.profilePhoneNumberLabel.Click += new System.EventHandler(this.ProfilePhoneNumberLabel_Click);
            // 
            // profileCreditCardLabel
            // 
            this.profileCreditCardLabel.AutoSize = true;
            this.profileCreditCardLabel.Location = new System.Drawing.Point(209, 435);
            this.profileCreditCardLabel.Name = "profileCreditCardLabel";
            this.profileCreditCardLabel.Size = new System.Drawing.Size(155, 17);
            this.profileCreditCardLabel.TabIndex = 8;
            this.profileCreditCardLabel.Text = "no credit card available";
            this.profileCreditCardLabel.Click += new System.EventHandler(this.ProfileCreditCardLabel_Click);
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(160, 206);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.profileNameTextBox.TabIndex = 9;
            this.profileNameTextBox.Visible = false;
            this.profileNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameFocusLost);
            // 
            // profileAddressTextBox
            // 
            this.profileAddressTextBox.Location = new System.Drawing.Point(175, 279);
            this.profileAddressTextBox.Name = "profileAddressTextBox";
            this.profileAddressTextBox.Size = new System.Drawing.Size(284, 22);
            this.profileAddressTextBox.TabIndex = 10;
            this.profileAddressTextBox.Visible = false;
            this.profileAddressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressFocusLost);
            // 
            // profilePhoneNumberTextBox
            // 
            this.profilePhoneNumberTextBox.Location = new System.Drawing.Point(249, 356);
            this.profilePhoneNumberTextBox.Name = "profilePhoneNumberTextBox";
            this.profilePhoneNumberTextBox.Size = new System.Drawing.Size(284, 22);
            this.profilePhoneNumberTextBox.TabIndex = 11;
            this.profilePhoneNumberTextBox.Visible = false;
            this.profilePhoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumberFocusLost);
            // 
            // profileCreditCardTextBox
            // 
            this.profileCreditCardTextBox.Location = new System.Drawing.Point(209, 432);
            this.profileCreditCardTextBox.Name = "profileCreditCardTextBox";
            this.profileCreditCardTextBox.Size = new System.Drawing.Size(284, 22);
            this.profileCreditCardTextBox.TabIndex = 12;
            this.profileCreditCardTextBox.Visible = false;
            this.profileCreditCardTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.creditCardFocusLost);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(606, 544);
            this.Controls.Add(this.profileCreditCardTextBox);
            this.Controls.Add(this.profilePhoneNumberTextBox);
            this.Controls.Add(this.profileAddressTextBox);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.profileCreditCardLabel);
            this.Controls.Add(this.profilePhoneNumberLabel);
            this.Controls.Add(this.profileAddressLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label profileAddressLabel;
        private System.Windows.Forms.Label profilePhoneNumberLabel;
        private System.Windows.Forms.Label profileCreditCardLabel;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.TextBox profileAddressTextBox;
        private System.Windows.Forms.TextBox profilePhoneNumberTextBox;
        private System.Windows.Forms.TextBox profileCreditCardTextBox;
    }
}