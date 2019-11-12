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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(826, 80);
            this.currentMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(0, 13);
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
            this.hitButton.Location = new System.Drawing.Point(432, 330);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(99, 39);
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
            this.standButton.Location = new System.Drawing.Point(580, 330);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(99, 39);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(807, 182);
            this.betLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(19, 13);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // dealerBetDescriptionLabel
            // 
            this.dealerBetDescriptionLabel.AutoSize = true;
            this.dealerBetDescriptionLabel.Location = new System.Drawing.Point(43, 56);
            this.dealerBetDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerBetDescriptionLabel.Name = "dealerBetDescriptionLabel";
            this.dealerBetDescriptionLabel.Size = new System.Drawing.Size(104, 13);
            this.dealerBetDescriptionLabel.TabIndex = 15;
            this.dealerBetDescriptionLabel.Text = "Current Visible Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Total:";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Location = new System.Drawing.Point(168, 56);
            this.dealerTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Location = new System.Drawing.Point(587, 56);
            this.playerTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.playerTotalLabel.TabIndex = 18;
            this.playerTotalLabel.Text = "0";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(224, 313);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 76);
            this.endLabel.TabIndex = 22;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(67)))), ((int)(((byte)(157)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(446, 412);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(99, 39);
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
            this.lockBetButton.Location = new System.Drawing.Point(869, 209);
            this.lockBetButton.Margin = new System.Windows.Forms.Padding(2);
            this.lockBetButton.Name = "lockBetButton";
            this.lockBetButton.Size = new System.Drawing.Size(135, 39);
            this.lockBetButton.TabIndex = 24;
            this.lockBetButton.Text = "Bet";
            this.lockBetButton.UseVisualStyleBackColor = false;
            this.lockBetButton.EnabledChanged += new System.EventHandler(this.lockBetButton_EnabledChanged);
            this.lockBetButton.Click += new System.EventHandler(this.lockBetButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(869, 175);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(135, 20);
            this.betTextBox.TabIndex = 25;
            this.betTextBox.Text = "Enter Bet: ";
            this.betTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.betTextBox_MouseClick);
            this.betTextBox.TextChanged += new System.EventHandler(this.betTextBox_TextChanged);
            // 
            // adjustMoneyTextBox
            // 
            this.adjustMoneyTextBox.Location = new System.Drawing.Point(868, 73);
            this.adjustMoneyTextBox.Name = "adjustMoneyTextBox";
            this.adjustMoneyTextBox.Size = new System.Drawing.Size(136, 20);
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
            this.adjustMoneyButton.Location = new System.Drawing.Point(869, 100);
            this.adjustMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(136, 54);
            this.adjustMoneyButton.TabIndex = 26;
            this.adjustMoneyButton.Text = "Adjust Current Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = false;
            this.adjustMoneyButton.Click += new System.EventHandler(this.adjustMoneyButton_Click);
            // 
            // adjustMoneyStatusLabel
            // 
            this.adjustMoneyStatusLabel.AutoSize = true;
            this.adjustMoneyStatusLabel.Location = new System.Drawing.Point(815, 50);
            this.adjustMoneyStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adjustMoneyStatusLabel.Name = "adjustMoneyStatusLabel";
            this.adjustMoneyStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.adjustMoneyStatusLabel.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dealer Cards:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Player Cards:";
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1015, 480);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

