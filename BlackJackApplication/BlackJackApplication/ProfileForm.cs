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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            profileNameTextBox.Visible = true;
        }

        private void nameFocusLost(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                profileNameTextBox.Visible = false;
                profileNameLabel.Text = profileNameTextBox.Text;
            }
        }

        private void profileAddressLabel_Click(object sender, EventArgs e)
        {
            profileAddressTextBox.Visible = true;
        }

        private void addressFocusLost(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                profileAddressTextBox.Visible = false;
                profileAddressLabel.Text = profileAddressTextBox.Text;
            }
        }

        private void ProfilePhoneNumberLabel_Click(object sender, EventArgs e)
        {
            profilePhoneNumberTextBox.Visible = true;
        }
        private void phoneNumberFocusLost(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                profilePhoneNumberTextBox.Visible = false;
                profilePhoneNumberLabel.Text = profilePhoneNumberTextBox.Text;
            }
        }
        private void ProfileCreditCardLabel_Click(object sender, EventArgs e)
        {
            profileCreditCardTextBox.Visible = true;
        }

        private void creditCardFocusLost(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                profileCreditCardTextBox.Visible = false;
                profileCreditCardLabel.Text = profileCreditCardTextBox.Text;
            }
        }
    }
}
