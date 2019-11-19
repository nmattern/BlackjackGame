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
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Player newplayer = new Player(
                Convert.ToInt32(this.phoneTextBox.Text), this.addressTextBox.Text, this.nameTextBox.Text,
                Convert.ToInt32(creditCardTextBox.Text), this.recovQTextBox.Text, this.recovATextBox.Text,
                this.passwordTextBox.Text, this.usernameTextBox.Text, 34);

        }
    }
}
