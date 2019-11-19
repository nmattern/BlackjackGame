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
    public partial class SignInForm : Form
    {
        int playerNum = 0;
        public SignInForm(int playerNumber)
        {
            InitializeComponent();
            playerNum = playerNumber;
            signInLabel.Text = "Player " + Convert.ToString(playerNumber) + " Sign In";
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
