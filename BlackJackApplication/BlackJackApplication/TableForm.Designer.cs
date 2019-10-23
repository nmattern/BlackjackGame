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
            this.label2 = new System.Windows.Forms.Label();
            this.minus10Button = new System.Windows.Forms.Button();
            this.add10Button = new System.Windows.Forms.Button();
            this.minus20Button = new System.Windows.Forms.Button();
            this.add20Button = new System.Windows.Forms.Button();
            this.minus50Button = new System.Windows.Forms.Button();
            this.add50Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.playerTotalLabel = new System.Windows.Forms.Label();
            this.playerHandFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dealerHandFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.endLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(939, 453);
            this.currentMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(25, 13);
            this.currentMoneyLabel.TabIndex = 1;
            this.currentMoneyLabel.Text = "100";
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(859, 243);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 39);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(859, 306);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 39);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Bet:";
            // 
            // minus10Button
            // 
            this.minus10Button.Location = new System.Drawing.Point(14, 132);
            this.minus10Button.Margin = new System.Windows.Forms.Padding(2);
            this.minus10Button.Name = "minus10Button";
            this.minus10Button.Size = new System.Drawing.Size(35, 28);
            this.minus10Button.TabIndex = 7;
            this.minus10Button.Text = "-10";
            this.minus10Button.UseVisualStyleBackColor = true;
            // 
            // add10Button
            // 
            this.add10Button.Location = new System.Drawing.Point(54, 132);
            this.add10Button.Margin = new System.Windows.Forms.Padding(2);
            this.add10Button.Name = "add10Button";
            this.add10Button.Size = new System.Drawing.Size(35, 28);
            this.add10Button.TabIndex = 8;
            this.add10Button.Text = "+10";
            this.add10Button.UseVisualStyleBackColor = true;
            // 
            // minus20Button
            // 
            this.minus20Button.Location = new System.Drawing.Point(14, 165);
            this.minus20Button.Margin = new System.Windows.Forms.Padding(2);
            this.minus20Button.Name = "minus20Button";
            this.minus20Button.Size = new System.Drawing.Size(35, 28);
            this.minus20Button.TabIndex = 9;
            this.minus20Button.Text = "-20";
            this.minus20Button.UseVisualStyleBackColor = true;
            // 
            // add20Button
            // 
            this.add20Button.Location = new System.Drawing.Point(54, 165);
            this.add20Button.Margin = new System.Windows.Forms.Padding(2);
            this.add20Button.Name = "add20Button";
            this.add20Button.Size = new System.Drawing.Size(35, 28);
            this.add20Button.TabIndex = 10;
            this.add20Button.Text = "+20";
            this.add20Button.UseVisualStyleBackColor = true;
            // 
            // minus50Button
            // 
            this.minus50Button.Location = new System.Drawing.Point(14, 197);
            this.minus50Button.Margin = new System.Windows.Forms.Padding(2);
            this.minus50Button.Name = "minus50Button";
            this.minus50Button.Size = new System.Drawing.Size(35, 28);
            this.minus50Button.TabIndex = 11;
            this.minus50Button.Text = "-50";
            this.minus50Button.UseVisualStyleBackColor = true;
            // 
            // add50Button
            // 
            this.add50Button.Location = new System.Drawing.Point(53, 197);
            this.add50Button.Margin = new System.Windows.Forms.Padding(2);
            this.add50Button.Name = "add50Button";
            this.add50Button.Size = new System.Drawing.Size(35, 28);
            this.add50Button.TabIndex = 12;
            this.add50Button.Text = "+50";
            this.add50Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 475);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(939, 475);
            this.betLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(19, 13);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current Total:";
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
            this.endLabel.Location = new System.Drawing.Point(365, 287);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 76);
            this.endLabel.TabIndex = 22;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(859, 371);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 39);
            this.continueButton.TabIndex = 23;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.dealerHandFlowLayoutPanel);
            this.Controls.Add(this.playerHandFlowLayoutPanel);
            this.Controls.Add(this.playerTotalLabel);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add50Button);
            this.Controls.Add(this.minus50Button);
            this.Controls.Add(this.add20Button);
            this.Controls.Add(this.minus20Button);
            this.Controls.Add(this.add10Button);
            this.Controls.Add(this.minus10Button);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label betLabel;
        internal System.Windows.Forms.Label currentMoneyLabel;
        internal System.Windows.Forms.Button hitButton;
        internal System.Windows.Forms.Button standButton;
        internal System.Windows.Forms.FlowLayoutPanel playerHandFlowLayoutPanel;
        internal System.Windows.Forms.Button minus10Button;
        internal System.Windows.Forms.Button add10Button;
        internal System.Windows.Forms.Button minus20Button;
        internal System.Windows.Forms.Button add20Button;
        internal System.Windows.Forms.Button minus50Button;
        internal System.Windows.Forms.Button add50Button;
        internal System.Windows.Forms.Label dealerTotalLabel;
        internal System.Windows.Forms.Label playerTotalLabel;
        internal System.Windows.Forms.FlowLayoutPanel dealerHandFlowLayoutPanel;
        internal System.Windows.Forms.Label endLabel;
        internal System.Windows.Forms.Button continueButton;
    }
}

