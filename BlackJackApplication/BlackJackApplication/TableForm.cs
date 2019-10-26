using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApplication
{
    public partial class tableForm : Form
    {
        private Turn turn;

        public tableForm()
        {
            InitializeComponent();
        }

        

        public void Form1_Load(object sender, EventArgs e)
        { 
            Deck myDeck = new Deck();
            Dealer dealer = new Dealer();
            Player player1 = new Player();
            Table table = new Table();
            turn = new Turn(this, myDeck, table, player1, dealer);

            continueButton.Enabled = false;
            player1.AmountOfMoney = 1000;
            turn.beginTurn();
        }

        private void hitButton_Click(object sender, EventArgs e)
        { 
            turn.hitButtonClick();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            turn.standButtonClick();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.continueButton.Enabled = false;
            this.standButton.Enabled = true;
            this.hitButton.Enabled = true;
            turn.continueButtonClick();
        }

        private void betTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            int number;
            bool betContainsText = Int32.TryParse(this.betTextBox.Text, out number);
            if (!betContainsText)
            {
                this.betTextBox.Text = "";
            }
        }
    }
}
