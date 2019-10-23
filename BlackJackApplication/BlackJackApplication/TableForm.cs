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
        public tableForm()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        { 
            Deck myDeck = new Deck();
            Dealer dealer = new Dealer();
            Player player1 = new Player();

            player1.changeMoneyValue(1000);

            dealer.dealCard(dealer, myDeck, 2);
            dealer.dealCard(player1, myDeck, 2);
            foreach (Card card in dealer.currentPlayerHand)
            {
                dealerCardTable.Controls.Add(new PictureBox() { Image = card.CardImage }, 0, 0);
            }
            foreach ( Card card in player1.currentPlayerHand)
            {
                playerCardTable.Controls.Add(new PictureBox() { Image = card.CardImage }, 0, 0);
            }
            dealerTotalLabel.Text = dealer.ValueOfHand.ToString();
            playerTotalLabel.Text = player1.ValueOfHand.ToString();

        }
    }
}
