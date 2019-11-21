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
            this.currentMoneyLabel = new System.Windows.Forms.Label();
            this.adjustMoneyTextBox = new System.Windows.Forms.TextBox();
            this.adjustMoneyButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.betButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.player1CurrentTotal = new System.Windows.Forms.Label();
            this.player2CurrentTotal = new System.Windows.Forms.Label();
            this.player3CurrentTotal = new System.Windows.Forms.Label();
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
            this.dealerVisableTotalLabel.Location = new System.Drawing.Point(16, 37);
            this.dealerVisableTotalLabel.Name = "dealerVisableTotalLabel";
            this.dealerVisableTotalLabel.Size = new System.Drawing.Size(111, 13);
            this.dealerVisableTotalLabel.TabIndex = 1;
            this.dealerVisableTotalLabel.Text = "Current Visable Total: ";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(12, 230);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(70, 24);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Cards:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(286, 230);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(70, 24);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Cards:";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Label.Location = new System.Drawing.Point(560, 230);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(70, 24);
            this.player3Label.TabIndex = 4;
            this.player3Label.Text = "Cards:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(9, 175);
            this.currentMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(79, 13);
            this.currentMoneyLabel.TabIndex = 5;
            this.currentMoneyLabel.Text = "Current Money:";
            // 
            // adjustMoneyTextBox
            // 
            this.adjustMoneyTextBox.Location = new System.Drawing.Point(5, 17);
            this.adjustMoneyTextBox.Name = "adjustMoneyTextBox";
            this.adjustMoneyTextBox.Size = new System.Drawing.Size(133, 20);
            this.adjustMoneyTextBox.TabIndex = 28;
            this.adjustMoneyTextBox.Text = "Enter New Current Money: ";
            // 
            // adjustMoneyButton
            // 
            this.adjustMoneyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.adjustMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustMoneyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adjustMoneyButton.Location = new System.Drawing.Point(5, 42);
            this.adjustMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(134, 54);
            this.adjustMoneyButton.TabIndex = 29;
            this.adjustMoneyButton.Text = "Adjust Current Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = false;
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(6, 101);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(133, 20);
            this.betTextBox.TabIndex = 31;
            this.betTextBox.Text = "Enter Bet: ";
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.SystemColors.Control;
            this.betButton.Location = new System.Drawing.Point(6, 126);
            this.betButton.Margin = new System.Windows.Forms.Padding(2);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(133, 39);
            this.betButton.TabIndex = 32;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = false;
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Red;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hitButton.Location = new System.Drawing.Point(5, 199);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(133, 39);
            this.hitButton.TabIndex = 33;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.SystemColors.Control;
            this.standButton.Location = new System.Drawing.Point(6, 251);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(133, 39);
            this.standButton.TabIndex = 34;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(6, 303);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(133, 39);
            this.continueButton.TabIndex = 35;
            this.continueButton.Text = "New Hand";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.adjustMoneyTextBox);
            this.controlsGroupBox.Controls.Add(this.continueButton);
            this.controlsGroupBox.Controls.Add(this.adjustMoneyButton);
            this.controlsGroupBox.Controls.Add(this.standButton);
            this.controlsGroupBox.Controls.Add(this.betTextBox);
            this.controlsGroupBox.Controls.Add(this.hitButton);
            this.controlsGroupBox.Controls.Add(this.betButton);
            this.controlsGroupBox.Controls.Add(this.currentMoneyLabel);
            this.controlsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsGroupBox.Location = new System.Drawing.Point(806, 9);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(148, 357);
            this.controlsGroupBox.TabIndex = 36;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // player1CurrentTotal
            // 
            this.player1CurrentTotal.AutoSize = true;
            this.player1CurrentTotal.Location = new System.Drawing.Point(16, 255);
            this.player1CurrentTotal.Name = "player1CurrentTotal";
            this.player1CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player1CurrentTotal.TabIndex = 37;
            this.player1CurrentTotal.Text = "Current Total: ";
            // 
            // player2CurrentTotal
            // 
            this.player2CurrentTotal.AutoSize = true;
            this.player2CurrentTotal.Location = new System.Drawing.Point(287, 255);
            this.player2CurrentTotal.Name = "player2CurrentTotal";
            this.player2CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player2CurrentTotal.TabIndex = 38;
            this.player2CurrentTotal.Text = "Current Total: ";
            // 
            // player3CurrentTotal
            // 
            this.player3CurrentTotal.AutoSize = true;
            this.player3CurrentTotal.Location = new System.Drawing.Point(561, 255);
            this.player3CurrentTotal.Name = "player3CurrentTotal";
            this.player3CurrentTotal.Size = new System.Drawing.Size(74, 13);
            this.player3CurrentTotal.TabIndex = 39;
            this.player3CurrentTotal.Text = "Current Total: ";
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(966, 470);
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
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerCardLabel;
        private System.Windows.Forms.Label dealerVisableTotalLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label currentMoneyLabel;
        internal System.Windows.Forms.TextBox adjustMoneyTextBox;
        internal System.Windows.Forms.Button adjustMoneyButton;
        internal System.Windows.Forms.TextBox betTextBox;
        internal System.Windows.Forms.Button betButton;
        internal System.Windows.Forms.Button hitButton;
        internal System.Windows.Forms.Button standButton;
        internal System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Label player1CurrentTotal;
        private System.Windows.Forms.Label player2CurrentTotal;
        private System.Windows.Forms.Label player3CurrentTotal;
    }
}