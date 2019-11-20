namespace BlackJackApplication
{
    partial class startScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startScreenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.initialAmountTxtBx = new System.Windows.Forms.TextBox();
            this.manageProfile = new System.Windows.Forms.Button();
            this.numPlayersLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p3SigninButton = new System.Windows.Forms.Button();
            this.p2SigninButton = new System.Windows.Forms.Button();
            this.p1SigninButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blackjack";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(416, 481);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Initial Amount: $";
            // 
            // initialAmountTxtBx
            // 
            this.initialAmountTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialAmountTxtBx.Location = new System.Drawing.Point(487, 383);
            this.initialAmountTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.initialAmountTxtBx.Name = "initialAmountTxtBx";
            this.initialAmountTxtBx.Size = new System.Drawing.Size(196, 30);
            this.initialAmountTxtBx.TabIndex = 3;
            // 
            // manageProfile
            // 
            this.manageProfile.Location = new System.Drawing.Point(38, 172);
            this.manageProfile.Margin = new System.Windows.Forms.Padding(2);
            this.manageProfile.Name = "manageProfile";
            this.manageProfile.Size = new System.Drawing.Size(91, 19);
            this.manageProfile.TabIndex = 4;
            this.manageProfile.Text = "Manage Profile";
            this.manageProfile.UseVisualStyleBackColor = true;
            this.manageProfile.Click += new System.EventHandler(this.ManageProfile_Click);
            // 
            // numPlayersLabel
            // 
            this.numPlayersLabel.AutoSize = true;
            this.numPlayersLabel.Location = new System.Drawing.Point(141, 38);
            this.numPlayersLabel.Name = "numPlayersLabel";
            this.numPlayersLabel.Size = new System.Drawing.Size(13, 13);
            this.numPlayersLabel.TabIndex = 5;
            this.numPlayersLabel.Text = "1";
            this.numPlayersLabel.Click += new System.EventHandler(this.numPlayersLabel_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(154, 54);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(40, 25);
            this.minusButton.TabIndex = 6;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(104, 54);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(40, 25);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Players";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p3SigninButton);
            this.groupBox1.Controls.Add(this.p2SigninButton);
            this.groupBox1.Controls.Add(this.p1SigninButton);
            this.groupBox1.Controls.Add(this.minusButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.plusButton);
            this.groupBox1.Controls.Add(this.numPlayersLabel);
            this.groupBox1.Location = new System.Drawing.Point(769, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // p3SigninButton
            // 
            this.p3SigninButton.Location = new System.Drawing.Point(7, 71);
            this.p3SigninButton.Name = "p3SigninButton";
            this.p3SigninButton.Size = new System.Drawing.Size(75, 23);
            this.p3SigninButton.TabIndex = 11;
            this.p3SigninButton.Text = "Player 3";
            this.p3SigninButton.UseVisualStyleBackColor = true;
            this.p3SigninButton.Click += new System.EventHandler(this.p3SigninButton_Click);
            // 
            // p2SigninButton
            // 
            this.p2SigninButton.Location = new System.Drawing.Point(7, 43);
            this.p2SigninButton.Name = "p2SigninButton";
            this.p2SigninButton.Size = new System.Drawing.Size(75, 23);
            this.p2SigninButton.TabIndex = 10;
            this.p2SigninButton.Text = "Player 2";
            this.p2SigninButton.UseVisualStyleBackColor = true;
            this.p2SigninButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // p1SigninButton
            // 
            this.p1SigninButton.Location = new System.Drawing.Point(6, 15);
            this.p1SigninButton.Name = "p1SigninButton";
            this.p1SigninButton.Size = new System.Drawing.Size(75, 23);
            this.p1SigninButton.TabIndex = 9;
            this.p1SigninButton.Text = "Player 1";
            this.p1SigninButton.UseVisualStyleBackColor = true;
            this.p1SigninButton.Click += new System.EventHandler(this.p1SigninButton_Click);
            // 
            // createProfileButton
            // 
            this.createProfileButton.Location = new System.Drawing.Point(38, 149);
            this.createProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(91, 19);
            this.createProfileButton.TabIndex = 10;
            this.createProfileButton.Text = "Create Profile";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // startScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(999, 609);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manageProfile);
            this.Controls.Add(this.initialAmountTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startScreenForm";
            this.Text = "startScreenForm";
            this.Load += new System.EventHandler(this.startScreenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialAmountTxtBx;
        private System.Windows.Forms.Button manageProfile;
        private System.Windows.Forms.Label numPlayersLabel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button p3SigninButton;
        private System.Windows.Forms.Button p2SigninButton;
        private System.Windows.Forms.Button p1SigninButton;
        private System.Windows.Forms.Button createProfileButton;
    }
}