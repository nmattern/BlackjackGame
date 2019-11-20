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
    public partial class frmGameLobby : Form
    {
        List<Player> players = new List<Player>();
        DatabaseAccess database;
        internal frmGameLobby(Player p, DatabaseAccess db)
        {
            InitializeComponent();
            players.Add(p);
            database = db;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

        }

        private void joinGameButton_Click(object sender, EventArgs e)
        {

        }

        private void setAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(this.setAmountTextBox.Text, out number);
            if (betContainsOnlyDigits && this.setAmountTextBox.Text != "")
            {
                // TODO update player money value in database
                players[0].CurrentAmountOfMoney = Convert.ToInt32(setAmountTextBox.Text);
            }
            else if (this.setAmountTextBox.Text == "")
            {
                startingAmountValidLabel.Text = "Enter a number";
            }
            else
            {
                startingAmountValidLabel.Text = "Not Valid";
            }
        }

        private void frmGameLobby_Load(object sender, EventArgs e)
        {

        }
    }
}
