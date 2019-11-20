namespace BlackJackApplication
{
    partial class frmGameLobby
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
            this.lobbyLabel = new System.Windows.Forms.Label();
            this.gameIDLabel = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.p3Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joinGameButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lobbyLabel
            // 
            this.lobbyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lobbyLabel.AutoSize = true;
            this.lobbyLabel.Font = new System.Drawing.Font("Stencil", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobbyLabel.Location = new System.Drawing.Point(228, 40);
            this.lobbyLabel.Name = "lobbyLabel";
            this.lobbyLabel.Size = new System.Drawing.Size(344, 111);
            this.lobbyLabel.TabIndex = 2;
            this.lobbyLabel.Text = "Lobby";
            // 
            // gameIDLabel
            // 
            this.gameIDLabel.AutoSize = true;
            this.gameIDLabel.Location = new System.Drawing.Point(13, 13);
            this.gameIDLabel.Name = "gameIDLabel";
            this.gameIDLabel.Size = new System.Drawing.Size(0, 13);
            this.gameIDLabel.TabIndex = 3;
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Location = new System.Drawing.Point(378, 176);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(45, 13);
            this.p1Label.TabIndex = 4;
            this.p1Label.Text = "Player 1";
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Location = new System.Drawing.Point(378, 200);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(45, 13);
            this.p2Label.TabIndex = 5;
            this.p2Label.Text = "Player 2";
            // 
            // p3Label
            // 
            this.p3Label.AutoSize = true;
            this.p3Label.Location = new System.Drawing.Point(378, 224);
            this.p3Label.Name = "p3Label";
            this.p3Label.Size = new System.Drawing.Size(45, 13);
            this.p3Label.TabIndex = 6;
            this.p3Label.Text = "Player 3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Game ID:";
            // 
            // joinGameButton
            // 
            this.joinGameButton.Location = new System.Drawing.Point(363, 279);
            this.joinGameButton.Name = "joinGameButton";
            this.joinGameButton.Size = new System.Drawing.Size(75, 23);
            this.joinGameButton.TabIndex = 9;
            this.joinGameButton.Text = "Join Game";
            this.joinGameButton.UseVisualStyleBackColor = true;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(363, 313);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // frmGameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.joinGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.p3Label);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.gameIDLabel);
            this.Controls.Add(this.lobbyLabel);
            this.Name = "frmGameLobby";
            this.Text = "frmGameLobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lobbyLabel;
        private System.Windows.Forms.Label gameIDLabel;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label p3Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button joinGameButton;
        private System.Windows.Forms.Button startGameButton;
    }
}