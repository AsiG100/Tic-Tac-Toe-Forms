using System;
using System.Windows.Forms;
using Tic_Tac_Toe_WindowGame;

namespace Tic_Tac_Toe_UI
{
    public partial class TicTacToeGameWindow : Form
    {
        private static int s_CurrentTurn;
        private int rowAndColSize;
        private Button[,] m_GameTable;
        private Label m_Player1;
        private Label m_Player2;
        private PlayerDetails m_PlayerDetails1;
        private PlayerDetails m_PlayerDetails2;

        public TicTacToeGameWindow(int i_RowAndColLength, PlayerDetails i_Player1, PlayerDetails i_Player2)
        {
            rowAndColSize = i_RowAndColLength;
            s_CurrentTurn = 0;
            m_PlayerDetails1 = i_Player1;
            m_PlayerDetails2 = i_Player2;

            InitializeComponent();
            this.m_GameTable = new Button[rowAndColSize, rowAndColSize];
            TicTacToeGameWindow_CreateTable();
            //adjust the window to fit the buttons
            this.ClientSize = this.ClientSize = new System.Drawing.Size(20+rowAndColSize*50, 55 + rowAndColSize *45);
            TicTacToeGameWindow_createLabels(i_Player1, i_Player2);
        }

        /// <summary>
        /// creates the buttons and the labels in the window 
        /// </summary>
        public void TicTacToeGameWindow_CreateTable()
        {
            for (int i = 0; i < m_GameTable.GetLength(0); i++)
            {
                for (int j = 0; j < m_GameTable.GetLength(0); j++)
                {
                    m_GameTable[i, j] = new Button();
                    m_GameTable[i,j].Location = new System.Drawing.Point(9+i*50, 9+j*45);
                    m_GameTable[i, j].Margin = new Padding(2, 2, 2, 2);
                    m_GameTable[i, j].Name = "button"+(i+j);
                    m_GameTable[i, j].Size = new System.Drawing.Size(50, 45);
                    m_GameTable[i, j].TabStop = false;
                    m_GameTable[i, j].Text = " ";
                    m_GameTable[i, j].UseVisualStyleBackColor = true;
                    m_GameTable[i,j].Show();
                    Controls.Add(this.m_GameTable[i,j]);
                    m_GameTable[i, j].Click += new System.EventHandler(this.button_Click);
                }
            }

        }

        /// <summary>
        /// Creates lables
        /// </summary>
        /// <param name="i_Player1"></param>
        /// <param name="i_Player2"></param>
        private void TicTacToeGameWindow_createLabels(PlayerDetails i_Player1, PlayerDetails i_Player2)
        {
            //player1 label
            m_Player1 = new Label();
            m_Player1.AutoSize = true;
            m_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            m_Player1.Margin = new Padding(2, 0, 2, 0);
            m_Player1.Name = "labelPlayer1";
            m_Player1.Size = new System.Drawing.Size(64, 17);
            m_Player1.TabStop = false;
            m_Player1.Text = string.Format("{0}: {1}", i_Player1.Name, i_Player1.Points);
            m_Player1.Location = new System.Drawing.Point(10, ClientSize.Height - 43);
            //player2 label
            m_Player2 = new Label();
            m_Player2.AutoSize = true;
            m_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            m_Player2.Margin = new Padding(2, 0, 2, 0);
            m_Player2.Name = "labelPlayer2";
            m_Player2.Size = new System.Drawing.Size(64, 17);
            m_Player2.TabStop = false;
            m_Player2.Text = string.Format("{0}: {1}",i_Player2.Name,i_Player2.Points);
            m_Player2.Location = new System.Drawing.Point(10, ClientSize.Height - 25);
            //adding labels to the window
            Controls.Add(m_Player1);
            Controls.Add(m_Player2);
        }

