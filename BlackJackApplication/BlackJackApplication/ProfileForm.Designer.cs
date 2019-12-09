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
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.profileAddressTextBox = new System.Windows.Forms.TextBox();
            this.profilePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.profileCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.creditCardErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credit Card:";
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(195, 148);
            this.profileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profileNameTextBox.MaxLength = 30;
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.profileNameTextBox.TabIndex = 9;
            // 
            // profileAddressTextBox
            // 
            this.profileAddressTextBox.Location = new System.Drawing.Point(195, 205);
            this.profileAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profileAddressTextBox.MaxLength = 50;
            this.profileAddressTextBox.Name = "profileAddressTextBox";
            this.profileAddressTextBox.Size = new System.Drawing.Size(121, 20);
            this.profileAddressTextBox.TabIndex = 10;
            // 
            // profilePhoneNumberTextBox
            // 
            this.profilePhoneNumberTextBox.Location = new System.Drawing.Point(195, 262);
            this.profilePhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePhoneNumberTextBox.MaxLength = 11;
            this.profilePhoneNumberTextBox.Name = "profilePhoneNumberTextBox";
            this.profilePhoneNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.profilePhoneNumberTextBox.TabIndex = 11;
            // 
            // profileCreditCardTextBox
            // 
            this.profileCreditCardTextBox.Location = new System.Drawing.Point(195, 319);
            this.profileCreditCardTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profileCreditCardTextBox.MaxLength = 16;
            this.profileCreditCardTextBox.Name = "profileCreditCardTextBox";
            this.profileCreditCardTextBox.Size = new System.Drawing.Size(121, 20);
            this.profileCreditCardTextBox.TabIndex = 12;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(190, 375);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(321, 151);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.TabIndex = 14;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Location = new System.Drawing.Point(321, 208);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addressErrorLabel.TabIndex = 15;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(321, 265);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorLabel.TabIndex = 16;
            // 
            // creditCardErrorLabel
            // 
            this.creditCardErrorLabel.AutoSize = true;
            this.creditCardErrorLabel.Location = new System.Drawing.Point(321, 322);
            this.creditCardErrorLabel.Name = "creditCardErrorLabel";
            this.creditCardErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.creditCardErrorLabel.TabIndex = 17;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(454, 442);
            this.Controls.Add(this.creditCardErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.profileCreditCardTextBox);
            this.Controls.Add(this.profilePhoneNumberTextBox);
            this.Controls.Add(this.profileAddressTextBox);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.TextBox profileAddressTextBox;
        private System.Windows.Forms.TextBox profilePhoneNumberTextBox;
        private System.Windows.Forms.TextBox profileCreditCardTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label creditCardErrorLabel;
    }
}