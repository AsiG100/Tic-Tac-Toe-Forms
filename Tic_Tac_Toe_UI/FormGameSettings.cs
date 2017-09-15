using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_UI;

namespace Tic_Tac_Toe_WindowGame
{
    public partial class FormGameSettings : Form
    {
        public enum GameSymbols
        {
            X,
            O
        }

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

                PlayerDetails player1 = new PlayerDetails();
                PlayerDetails player2 = new PlayerDetails();
                TicTacToeGameWindow gameWindow = new TicTacToeGameWindow();

                player1.m_PlayerSymbol = (char)GameSymbols.X;
                player2.m_PlayerSymbol = (char) GameSymbols.O;

                player1.m_Name = textBoxPlayer1Name.Text;

                // Single-player mode
                if (checkBoxPlayer2.Checked == false)
                {
                    player2.m_Name = "Computer";

                }
                // Multi-player mode
                else
                {
                    player2.Name = textBoxPlayer2Name.Text;
                }


                //gameWindow.Enabled = true;
                //gameWindow.ShowDialog();

                //gameWindow.TicTacToeGameWindow_CreateTableSize(numericUpDownColumnNumber);

            }
        }

        private void textBoxPlayer2Name_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
