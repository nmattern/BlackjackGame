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
    public partial class startScreenForm : Form
    {
        public startScreenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tableFormInstance = new tableForm();
            tableFormInstance.currentMoneyLabel.Text = initialAmountTxtBx.Text;
            tableFormInstance.Show();
            tableFormInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            tableFormInstance.FormClosed += (s, args) => this.Close();
        }

        private void startScreenForm_Load(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.testConnection();
            databaseAccess.testCreatePlayer();
            CenterToScreen();
            this.initialAmountTxtBx.Select();
            checkPlayerLabelState();
        }

        private void ManageProfile_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void numPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numPlayersLabel.Text) < 3)
            {
                numPlayersLabel.Text = Convert.ToString(Convert.ToInt32(numPlayersLabel.Text) + 1);
            }
            checkPlayerLabelState();
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(numPlayersLabel.Text) > 1)
            {
                numPlayersLabel.Text = Convert.ToString(Convert.ToInt32(numPlayersLabel.Text) - 1);
            }
            checkPlayerLabelState();

        }

        private void checkPlayerLabelState()
        {
            if (numPlayersLabel.Text == "1")
            {
                p1SigninButton.Show();
                p2SigninButton.Hide();
                p3SigninButton.Hide();
            }
            if (numPlayersLabel.Text == "2")
            {
                p1SigninButton.Show();
                p2SigninButton.Show();
                p3SigninButton.Hide();
            }
            if (numPlayersLabel.Text == "3")
            {
                p1SigninButton.Show();
                p2SigninButton.Show();
                p3SigninButton.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm signin = new SignInForm(2);
            signin.Show();
        }

        private void p1SigninButton_Click(object sender, EventArgs e)
        {
            SignInForm signin = new SignInForm(1);
            signin.Show();
        }

        private void p3SigninButton_Click(object sender, EventArgs e)
        {
            SignInForm signin = new SignInForm(3);
            signin.Show();
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
