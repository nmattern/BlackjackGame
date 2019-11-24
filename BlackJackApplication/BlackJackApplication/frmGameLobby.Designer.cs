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
            this.components = new System.ComponentModel.Container();
            this.lobbyLabel = new System.Windows.Forms.Label();
            this.gameIDLabel = new System.Windows.Forms.Label();
            this.Player2PlayerListLabel = new System.Windows.Forms.Label();
            this.Player3PlayerListLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joinOnlineGameButton = new System.Windows.Forms.Button();
            this.startLocalGameButton = new System.Windows.Forms.Button();
            this.SinglePlayerTitleLabel = new System.Windows.Forms.Label();
            this.MultiPlayerTitleLabel = new System.Windows.Forms.Label();
            this.createOnlineGameButton = new System.Windows.Forms.Button();
            this.PlayerListTitleLabel = new System.Windows.Forms.Label();
            this.addLocalGuestButton = new System.Windows.Forms.Button();
            this.localUserPlayerListLabel = new System.Windows.Forms.Label();
            this.setAmountLabel = new System.Windows.Forms.Label();
            this.setAmountTextBox = new System.Windows.Forms.TextBox();
            this.adjustMoneyButton = new System.Windows.Forms.Button();
            this.deleteLocalGuestButton = new System.Windows.Forms.Button();
            this.startingAmountValidLabel = new System.Windows.Forms.Label();
            this.AdjustMoneyErrorMessageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentMoneyTitleLabel = new System.Windows.Forms.Label();
            this.currentAmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.deleteLocalGameButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // Player2PlayerListLabel
            // 
            this.Player2PlayerListLabel.AutoSize = true;
            this.Player2PlayerListLabel.Location = new System.Drawing.Point(378, 238);
            this.Player2PlayerListLabel.Name = "Player2PlayerListLabel";
            this.Player2PlayerListLabel.Size = new System.Drawing.Size(45, 13);
            this.Player2PlayerListLabel.TabIndex = 5;
            this.Player2PlayerListLabel.Text = "Player 2";
            this.Player2PlayerListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Player2PlayerListLabel.Visible = false;
            // 
            // Player3PlayerListLabel
            // 
            this.Player3PlayerListLabel.AutoSize = true;
            this.Player3PlayerListLabel.Location = new System.Drawing.Point(378, 262);
            this.Player3PlayerListLabel.Name = "Player3PlayerListLabel";
            this.Player3PlayerListLabel.Size = new System.Drawing.Size(45, 13);
            this.Player3PlayerListLabel.TabIndex = 6;
            this.Player3PlayerListLabel.Text = "Player 3";
            this.Player3PlayerListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Player3PlayerListLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Game ID:";
            // 
            // joinOnlineGameButton
            // 
            this.joinOnlineGameButton.Location = new System.Drawing.Point(558, 270);
            this.joinOnlineGameButton.Name = "joinOnlineGameButton";
            this.joinOnlineGameButton.Size = new System.Drawing.Size(105, 23);
            this.joinOnlineGameButton.TabIndex = 9;
            this.joinOnlineGameButton.Text = "Join Online Game";
            this.joinOnlineGameButton.UseVisualStyleBackColor = true;
            this.joinOnlineGameButton.Click += new System.EventHandler(this.joinOnlineGameButton_Click);
            // 
            // startLocalGameButton
            // 
            this.startLocalGameButton.Location = new System.Drawing.Point(158, 270);
            this.startLocalGameButton.Name = "startLocalGameButton";
            this.startLocalGameButton.Size = new System.Drawing.Size(120, 23);
            this.startLocalGameButton.TabIndex = 10;
            this.startLocalGameButton.Text = "Start Local Game";
            this.startLocalGameButton.UseVisualStyleBackColor = true;
            this.startLocalGameButton.Click += new System.EventHandler(this.startLocalGameButton_Click);
            // 
            // SinglePlayerTitleLabel
            // 
            this.SinglePlayerTitleLabel.AutoSize = true;
            this.SinglePlayerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerTitleLabel.Location = new System.Drawing.Point(164, 181);
            this.SinglePlayerTitleLabel.Name = "SinglePlayerTitleLabel";
            this.SinglePlayerTitleLabel.Size = new System.Drawing.Size(114, 20);
            this.SinglePlayerTitleLabel.TabIndex = 11;
            this.SinglePlayerTitleLabel.Text = "Single-Player";
            // 
            // MultiPlayerTitleLabel
            // 
            this.MultiPlayerTitleLabel.AutoSize = true;
            this.MultiPlayerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiPlayerTitleLabel.Location = new System.Drawing.Point(533, 181);
            this.MultiPlayerTitleLabel.Name = "MultiPlayerTitleLabel";
            this.MultiPlayerTitleLabel.Size = new System.Drawing.Size(102, 20);
            this.MultiPlayerTitleLabel.TabIndex = 12;
            this.MultiPlayerTitleLabel.Text = "Multi-Player";
            // 
            // createOnlineGameButton
            // 
            this.createOnlineGameButton.Location = new System.Drawing.Point(526, 212);
            this.createOnlineGameButton.Name = "createOnlineGameButton";
            this.createOnlineGameButton.Size = new System.Drawing.Size(125, 23);
            this.createOnlineGameButton.TabIndex = 13;
            this.createOnlineGameButton.Text = "Create Online Game";
            this.createOnlineGameButton.UseVisualStyleBackColor = true;
            this.createOnlineGameButton.Click += new System.EventHandler(this.createOnlineGameButton_Click);
            // 
            // PlayerListTitleLabel
            // 
            this.PlayerListTitleLabel.AutoSize = true;
            this.PlayerListTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerListTitleLabel.Location = new System.Drawing.Point(358, 181);
            this.PlayerListTitleLabel.Name = "PlayerListTitleLabel";
            this.PlayerListTitleLabel.Size = new System.Drawing.Size(92, 20);
            this.PlayerListTitleLabel.TabIndex = 14;
            this.PlayerListTitleLabel.Text = "Player List";
            // 
            // addLocalGuestButton
            // 
            this.addLocalGuestButton.Location = new System.Drawing.Point(158, 212);
            this.addLocalGuestButton.Name = "addLocalGuestButton";
            this.addLocalGuestButton.Size = new System.Drawing.Size(120, 23);
            this.addLocalGuestButton.TabIndex = 15;
            this.addLocalGuestButton.Text = "Add Guest";
            this.addLocalGuestButton.UseVisualStyleBackColor = true;
            this.addLocalGuestButton.Click += new System.EventHandler(this.addLocalGuestButton_Click);
            // 
            // localUserPlayerListLabel
            // 
            this.localUserPlayerListLabel.AutoSize = true;
            this.localUserPlayerListLabel.Location = new System.Drawing.Point(377, 212);
            this.localUserPlayerListLabel.Name = "localUserPlayerListLabel";
            this.localUserPlayerListLabel.Size = new System.Drawing.Size(55, 13);
            this.localUserPlayerListLabel.TabIndex = 16;
            this.localUserPlayerListLabel.Text = "LocalUser";
            this.localUserPlayerListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // setAmountLabel
            // 
            this.setAmountLabel.AutoSize = true;
            this.setAmountLabel.Location = new System.Drawing.Point(8, 9);
            this.setAmountLabel.Name = "setAmountLabel";
            this.setAmountLabel.Size = new System.Drawing.Size(110, 13);
            this.setAmountLabel.TabIndex = 18;
            this.setAmountLabel.Text = "Adjust Money Amount";
            // 
            // setAmountTextBox
            // 
            this.setAmountTextBox.Location = new System.Drawing.Point(11, 29);
            this.setAmountTextBox.Name = "setAmountTextBox";
            this.setAmountTextBox.Size = new System.Drawing.Size(102, 20);
            this.setAmountTextBox.TabIndex = 17;
            this.setAmountTextBox.TextChanged += new System.EventHandler(this.setAmountTextBox_TextChanged);
            // 
            // adjustMoneyButton
            // 
            this.adjustMoneyButton.Location = new System.Drawing.Point(11, 55);
            this.adjustMoneyButton.Name = "adjustMoneyButton";
            this.adjustMoneyButton.Size = new System.Drawing.Size(107, 23);
            this.adjustMoneyButton.TabIndex = 21;
            this.adjustMoneyButton.Text = "Adjust Money";
            this.adjustMoneyButton.UseVisualStyleBackColor = true;
            this.adjustMoneyButton.Click += new System.EventHandler(this.adjustMoneyButton_Click);
            // 
            // deleteLocalGuestButton
            // 
            this.deleteLocalGuestButton.Location = new System.Drawing.Point(158, 241);
            this.deleteLocalGuestButton.Name = "deleteLocalGuestButton";
            this.deleteLocalGuestButton.Size = new System.Drawing.Size(120, 23);
            this.deleteLocalGuestButton.TabIndex = 22;
            this.deleteLocalGuestButton.Text = "Delete Guest";
            this.deleteLocalGuestButton.UseVisualStyleBackColor = true;
            this.deleteLocalGuestButton.Click += new System.EventHandler(this.deleteLocalGuestButton_Click);
            // 
            // startingAmountValidLabel
            // 
            this.startingAmountValidLabel.AutoSize = true;
            this.startingAmountValidLabel.ForeColor = System.Drawing.Color.Red;
            this.startingAmountValidLabel.Location = new System.Drawing.Point(133, 35);
            this.startingAmountValidLabel.Name = "startingAmountValidLabel";
            this.startingAmountValidLabel.Size = new System.Drawing.Size(0, 13);
            this.startingAmountValidLabel.TabIndex = 19;
            // 
            // AdjustMoneyErrorMessageLabel
            // 
            this.AdjustMoneyErrorMessageLabel.AutoSize = true;
            this.AdjustMoneyErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.AdjustMoneyErrorMessageLabel.Location = new System.Drawing.Point(132, 36);
            this.AdjustMoneyErrorMessageLabel.Name = "AdjustMoneyErrorMessageLabel";
            this.AdjustMoneyErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.AdjustMoneyErrorMessageLabel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(803, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // CurrentMoneyTitleLabel
            // 
            this.CurrentMoneyTitleLabel.AutoSize = true;
            this.CurrentMoneyTitleLabel.Location = new System.Drawing.Point(659, 9);
            this.CurrentMoneyTitleLabel.Name = "CurrentMoneyTitleLabel";
            this.CurrentMoneyTitleLabel.Size = new System.Drawing.Size(129, 13);
            this.CurrentMoneyTitleLabel.TabIndex = 24;
            this.CurrentMoneyTitleLabel.Text = "Current Amount Of Money";
            // 
            // currentAmountOfMoneyLabel
            // 
            this.currentAmountOfMoneyLabel.AutoSize = true;
            this.currentAmountOfMoneyLabel.Location = new System.Drawing.Point(659, 32);
            this.currentAmountOfMoneyLabel.Name = "currentAmountOfMoneyLabel";
            this.currentAmountOfMoneyLabel.Size = new System.Drawing.Size(13, 13);
            this.currentAmountOfMoneyLabel.TabIndex = 26;
            this.currentAmountOfMoneyLabel.Text = "0";
            // 
            // deleteLocalGameButton
            // 
            this.deleteLocalGameButton.Location = new System.Drawing.Point(158, 299);
            this.deleteLocalGameButton.Name = "deleteLocalGameButton";
            this.deleteLocalGameButton.Size = new System.Drawing.Size(120, 23);
            this.deleteLocalGameButton.TabIndex = 27;
            this.deleteLocalGameButton.Text = "Delete Local Game";
            this.deleteLocalGameButton.UseVisualStyleBackColor = true;
            this.deleteLocalGameButton.Visible = false;
            this.deleteLocalGameButton.Click += new System.EventHandler(this.deleteLocalGameButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(363, 363);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 28;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // frmGameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.deleteLocalGameButton);
            this.Controls.Add(this.currentAmountOfMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentMoneyTitleLabel);
            this.Controls.Add(this.deleteLocalGuestButton);
            this.Controls.Add(this.adjustMoneyButton);
            this.Controls.Add(this.AdjustMoneyErrorMessageLabel);
            this.Controls.Add(this.startingAmountValidLabel);
            this.Controls.Add(this.setAmountLabel);
            this.Controls.Add(this.setAmountTextBox);
            this.Controls.Add(this.localUserPlayerListLabel);
            this.Controls.Add(this.addLocalGuestButton);
            this.Controls.Add(this.PlayerListTitleLabel);
            this.Controls.Add(this.createOnlineGameButton);
            this.Controls.Add(this.MultiPlayerTitleLabel);
            this.Controls.Add(this.SinglePlayerTitleLabel);
            this.Controls.Add(this.startLocalGameButton);
            this.Controls.Add(this.joinOnlineGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Player3PlayerListLabel);
            this.Controls.Add(this.Player2PlayerListLabel);
            this.Controls.Add(this.gameIDLabel);
            this.Controls.Add(this.lobbyLabel);
            this.Name = "frmGameLobby";
            this.Text = "frmGameLobby";
            this.Load += new System.EventHandler(this.frmGameLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lobbyLabel;
        private System.Windows.Forms.Label gameIDLabel;
        private System.Windows.Forms.Label Player2PlayerListLabel;
        private System.Windows.Forms.Label Player3PlayerListLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button joinOnlineGameButton;
        private System.Windows.Forms.Button startLocalGameButton;
        private System.Windows.Forms.Label SinglePlayerTitleLabel;
        private System.Windows.Forms.Label MultiPlayerTitleLabel;
        private System.Windows.Forms.Button createOnlineGameButton;
        private System.Windows.Forms.Label PlayerListTitleLabel;
        private System.Windows.Forms.Button addLocalGuestButton;
        private System.Windows.Forms.Label localUserPlayerListLabel;
        private System.Windows.Forms.Label setAmountLabel;
        private System.Windows.Forms.TextBox setAmountTextBox;
        private System.Windows.Forms.Button adjustMoneyButton;
        private System.Windows.Forms.Button deleteLocalGuestButton;
        private System.Windows.Forms.Label startingAmountValidLabel;
        private System.Windows.Forms.Label AdjustMoneyErrorMessageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentMoneyTitleLabel;
        private System.Windows.Forms.Label currentAmountOfMoneyLabel;
        private System.Windows.Forms.Button deleteLocalGameButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button startGameButton;
    }
}