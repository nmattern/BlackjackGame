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
            this.label3 = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.dealerBetDescriptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.playerTotalLabel = new System.Windows.Forms.Label();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.hitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.standButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.continueButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.betButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1141, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(1241, 598);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(40, 17);
            this.currentMoneyLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(1241, 625);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(24, 17);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // dealerBetDescriptionLabel
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Total:";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Location = new System.Drawing.Point(713, 265);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Location = new System.Drawing.Point(713, 538);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.playerTotalLabel.TabIndex = 18;
            this.playerTotalLabel.Text = "0";
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(1145, 558);
            this.betTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(131, 22);
            this.betTextBox.TabIndex = 25;
            this.betTextBox.Text = "Enter Bet: ";
            this.betTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.betTextBox_MouseClick);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(1146, 255);
            this.hitButton.Name = "hitButton";
            this.hitButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.hitButton.Size = new System.Drawing.Size(130, 48);
            this.hitButton.TabIndex = 26;
            this.hitButton.Values.Text = "Hit";
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(1146, 328);
            this.standButton.Name = "standButton";
            this.standButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.standButton.Size = new System.Drawing.Size(130, 48);
            this.standButton.TabIndex = 27;
            this.standButton.Values.Text = "Stand";
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(1147, 403);
            this.continueButton.Name = "continueButton";
            this.continueButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.continueButton.Size = new System.Drawing.Size(130, 48);
            this.continueButton.TabIndex = 28;
            this.continueButton.Values.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(1148, 475);
            this.betButton.Name = "betButton";
            this.betButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.betButton.Size = new System.Drawing.Size(130, 48);
            this.betButton.TabIndex = 29;
            this.betButton.Values.Text = "Bet";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(324, 357);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 95);
            this.endLabel.TabIndex = 30;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adjustMoneyTextBox
            // 
            this.adjustMoneyTextBox.Location = new System.Drawing.Point(11, 453);
            this.adjustMoneyTextBox.Name = "adjustMoneyTextBox";
            this.adjustMoneyTextBox.Size = new System.Drawing.Size(127, 20);
            this.adjustMoneyTextBox.TabIndex = 27;
            this.adjustMoneyTextBox.Text = "Enter Value: ";
            this.adjustMoneyTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adjustMoneyTextBox_MouseClick);
            this.adjustMoneyTextBox.TextChanged += new System.EventHandler(this.adjustMoneyTextBox_TextChanged);
            // 
            // adjustMoneyButton
            // 
            this.adjustMoneyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.adjustMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustMoneyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adjustMoneyButton.Location = new System.Drawing.Point(11, 394);
            this.adjustMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(129, 39);
            this.adjustMoneyButton.TabIndex = 26;
            this.adjustMoneyButton.Text = "Adjust Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = false;
            this.adjustMoneyButton.Click += new System.EventHandler(this.adjustMoneyButton_Click);
            // 
            // adjustMoneyStatusLabel
            // 
            this.adjustMoneyStatusLabel.AutoSize = true;
            this.adjustMoneyStatusLabel.Location = new System.Drawing.Point(11, 486);
            this.adjustMoneyStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adjustMoneyStatusLabel.Name = "adjustMoneyStatusLabel";
            this.adjustMoneyStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.adjustMoneyStatusLabel.TabIndex = 28;
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.playerTotalLabel);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dealerBetDescriptionLabel);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.label3);
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
        internal System.Windows.Forms.Label dealerTotalLabel;
        internal System.Windows.Forms.Label playerTotalLabel;
        internal System.Windows.Forms.TextBox betTextBox;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton hitButton;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton standButton;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton continueButton;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton betButton;
        internal System.Windows.Forms.Label endLabel;
    }
}

