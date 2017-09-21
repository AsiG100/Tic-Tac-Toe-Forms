using System;
using System.Windows.Forms;
using Tic_Tac_Toe_WindowGame;

namespace Tic_Tac_Toe_UI
{
    public partial class TicTacToeMainMenu : Form
    {
        public TicTacToeMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToeMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Hide();
            FormGameSettings gameSettings = new FormGameSettings();
            gameSettings.Enabled = true;
            gameSettings.Show();
        }

        private void TicTacToeMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
