namespace BlackJackApplication
{
    partial class frmMainMenu
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
            this.manageProfileButton = new System.Windows.Forms.Button();
            this.setAmountTextBox = new System.Windows.Forms.TextBox();
            this.setAmountLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.identityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(109, 58);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(583, 111);
            this.signInLabel.TabIndex = 2;
            this.signInLabel.Text = "Blackjack";
            // 
            // manageProfileButton
            // 
            this.manageProfileButton.Location = new System.Drawing.Point(352, 278);
            this.manageProfileButton.Name = "manageProfileButton";
            this.manageProfileButton.Size = new System.Drawing.Size(102, 23);
            this.manageProfileButton.TabIndex = 3;
            this.manageProfileButton.Text = "Manage Profile";
            this.manageProfileButton.UseVisualStyleBackColor = true;
            this.manageProfileButton.Click += new System.EventHandler(this.manageProfileButton_Click);
            // 
            // setAmountTextBox
            // 
            this.setAmountTextBox.Location = new System.Drawing.Point(352, 252);
            this.setAmountTextBox.Name = "setAmountTextBox";
            this.setAmountTextBox.Size = new System.Drawing.Size(102, 20);
            this.setAmountTextBox.TabIndex = 4;
            // 
            // setAmountLabel
            // 
            this.setAmountLabel.AutoSize = true;
            this.setAmountLabel.Location = new System.Drawing.Point(245, 255);
            this.setAmountLabel.Name = "setAmountLabel";
            this.setAmountLabel.Size = new System.Drawing.Size(101, 13);
            this.setAmountLabel.TabIndex = 5;
            this.setAmountLabel.Text = "Set Starting Amount";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(352, 308);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(102, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(713, 415);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.Location = new System.Drawing.Point(13, 13);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(71, 13);
            this.identityLabel.TabIndex = 8;
            this.identityLabel.Text = "Signed in as: ";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.setAmountLabel);
            this.Controls.Add(this.setAmountTextBox);
            this.Controls.Add(this.manageProfileButton);
            this.Controls.Add(this.signInLabel);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Button manageProfileButton;
        private System.Windows.Forms.TextBox setAmountTextBox;
        private System.Windows.Forms.Label setAmountLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label identityLabel;
    }
}