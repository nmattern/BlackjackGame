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
            this.label1.Location = new System.Drawing.Point(856, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(931, 486);
            this.currentMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(31, 13);
            this.currentMoneyLabel.TabIndex = 1;
            this.currentMoneyLabel.Text = "1000";
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.ForestGreen;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hitButton.Location = new System.Drawing.Point(859, 211);
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
            this.standButton.BackColor = System.Drawing.Color.ForestGreen;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.SystemColors.Control;
            this.standButton.Location = new System.Drawing.Point(859, 272);
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
            this.label3.Location = new System.Drawing.Point(856, 508);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(931, 508);
            this.betLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(19, 13);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // dealerBetDescriptionLabel
            // 
            this.dealerBetDescriptionLabel.AutoSize = true;
            this.dealerBetDescriptionLabel.Location = new System.Drawing.Point(418, 215);
            this.dealerBetDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerBetDescriptionLabel.Name = "dealerBetDescriptionLabel";
            this.dealerBetDescriptionLabel.Size = new System.Drawing.Size(104, 13);
            this.dealerBetDescriptionLabel.TabIndex = 15;
            this.dealerBetDescriptionLabel.Text = "Current Visible Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Total:";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Location = new System.Drawing.Point(535, 215);
            this.dealerTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Location = new System.Drawing.Point(535, 437);
            this.playerTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.playerTotalLabel.TabIndex = 18;
            this.playerTotalLabel.Text = "0";
            // 
            // playerHandFlowLayoutPanel
            // 
            this.playerHandFlowLayoutPanel.AutoSize = true;
            this.playerHandFlowLayoutPanel.Location = new System.Drawing.Point(144, 453);
            this.playerHandFlowLayoutPanel.Name = "playerHandFlowLayoutPanel";
            this.playerHandFlowLayoutPanel.Size = new System.Drawing.Size(681, 196);
            this.playerHandFlowLayoutPanel.TabIndex = 20;
            // 
            // dealerHandFlowLayoutPanel
            // 
            this.dealerHandFlowLayoutPanel.AutoSize = true;
            this.dealerHandFlowLayoutPanel.Location = new System.Drawing.Point(131, 12);
            this.dealerHandFlowLayoutPanel.Name = "dealerHandFlowLayoutPanel";
            this.dealerHandFlowLayoutPanel.Size = new System.Drawing.Size(681, 196);
            this.dealerHandFlowLayoutPanel.TabIndex = 21;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(131, 300);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 76);
            this.endLabel.TabIndex = 22;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.ForestGreen;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.Control;
            this.continueButton.Location = new System.Drawing.Point(859, 333);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(99, 39);
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
            this.lockBetButton.Location = new System.Drawing.Point(859, 394);
            this.lockBetButton.Margin = new System.Windows.Forms.Padding(2);
            this.lockBetButton.Name = "lockBetButton";
            this.lockBetButton.Size = new System.Drawing.Size(99, 39);
            this.lockBetButton.TabIndex = 24;
            this.lockBetButton.Text = "Bet";
            this.lockBetButton.UseVisualStyleBackColor = false;
            this.lockBetButton.Click += new System.EventHandler(this.lockBetButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(859, 453);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(99, 20);
            this.betTextBox.TabIndex = 25;
            this.betTextBox.Text = "Enter Bet: ";
            this.betTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.betTextBox_MouseClick);
            this.betTextBox.TextChanged += new System.EventHandler(this.betTextBox_TextChanged);
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
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

