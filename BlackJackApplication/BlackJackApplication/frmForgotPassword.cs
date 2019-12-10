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
    public partial class frmForgotPassword : Form
    {
        DatabaseAccess database = null;
        string recovQ = "";
        string recovA = "";
        string newPass = "";
        string confNewPass = "";


        internal frmForgotPassword(DatabaseAccess data)
        {
            InitializeComponent();
            database = data;
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {  
            
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
        }

        private void newPassTextBox_Click(object sender, EventArgs e)
        {
            newPassTextBox.Text = "";
        }

        private void confPassTextBox_Click(object sender, EventArgs e)
        {
            confPassTextBox.Text = "";
        }

        private void sumbitButton_Click(object sender, EventArgs e)
        {
            if (recovA == recovATextBox.Text)
            {
                newPassTextBox.Visible = true;
                confPassTextBox.Visible = true;
                confirmButton.Visible = true;
                wrongAnswerLabel.Text = "";
            }
            else
            {
                wrongAnswerLabel.Text = "Incorrect";
            }
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            newPass = newPassTextBox.Text;
            confNewPass = confPassTextBox.Text;
            if (newPass == confNewPass)
            {
                //update password
                database.CurrentPlayer.Password = newPass;
                await database.modifyEntirePlayer(database.CurrentPlayer);
                passwordLabel.Text = "";
            }
            else
            {
                passwordLabel.Text = "Passwords must match";
            }
        }

        private async void pullQButton_Click(object sender, EventArgs e)
        {
            await database.returnPlayer(usernameTextBox.Text);
            recovQ = database.CurrentPlayer.RecovQ;
            recovA = database.CurrentPlayer.RecovA;
            recovQLabel.Text += recovQ;
        }
    }
}
