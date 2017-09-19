using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_UI;

namespace Tic_Tac_Toe_WindowGame
{
    public partial class FormGameSettings : Form
    {

        public FormGameSettings()
        {
            InitializeComponent();
        }

        public NumericUpDown NumericUpDownRowNumber
        {
            get
            {
                return numericUpDownRowNumber;
            }
        }

        public NumericUpDown NumericUpDownColumnNumber
        {
            get
            {
                return numericUpDownColumnNumber;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                textBoxPlayer2Name.Enabled = true;
                textBoxPlayer2Name.BackColor = Color.White;
                textBoxPlayer2Name.Text = "";
            }
            else
            {
                textBoxPlayer2Name.Enabled = false;
                textBoxPlayer2Name.BackColor = Color.DarkGray;
                textBoxPlayer2Name.Text = "[Computer]";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownRowNumber_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownColumnNumber.Value = numericUpDownRowNumber.Value;
        }

        private void numericUpDownColumnNumber_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRowNumber.Value = numericUpDownColumnNumber.Value;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlayer1Name.Text))
            {
                MessageBox.Show("Please enter first player name!");
            }
            else if (checkBoxPlayer2.Checked && string.IsNullOrEmpty(textBoxPlayer2Name.Text))
            {
                MessageBox.Show("Please enter second player name!");
            }
            else // Start game
            {
                Hide();

                PlayerDetails player1 = new PlayerDetails(textBoxPlayer1Name.Text,PlayerDetails.s_Symbols[0]);
                PlayerDetails player2;
             
                // Single-player mode
                if (checkBoxPlayer2.Checked == false)
                {
                     player2 = new PlayerDetails("Computer",PlayerDetails.s_Symbols[1]);
                }
                // Multi-player mode
                else
                {
                     player2 = new PlayerDetails(textBoxPlayer2Name.Text, PlayerDetails.s_Symbols[1]);
                }

                TicTacToeGameWindow gameWindow = new TicTacToeGameWindow(NumericUpDownColumnNumber, player1, player2);

                gameWindow.Enabled = true;
                gameWindow.ShowDialog();


            }
        }
    }
}
