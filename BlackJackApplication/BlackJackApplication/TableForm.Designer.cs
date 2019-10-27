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
            this.playerHandFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dealerHandFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.endLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.lockBetButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
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
            this.currentMoneyLabel.Size = new System.Drawing.Size(0, 17);
            this.currentMoneyLabel.TabIndex = 1;
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.ForestGreen;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hitButton.Location = new System.Drawing.Point(1145, 260);
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
            this.standButton.BackColor = System.Drawing.Color.ForestGreen;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.SystemColors.Control;
            this.standButton.Location = new System.Drawing.Point(1145, 335);
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
            this.label3.Location = new System.Drawing.Point(1141, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(1231, 625);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(24, 17);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // dealerBetDescriptionLabel
            // 
            this.dealerBetDescriptionLabel.AutoSize = true;
            this.dealerBetDescriptionLabel.Location = new System.Drawing.Point(557, 265);
            this.dealerBetDescriptionLabel.Name = "dealerBetDescriptionLabel";
            this.dealerBetDescriptionLabel.Size = new System.Drawing.Size(140, 17);
            this.dealerBetDescriptionLabel.TabIndex = 15;
            this.dealerBetDescriptionLabel.Text = "Current Visible Total:";
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
            // playerHandFlowLayoutPanel
            // 
            this.playerHandFlowLayoutPanel.AutoSize = true;
            this.playerHandFlowLayoutPanel.Location = new System.Drawing.Point(192, 558);
            this.playerHandFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.playerHandFlowLayoutPanel.Name = "playerHandFlowLayoutPanel";
            this.playerHandFlowLayoutPanel.Size = new System.Drawing.Size(908, 241);
            this.playerHandFlowLayoutPanel.TabIndex = 20;
            // 
            // dealerHandFlowLayoutPanel
            // 
            this.dealerHandFlowLayoutPanel.AutoSize = true;
            this.dealerHandFlowLayoutPanel.Location = new System.Drawing.Point(175, 15);
            this.dealerHandFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dealerHandFlowLayoutPanel.Name = "dealerHandFlowLayoutPanel";
            this.dealerHandFlowLayoutPanel.Size = new System.Drawing.Size(908, 241);
            this.dealerHandFlowLayoutPanel.TabIndex = 21;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(175, 369);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 95);
            this.endLabel.TabIndex = 22;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.ForestGreen;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(1145, 410);
            this.continueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(132, 48);
            this.continueButton.TabIndex = 23;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // lockBetButton
            // 
            this.lockBetButton.BackColor = System.Drawing.Color.ForestGreen;
            this.lockBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lockBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockBetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.lockBetButton.Location = new System.Drawing.Point(1145, 485);
            this.lockBetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lockBetButton.Name = "lockBetButton";
            this.lockBetButton.Size = new System.Drawing.Size(132, 48);
            this.lockBetButton.TabIndex = 24;
            this.lockBetButton.Text = "Bet";
            this.lockBetButton.UseVisualStyleBackColor = false;
            this.lockBetButton.Click += new System.EventHandler(this.lockBetButton_Click);
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
            this.betTextBox.TextChanged += new System.EventHandler(this.betTextBox_TextChanged);
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1332, 814);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.lockBetButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.dealerHandFlowLayoutPanel);
            this.Controls.Add(this.playerHandFlowLayoutPanel);
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
        internal System.Windows.Forms.FlowLayoutPanel playerHandFlowLayoutPanel;
        internal System.Windows.Forms.Label dealerTotalLabel;
        internal System.Windows.Forms.Label playerTotalLabel;
        internal System.Windows.Forms.FlowLayoutPanel dealerHandFlowLayoutPanel;
        internal System.Windows.Forms.Label endLabel;
        internal System.Windows.Forms.Button continueButton;
        internal System.Windows.Forms.Button lockBetButton;
        internal System.Windows.Forms.TextBox betTextBox;
        internal System.Windows.Forms.Label dealerBetDescriptionLabel;
    }
}

