namespace BlackJackApplication
{
    partial class tableForm
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
            this.currentMoneyLabel = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.dealerBetDescriptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.playerTotalLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.lockBetButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.adjustMoneyTextBox = new System.Windows.Forms.TextBox();
            this.adjustMoneyButton = new System.Windows.Forms.Button();
            this.adjustMoneyStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insuranceBetTxtBox = new System.Windows.Forms.TextBox();
            this.insuranceBetButton = new System.Windows.Forms.Button();
            this.insuranceBetValueLabel = new System.Windows.Forms.Label();
            this.insuranceBetLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lossesValueLabel = new System.Windows.Forms.Label();
            this.winsValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(976, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(1101, 98);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(0, 17);
            this.currentMoneyLabel.TabIndex = 1;
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Red;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hitButton.Location = new System.Drawing.Point(576, 406);
            this.hitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(132, 48);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.SystemColors.Control;
            this.standButton.Location = new System.Drawing.Point(773, 406);
            this.standButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(132, 48);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(1076, 224);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(24, 17);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // dealerBetDescriptionLabel
            // 
            this.dealerBetDescriptionLabel.AutoSize = true;
            this.dealerBetDescriptionLabel.Location = new System.Drawing.Point(57, 69);
            this.dealerBetDescriptionLabel.Name = "dealerBetDescriptionLabel";
            this.dealerBetDescriptionLabel.Size = new System.Drawing.Size(140, 17);
            this.dealerBetDescriptionLabel.TabIndex = 15;
            this.dealerBetDescriptionLabel.Text = "Current Visible Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Total:";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Location = new System.Drawing.Point(224, 69);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Location = new System.Drawing.Point(783, 69);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.playerTotalLabel.TabIndex = 18;
            this.playerTotalLabel.Text = "0";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(299, 385);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 95);
            this.endLabel.TabIndex = 22;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(595, 507);
            this.continueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(132, 48);
            this.continueButton.TabIndex = 23;
            this.continueButton.Text = "New Hand";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // lockBetButton
            // 
            this.lockBetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.lockBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lockBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockBetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.lockBetButton.Location = new System.Drawing.Point(1159, 257);
            this.lockBetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lockBetButton.Name = "lockBetButton";
            this.lockBetButton.Size = new System.Drawing.Size(180, 48);
            this.lockBetButton.TabIndex = 24;
            this.lockBetButton.Text = "Bet";
            this.lockBetButton.UseVisualStyleBackColor = false;
            this.lockBetButton.EnabledChanged += new System.EventHandler(this.lockBetButton_EnabledChanged);
            this.lockBetButton.Click += new System.EventHandler(this.lockBetButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(1159, 215);
            this.betTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(179, 22);
            this.betTextBox.TabIndex = 25;
            this.betTextBox.Text = "Enter Bet: ";
            this.betTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.betTextBox_MouseClick);
            this.betTextBox.TextChanged += new System.EventHandler(this.betTextBox_TextChanged);
            // 
            // adjustMoneyTextBox
            // 
            this.adjustMoneyTextBox.Location = new System.Drawing.Point(1157, 90);
            this.adjustMoneyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adjustMoneyTextBox.Name = "adjustMoneyTextBox";
            this.adjustMoneyTextBox.Size = new System.Drawing.Size(180, 22);
            this.adjustMoneyTextBox.TabIndex = 27;
            this.adjustMoneyTextBox.Text = "Enter New Current Money: ";
            this.adjustMoneyTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adjustMoneyTextBox_MouseClick);
            this.adjustMoneyTextBox.TextChanged += new System.EventHandler(this.adjustMoneyTextBox_TextChanged);
            // 
            // adjustMoneyButton
            // 
            this.adjustMoneyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.adjustMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustMoneyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adjustMoneyButton.Location = new System.Drawing.Point(1159, 123);
            this.adjustMoneyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(181, 66);
            this.adjustMoneyButton.TabIndex = 26;
            this.adjustMoneyButton.Text = "Adjust Current Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = false;
            this.adjustMoneyButton.Click += new System.EventHandler(this.adjustMoneyButton_Click);
            // 
            // adjustMoneyStatusLabel
            // 
            this.adjustMoneyStatusLabel.AutoSize = true;
            this.adjustMoneyStatusLabel.Location = new System.Drawing.Point(1087, 62);
            this.adjustMoneyStatusLabel.Name = "adjustMoneyStatusLabel";
            this.adjustMoneyStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.adjustMoneyStatusLabel.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dealer Cards:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Player Cards:";
            // 
            // insuranceBetTxtBox
            // 
            this.insuranceBetTxtBox.Location = new System.Drawing.Point(1157, 364);
            this.insuranceBetTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.insuranceBetTxtBox.Name = "insuranceBetTxtBox";
            this.insuranceBetTxtBox.Size = new System.Drawing.Size(179, 22);
            this.insuranceBetTxtBox.TabIndex = 34;
            this.insuranceBetTxtBox.Text = "Enter Insurance:";
            this.insuranceBetTxtBox.Visible = false;
            this.insuranceBetTxtBox.Click += new System.EventHandler(this.insuranceBetTxtBox_Click);
            this.insuranceBetTxtBox.TextChanged += new System.EventHandler(this.insuranceBetTxtBox_TextChanged);
            // 
            // insuranceBetButton
            // 
            this.insuranceBetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.insuranceBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insuranceBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceBetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.insuranceBetButton.Location = new System.Drawing.Point(1157, 406);
            this.insuranceBetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceBetButton.Name = "insuranceBetButton";
            this.insuranceBetButton.Size = new System.Drawing.Size(180, 48);
            this.insuranceBetButton.TabIndex = 33;
            this.insuranceBetButton.Text = "Bet";
            this.insuranceBetButton.UseVisualStyleBackColor = false;
            this.insuranceBetButton.Visible = false;
            this.insuranceBetButton.Click += new System.EventHandler(this.insuranceBetButton_Click);
            // 
            // insuranceBetValueLabel
            // 
            this.insuranceBetValueLabel.AutoSize = true;
            this.insuranceBetValueLabel.Location = new System.Drawing.Point(1074, 373);
            this.insuranceBetValueLabel.Name = "insuranceBetValueLabel";
            this.insuranceBetValueLabel.Size = new System.Drawing.Size(0, 17);
            this.insuranceBetValueLabel.TabIndex = 32;
            this.insuranceBetValueLabel.Visible = false;
            // 
            // insuranceBetLabel
            // 
            this.insuranceBetLabel.AutoSize = true;
            this.insuranceBetLabel.Location = new System.Drawing.Point(974, 373);
            this.insuranceBetLabel.Name = "insuranceBetLabel";
            this.insuranceBetLabel.Size = new System.Drawing.Size(99, 17);
            this.insuranceBetLabel.TabIndex = 31;
            this.insuranceBetLabel.Text = "Insurance Bet:";
            this.insuranceBetLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1257, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Losses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1257, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Wins:";
            // 
            // lossesValueLabel
            // 
            this.lossesValueLabel.AutoSize = true;
            this.lossesValueLabel.Location = new System.Drawing.Point(1320, 50);
            this.lossesValueLabel.Name = "lossesValueLabel";
            this.lossesValueLabel.Size = new System.Drawing.Size(16, 17);
            this.lossesValueLabel.TabIndex = 37;
            this.lossesValueLabel.Text = "0";
            // 
            // winsValueLabel
            // 
            this.winsValueLabel.AutoSize = true;
            this.winsValueLabel.Location = new System.Drawing.Point(1320, 18);
            this.winsValueLabel.Name = "winsValueLabel";
            this.winsValueLabel.Size = new System.Drawing.Size(16, 17);
            this.winsValueLabel.TabIndex = 38;
            this.winsValueLabel.Text = "0";
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1353, 591);
            this.Controls.Add(this.winsValueLabel);
            this.Controls.Add(this.lossesValueLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insuranceBetTxtBox);
            this.Controls.Add(this.insuranceBetButton);
            this.Controls.Add(this.insuranceBetValueLabel);
            this.Controls.Add(this.insuranceBetLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adjustMoneyStatusLabel);
            this.Controls.Add(this.adjustMoneyTextBox);
            this.Controls.Add(this.adjustMoneyButton);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.lockBetButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.playerTotalLabel);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dealerBetDescriptionLabel);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.currentMoneyLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tableForm";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label betLabel;
        internal System.Windows.Forms.Label currentMoneyLabel;
        internal System.Windows.Forms.Button hitButton;
        internal System.Windows.Forms.Button standButton;
        internal System.Windows.Forms.Label dealerTotalLabel;
        internal System.Windows.Forms.Label playerTotalLabel;
        internal System.Windows.Forms.Label endLabel;
        internal System.Windows.Forms.Button continueButton;
        internal System.Windows.Forms.Button lockBetButton;
        internal System.Windows.Forms.TextBox betTextBox;
        internal System.Windows.Forms.Label dealerBetDescriptionLabel;
        internal System.Windows.Forms.TextBox adjustMoneyTextBox;
        internal System.Windows.Forms.Button adjustMoneyButton;
        private System.Windows.Forms.Label adjustMoneyStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox insuranceBetTxtBox;
        internal System.Windows.Forms.Button insuranceBetButton;
        internal System.Windows.Forms.Label insuranceBetValueLabel;
        internal System.Windows.Forms.Label insuranceBetLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lossesValueLabel;
        internal System.Windows.Forms.Label winsValueLabel;
    }
}

