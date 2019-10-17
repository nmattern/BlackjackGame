namespace BlackJackApplication
{
    partial class Form1
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
            this.dealerCardTable = new System.Windows.Forms.TableLayoutPanel();
            this.playerCardTable = new System.Windows.Forms.TableLayoutPanel();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Money:";
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Location = new System.Drawing.Point(729, 9);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(32, 17);
            this.currentMoneyLabel.TabIndex = 1;
            this.currentMoneyLabel.Text = "100";
            // 
            // dealerCardTable
            // 
            this.dealerCardTable.ColumnCount = 9;
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.dealerCardTable.Location = new System.Drawing.Point(135, 12);
            this.dealerCardTable.Name = "dealerCardTable";
            this.dealerCardTable.RowCount = 1;
            this.dealerCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dealerCardTable.Size = new System.Drawing.Size(477, 96);
            this.dealerCardTable.TabIndex = 2;
            // 
            // playerCardTable
            // 
            this.playerCardTable.ColumnCount = 9;
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.playerCardTable.Location = new System.Drawing.Point(135, 342);
            this.playerCardTable.Name = "playerCardTable";
            this.playerCardTable.RowCount = 1;
            this.playerCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playerCardTable.Size = new System.Drawing.Size(477, 96);
            this.playerCardTable.TabIndex = 3;
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(650, 163);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(100, 48);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(650, 240);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(100, 48);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Bet:";
            // 
            // minus10Button
            // 
            this.minus10Button.Location = new System.Drawing.Point(19, 163);
            this.minus10Button.Name = "minus10Button";
            this.minus10Button.Size = new System.Drawing.Size(47, 34);
            this.minus10Button.TabIndex = 7;
            this.minus10Button.Text = "-10";
            this.minus10Button.UseVisualStyleBackColor = true;
            // 
            // add10Button
            // 
            this.add10Button.Location = new System.Drawing.Point(72, 163);
            this.add10Button.Name = "add10Button";
            this.add10Button.Size = new System.Drawing.Size(47, 34);
            this.add10Button.TabIndex = 8;
            this.add10Button.Text = "+10";
            this.add10Button.UseVisualStyleBackColor = true;
            // 
            // minus20Button
            // 
            this.minus20Button.Location = new System.Drawing.Point(19, 203);
            this.minus20Button.Name = "minus20Button";
            this.minus20Button.Size = new System.Drawing.Size(47, 34);
            this.minus20Button.TabIndex = 9;
            this.minus20Button.Text = "-20";
            this.minus20Button.UseVisualStyleBackColor = true;
            // 
            // add20Button
            // 
            this.add20Button.Location = new System.Drawing.Point(72, 203);
            this.add20Button.Name = "add20Button";
            this.add20Button.Size = new System.Drawing.Size(47, 34);
            this.add20Button.TabIndex = 10;
            this.add20Button.Text = "+20";
            this.add20Button.UseVisualStyleBackColor = true;
            // 
            // minus50Button
            // 
            this.minus50Button.Location = new System.Drawing.Point(19, 243);
            this.minus50Button.Name = "minus50Button";
            this.minus50Button.Size = new System.Drawing.Size(47, 34);
            this.minus50Button.TabIndex = 11;
            this.minus50Button.Text = "-50";
            this.minus50Button.UseVisualStyleBackColor = true;
            // 
            // add50Button
            // 
            this.add50Button.Location = new System.Drawing.Point(71, 243);
            this.add50Button.Name = "add50Button";
            this.add50Button.Size = new System.Drawing.Size(47, 34);
            this.add50Button.TabIndex = 12;
            this.add50Button.Text = "+50";
            this.add50Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Bet:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(729, 36);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(24, 17);
            this.betLabel.TabIndex = 14;
            this.betLabel.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Total:";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Location = new System.Drawing.Point(435, 120);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Location = new System.Drawing.Point(435, 313);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(16, 17);
            this.playerTotalLabel.TabIndex = 18;
            this.playerTotalLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.playerCardTable);
            this.Controls.Add(this.dealerCardTable);
            this.Controls.Add(this.currentMoneyLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentMoneyLabel;
        private System.Windows.Forms.TableLayoutPanel dealerCardTable;
        private System.Windows.Forms.TableLayoutPanel playerCardTable;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minus10Button;
        private System.Windows.Forms.Button add10Button;
        private System.Windows.Forms.Button minus20Button;
        private System.Windows.Forms.Button add20Button;
        private System.Windows.Forms.Button minus50Button;
        private System.Windows.Forms.Button add50Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dealerTotalLabel;
        private System.Windows.Forms.Label playerTotalLabel;
    }
}

