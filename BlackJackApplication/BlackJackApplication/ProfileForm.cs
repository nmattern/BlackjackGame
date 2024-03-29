﻿using System;
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
        Player player;
        bool Valid = false;
        DatabaseAccess database;
        internal ProfileForm(Player p, DatabaseAccess db)
        {
            InitializeComponent();
            player = p;
            database = db;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.profileNameTextBox.Text.All(char.IsLetter) == true || this.profileNameTextBox.Text == "")
            {
                this.nameErrorLabel.Text = "";
                if (this.profilePhoneNumberTextBox.Text.Length <= 11 
                    && this.profilePhoneNumberTextBox.Text.Length > 9
                    && this.profilePhoneNumberTextBox.Text.All(char.IsDigit)
                    || this.profilePhoneNumberTextBox.Text == "")
                {
                    this.phoneErrorLabel.Text = "";
                    if (this.currentPasswordTextBox.Text == player.Password || this.currentPasswordTextBox.Text == "")
                    {
                        this.currentPasswordErrorLabel.Text = "";
                        if (this.confirmPasswordTextBox.Text == this.newPasswordTextBox.Text)
                        {
                            this.confirmPasswordErrorLabel.Text = "";
                            if (this.profileCreditCardTextBox.Text.Length == 16
                                && this.profileNameTextBox.Text.All(char.IsDigit)
                                || this.profileCreditCardTextBox.Text == "")
                            {
                                this.creditCardErrorLabel.Text = "";
                                Valid = true;
                            }
                            else
                            {
                                this.creditCardErrorLabel.Text = "Credit card must be 16 digit number";
                            }
                        } 
                        else
                        {
                            this.confirmPasswordErrorLabel.Text = "Passwords do not match";
                        }
                    }
                    else
                    {
                        this.currentPasswordErrorLabel.Text = "Incorrect Password";
                    }
                }
                else 
                {
                    this.phoneErrorLabel.Text = "Phone number must be 10-11 digit number";
                }
            }
            else
            {
                this.nameErrorLabel.Text = "Name must be only letters";
            }
            if (Valid == true)
            {
                if (this.profileNameTextBox.Text != "")
                {
                    player.Name = this.profileNameTextBox.Text;
                }
                if (this.usernameTextBox.Text != "")
                {
                    player.Username = this.usernameTextBox.Text;
                }
                if (this.newPasswordTextBox.Text != "")
                {
                    player.Password = this.newPasswordTextBox.Text;
                }
                if (this.profilePhoneNumberTextBox.Text != "")
                {
                    player.Phone = Convert.ToInt64(this.profileCreditCardTextBox.Text);
                }
                if (this.profileAddressTextBox.Text != "")
                {
                    player.Address = this.profileAddressTextBox.Text;
                }
                if (this.profileCreditCardTextBox.Text != "")
                {
                    player.CreditC = Convert.ToInt64(this.profilePhoneNumberTextBox.Text);
                }


                await database.modifyEntirePlayer(player);
                this.Close();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
        }
    }
}
