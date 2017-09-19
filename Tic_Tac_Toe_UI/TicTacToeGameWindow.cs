using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tic_Tac_Toe_WindowGame;

namespace Tic_Tac_Toe_UI
{
    public partial class TicTacToeGameWindow : Form
    {
        private static int s_CurrentTurn = 0;
        private Button[,] m_GameTable;
        private Label m_Player1;
        private Label m_Player2;
        private Label m_Points1;
        private Label m_Points2;
        private PlayerDetails m_PlayerDetails1;
        private PlayerDetails m_PlayerDetails2;

        public TicTacToeGameWindow(NumericUpDown i_RowAndColLength, PlayerDetails i_Player1, PlayerDetails i_Player2)
        {
            int size = (int)i_RowAndColLength.Value;
            m_PlayerDetails1 = i_Player1;
            m_PlayerDetails2 = i_Player2;

            InitializeComponent();
            this.m_GameTable = new Button[size, size];
            TicTacToeGameWindow_CreateTable();
            //adjust the window to fit the buttons
            this.ClientSize = this.ClientSize = new System.Drawing.Size(20+(size*50), 40+(size*45));
            TicTacToeGameWindow_createLabels(i_Player1, i_Player2);
        }

        //creates the buttons and the labels in the window 
        public void TicTacToeGameWindow_CreateTable()
        {
            for (int i = 0; i < m_GameTable.GetLength(0); i++)
            {
                for (int j = 0; j < m_GameTable.GetLength(0); j++)
                {
                    m_GameTable[i,j] = new Button();
                    m_GameTable[i,j].Location = new System.Drawing.Point(9+(i*50), 9+(j*45));
                    m_GameTable[i, j].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                    m_GameTable[i, j].Name = "button"+(i+j);
                    m_GameTable[i, j].Size = new System.Drawing.Size(50, 45);
                    m_GameTable[i, j].TabStop = false;
                    m_GameTable[i, j].Text = "";
                    m_GameTable[i, j].UseVisualStyleBackColor = true;
                    m_GameTable[i,j].Show();
                    Controls.Add(this.m_GameTable[i,j]);
                    m_GameTable[i, j].Click += new System.EventHandler(this.button_Click);
                }
            }

        }

        //Creates lables
        private void TicTacToeGameWindow_createLabels(PlayerDetails i_Player1, PlayerDetails i_Player2)
        {
            //player1 label
            m_Player1 = new Label();
            m_Player1.AutoSize = true;
            m_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            m_Player1.Name = "labelPlayer1";
            m_Player1.Size = new System.Drawing.Size(64, 17);
            m_Player1.TabStop = false;
            m_Player1.Text = i_Player1.Name + ":";
            m_Player1.Location = new System.Drawing.Point((ClientSize.Width / 2)-70, ClientSize.Height-30);
            //player2 label
            m_Player2 = new Label();
            m_Player2.AutoSize = true;
            m_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_Player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            m_Player2.Name = "labelPlayer2";
            m_Player2.Size = new System.Drawing.Size(64, 17);
            m_Player2.TabStop = false;
            m_Player2.Text = i_Player2.Name+":";
            m_Player2.Location = new System.Drawing.Point((ClientSize.Width/2)-10, ClientSize.Height-30);
            //adding labels to the window
            Controls.Add(m_Player1);
            Controls.Add(m_Player2);
        }

        public void button_Click(object sender, EventArgs e)
        {
            if (s_CurrentTurn % 2 == 0)
            {
                ((Button) sender).Text = m_PlayerDetails1.PlayerSymbol.ToString();
            }
            else
            {
                ((Button)sender).Text = m_PlayerDetails2.PlayerSymbol.ToString();
            }

            ((Button) sender).Enabled = false;
            s_CurrentTurn++;
        }
    }
}
