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
            this.Close();
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
