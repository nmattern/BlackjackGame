namespace BlackJackApplication
{
    partial class frmGameBoard
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
            this.dealerCardLabel = new System.Windows.Forms.Label();
            this.dealerVisableTotalLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.adjustMoneyTextBox = new System.Windows.Forms.TextBox();
            this.adjustMoneyButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.insuranceBetTextBox = new System.Windows.Forms.TextBox();
            this.splitButton = new System.Windows.Forms.Button();
            this.insuranceButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.MaskedTextBox();
            this.player1CurrentTotal = new System.Windows.Forms.Label();
            this.player2CurrentTotal = new System.Windows.Forms.Label();
            this.player3CurrentTotal = new System.Windows.Forms.Label();
            this.player1CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.player2CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.player3CurrentMoneyLabel = new System.Windows.Forms.Label();
            this.player1BetLabel = new System.Windows.Forms.Label();
            this.player2BetLabel = new System.Windows.Forms.Label();
            this.player3BetLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.turnLabelPart1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dealerCardLabel
            // 
            this.dealerCardLabel.AutoSize = true;
            this.dealerCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCardLabel.Location = new System.Drawing.Point(12, 9);
            this.dealerCardLabel.Name = "dealerCardLabel";
            this.dealerCardLabel.Size = new System.Drawing.Size(137, 24);
            this.dealerCardLabel.TabIndex = 0;
            this.dealerCardLabel.Text = "Dealer Cards:";
            // 
            // dealerVisableTotalLabel
            // 
            this.dealerVisableTotalLabel.AutoSize = true;
            this.dealerVisableTotalLabel.Location = new System.Drawing.Point(16, 33);
            this.dealerVisableTotalLabel.Name = "dealerVisableTotalLabel";
            this.dealerVisableTotalLabel.Size = new System.Drawing.Size(111, 13);
            this.dealerVisableTotalLabel.TabIndex = 1;
            this.dealerVisableTotalLabel.Text = "Current Visable Total: ";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(15, 325);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(70, 24);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Cards:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(283, 325);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(70, 24);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Cards:";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Label.Location = new System.Drawing.Point(559, 325);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(70, 24);
            this.player3Label.TabIndex = 4;
            this.player3Label.Text = "Cards:";
            // 
            // adjustMoneyTextBox
            // 
            this.adjustMoneyTextBox.Location = new System.Drawing.Point(5, 17);
            this.adjustMoneyTextBox.Name = "adjustMoneyTextBox";
            this.adjustMoneyTextBox.Size = new System.Drawing.Size(133, 20);
            this.adjustMoneyTextBox.TabIndex = 28;
            this.adjustMoneyTextBox.Text = "Enter New Current Money: ";
            this.adjustMoneyTextBox.Click += new System.EventHandler(this.adjustMoneyTextBox_Click);
            // 
            // adjustMoneyButton
            // 
            this.adjustMoneyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.adjustMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustMoneyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adjustMoneyButton.Location = new System.Drawing.Point(5, 45);
            this.adjustMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(134, 54);
            this.adjustMoneyButton.TabIndex = 29;
            this.adjustMoneyButton.Text = "Adjust Current Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = false;
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.SystemColors.Control;
            this.betButton.Location = new System.Drawing.Point(6, 135);
            this.betButton.Margin = new System.Windows.Forms.Padding(2);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(133, 39);
            this.betButton.TabIndex = 32;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Red;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hitButton.Location = new System.Drawing.Point(5, 182);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(133, 39);
            this.hitButton.TabIndex = 33;
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
            this.standButton.Location = new System.Drawing.Point(6, 229);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(133, 39);
            this.standButton.TabIndex = 34;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(6, 276);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(133, 39);
            this.continueButton.TabIndex = 35;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.betTextBox);
            this.controlsGroupBox.Controls.Add(this.adjustMoneyTextBox);
            this.controlsGroupBox.Controls.Add(this.continueButton);
            this.controlsGroupBox.Controls.Add(this.adjustMoneyButton);
            this.controlsGroupBox.Controls.Add(this.standButton);
            this.controlsGroupBox.Controls.Add(this.hitButton);
            this.controlsGroupBox.Controls.Add(this.betButton);
            this.controlsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsGroupBox.Location = new System.Drawing.Point(880, 9);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.controlsGroupBox.Size = new System.Drawing.Size(197, 567);
            this.controlsGroupBox.TabIndex = 36;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // insuranceBetTextBox
            // 
            this.insuranceBetTextBox.Location = new System.Drawing.Point(8, 454);
            this.insuranceBetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.insuranceBetTextBox.Name = "insuranceBetTextBox";
            this.insuranceBetTextBox.Size = new System.Drawing.Size(176, 23);
            this.insuranceBetTextBox.TabIndex = 37;
            this.insuranceBetTextBox.Text = "Enter Bet: ";
            this.insuranceBetTextBox.Visible = false;
            // 
            // splitButton
            // 
            this.splitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.splitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.splitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.splitButton.Location = new System.Drawing.Point(8, 411);
            this.splitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(177, 48);
            this.splitButton.TabIndex = 36;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = false;
            this.splitButton.Visible = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.insuranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insuranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.insuranceButton.Location = new System.Drawing.Point(7, 400);
            this.insuranceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(177, 48);
            this.insuranceButton.TabIndex = 37;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.UseVisualStyleBackColor = false;
            this.insuranceButton.Visible = false;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(5, 107);
            this.betTextBox.Mask = "$99999";
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.PromptChar = ' ';
            this.betTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.betTextBox.Size = new System.Drawing.Size(132, 20);
            this.betTextBox.TabIndex = 49;
            this.betTextBox.Click += new System.EventHandler(this.betTextBox_Click);
            // 
            // player1CurrentTotal
            // 
            this.player1CurrentTotal.AutoSize = true;
            this.player1CurrentTotal.Location = new System.Drawing.Point(16, 293);
            this.player1CurrentTotal.Name = "player1CurrentTotal";
            this.player1CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player1CurrentTotal.TabIndex = 37;
            this.player1CurrentTotal.Text = "Current Total: ";
            // 
            // player2CurrentTotal
            // 
            this.player2CurrentTotal.AutoSize = true;
            this.player2CurrentTotal.Location = new System.Drawing.Point(284, 293);
            this.player2CurrentTotal.Name = "player2CurrentTotal";
            this.player2CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player2CurrentTotal.TabIndex = 38;
            this.player2CurrentTotal.Text = "Current Total: ";
            // 
            // player3CurrentTotal
            // 
            this.player3CurrentTotal.AutoSize = true;
            this.player3CurrentTotal.Location = new System.Drawing.Point(560, 293);
            this.player3CurrentTotal.Name = "player3CurrentTotal";
            this.player3CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player3CurrentTotal.TabIndex = 39;
            this.player3CurrentTotal.Text = "Current Total: ";
            // 
            // player1CurrentMoneyLabel
            // 
            this.player1CurrentMoneyLabel.AutoSize = true;
            this.player1CurrentMoneyLabel.Location = new System.Drawing.Point(16, 309);
            this.player1CurrentMoneyLabel.Name = "player1CurrentMoneyLabel";
            this.player1CurrentMoneyLabel.Size = new System.Drawing.Size(79, 13);
            this.player1CurrentMoneyLabel.TabIndex = 40;
            this.player1CurrentMoneyLabel.Text = "Current Money:";
            // 
            // player2CurrentMoneyLabel
            // 
            this.player2CurrentMoneyLabel.AutoSize = true;
            this.player2CurrentMoneyLabel.Location = new System.Drawing.Point(284, 309);
            this.player2CurrentMoneyLabel.Name = "player2CurrentMoneyLabel";
            this.player2CurrentMoneyLabel.Size = new System.Drawing.Size(79, 13);
            this.player2CurrentMoneyLabel.TabIndex = 41;
            this.player2CurrentMoneyLabel.Text = "Current Money:";
            // 
            // player3CurrentMoneyLabel
            // 
            this.player3CurrentMoneyLabel.AutoSize = true;
            this.player3CurrentMoneyLabel.Location = new System.Drawing.Point(560, 309);
            this.player3CurrentMoneyLabel.Name = "player3CurrentMoneyLabel";
            this.player3CurrentMoneyLabel.Size = new System.Drawing.Size(79, 13);
            this.player3CurrentMoneyLabel.TabIndex = 42;
            this.player3CurrentMoneyLabel.Text = "Current Money:";
            // 
            // player1BetLabel
            // 
            this.player1BetLabel.AutoSize = true;
            this.player1BetLabel.Location = new System.Drawing.Point(16, 277);
            this.player1BetLabel.Name = "player1BetLabel";
            this.player1BetLabel.Size = new System.Drawing.Size(63, 13);
            this.player1BetLabel.TabIndex = 43;
            this.player1BetLabel.Text = "Current Bet:";
            // 
            // player2BetLabel
            // 
            this.player2BetLabel.AutoSize = true;
            this.player2BetLabel.Location = new System.Drawing.Point(284, 277);
            this.player2BetLabel.Name = "player2BetLabel";
            this.player2BetLabel.Size = new System.Drawing.Size(63, 13);
            this.player2BetLabel.TabIndex = 44;
            this.player2BetLabel.Text = "Current Bet:";
            // 
            // player3BetLabel
            // 
            this.player3BetLabel.AutoSize = true;
            this.player3BetLabel.Location = new System.Drawing.Point(560, 277);
            this.player3BetLabel.Name = "player3BetLabel";
            this.player3BetLabel.Size = new System.Drawing.Size(63, 13);
            this.player3BetLabel.TabIndex = 45;
            this.player3BetLabel.Text = "Current Bet:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(880, 339);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 46;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(777, 20);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(13, 13);
            this.turnLabel.TabIndex = 47;
            this.turnLabel.Text = "0";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(325, 86);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 39);
            this.resultLabel.TabIndex = 48;
            // 
            // turnLabelPart1
            // 
            this.turnLabelPart1.AutoSize = true;
            this.turnLabelPart1.Location = new System.Drawing.Point(740, 20);
            this.turnLabelPart1.Name = "turnLabelPart1";
            this.turnLabelPart1.Size = new System.Drawing.Size(36, 13);
            this.turnLabelPart1.TabIndex = 49;
            this.turnLabelPart1.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(787, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "\'s Turn";
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1042, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turnLabelPart1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.player3BetLabel);
            this.Controls.Add(this.player2BetLabel);
            this.Controls.Add(this.player1BetLabel);
            this.Controls.Add(this.player3CurrentMoneyLabel);
            this.Controls.Add(this.player2CurrentMoneyLabel);
            this.Controls.Add(this.player1CurrentMoneyLabel);
            this.Controls.Add(this.player3CurrentTotal);
            this.Controls.Add(this.player2CurrentTotal);
            this.Controls.Add(this.player1CurrentTotal);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.dealerVisableTotalLabel);
            this.Controls.Add(this.dealerCardLabel);
            this.Name = "frmGameBoard";
            this.Text = "frmGameBoard";
            this.Load += new System.EventHandler(this.frmGameBoard_Load);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerCardLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        internal System.Windows.Forms.TextBox adjustMoneyTextBox;
        internal System.Windows.Forms.Button adjustMoneyButton;
        internal System.Windows.Forms.Button betButton;
        internal System.Windows.Forms.Button hitButton;
        internal System.Windows.Forms.Button standButton;
        internal System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Label player1CurrentTotal;
        private System.Windows.Forms.Label player2CurrentTotal;
        private System.Windows.Forms.Label player3CurrentTotal;
        private System.Windows.Forms.Label player1CurrentMoneyLabel;
        private System.Windows.Forms.Label player2CurrentMoneyLabel;
        private System.Windows.Forms.Label player3CurrentMoneyLabel;
        private System.Windows.Forms.Label player1BetLabel;
        private System.Windows.Forms.Label player2BetLabel;
        private System.Windows.Forms.Label player3BetLabel;
        private System.Windows.Forms.Label errorLabel;
        internal System.Windows.Forms.Label dealerVisableTotalLabel;
        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.MaskedTextBox betTextBox;
        private System.Windows.Forms.Label turnLabelPart1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label turnLabel;
    }
}