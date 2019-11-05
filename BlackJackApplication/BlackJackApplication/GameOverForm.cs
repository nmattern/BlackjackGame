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
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            var startScreenInstance = new startScreenForm();
            startScreenInstance.Show();
            startScreenInstance.Location = this.Location;
            this.Hide();
            // This is an event handler for the closing of a child form
            // Passes the subject (child form) and arguments to close 
            // Parent form as well
            startScreenInstance.FormClosed += (s, args) => this.Close();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