        public void button_Click(object sender, EventArgs e)
        {
            if (s_CurrentTurn % 2 == 0)
            {
                ((Button) sender).Text = m_PlayerDetails1.PlayerSymbol.ToString();
                m_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                m_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            }
            else
            {
                ((Button)sender).Text = m_PlayerDetails2.PlayerSymbol.ToString();
                m_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                m_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            }

            //The computer's move if we are playing against it
            if (m_PlayerDetails2.Name == "Computer" && !isWon() && !isTie())
            {
                char[,] symbols = toChars();
                TicTacToeLogic.computerMove(ref symbols, m_PlayerDetails2);
                locateNewSymbolInButton(symbols);
                s_CurrentTurn++;
            }

            //A win
            if (isWon())
            {
                char currentSymbol = PlayerDetails.s_Symbols[s_CurrentTurn % 2];

                string winner = TicTacToeLogic.findWinner(ref m_PlayerDetails1, ref m_PlayerDetails2, currentSymbol);
                string output = string.Format(@"
The winner is {0},
would you like to play another round?", winner);

                if (MessageBox.Show(output, "A win", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TicTacToeGameWindow newGameWindow =
                        new TicTacToeGameWindow(rowAndColSize, m_PlayerDetails1, m_PlayerDetails2);
                    newGameWindow.Enabled = true;
                    newGameWindow.Show();
                    Hide();
                }
                else
                {
                    TicTacToeMainMenu mainMenu = new TicTacToeMainMenu();
                    mainMenu.Enabled = true;
                    mainMenu.Show();
                    Hide();
                }
            }
            else
            {
                ((Button)sender).Enabled = false;
                s_CurrentTurn++;

                //A tie
                if (isTie())
                {
                    string output = string.Format(@"
Its a tie,
would you like to play another round?");

                    if (MessageBox.Show(output, "A tie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TicTacToeGameWindow newGameWindow = new TicTacToeGameWindow(rowAndColSize, m_PlayerDetails1, m_PlayerDetails2);
                        newGameWindow.Enabled = true;
                        newGameWindow.Show();
                        Hide();
                    }
                    else
                    {
                        TicTacToeMainMenu mainMenu = new TicTacToeMainMenu();
                        mainMenu.Enabled = true;
                        mainMenu.Show();
                        Hide();
                    }
                }
            }

        }

        /// <summary>
        /// Finds out if the table is full
        /// </summary>
        private bool isTie()
        {
            bool isContainingEmptyButton = true;

            for (int i = 0; i < rowAndColSize; i++)
            {
                for (int j = 0; j < rowAndColSize; j++)
                {
                    if (m_GameTable[i, j].Text == " ")
                    {
                        isContainingEmptyButton = false;
                        break;
                    }
                }
            }

            return isContainingEmptyButton;
        }

        /// <summary>
        /// Finds out if there is a sequence
        /// </summary>
        private bool isWon()
        {
            char currentSymbol = PlayerDetails.s_Symbols[s_CurrentTurn % 2];
            char[,] symbols = toChars();

            return TicTacToeLogic.checkforStraight(symbols, currentSymbol, s_CurrentTurn);
        }

        /// <summary>
        /// Makes an array of chars for the buttons symbols 
        /// </summary>
        private char[,] toChars()
        {
            char[,] symbols = new char[rowAndColSize, rowAndColSize];

            for (int i = 0; i < rowAndColSize; i++)
            {
                for (int j = 0; j < rowAndColSize; j++)
                {
                    symbols[i, j] = m_GameTable[i, j].Text[0];
                }
            }

            return symbols;
        }

        /// <summary>
        /// Takes a chars array and make it identical 
        /// to the texts in the buttons
        /// </summary>
        private void locateNewSymbolInButton(char[,] i_symbols)
        {
            for (int i = 0; i < rowAndColSize; i++)
            {
                for (int j = 0; j < rowAndColSize; j++)
                {
                    if (m_GameTable[i, j].Text[0] != i_symbols[i, j])
                    {
                        m_GameTable[i, j].Text = i_symbols[i, j].ToString();
                        m_GameTable[i, j].Enabled = false;
                        break;
                    }
                }
            }
        }

        private void TicTacToeGameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //END
        private void TicTacToeGameWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
