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
        private int rowAndColSize;

        public TicTacToeGameWindow()
        {
            InitializeComponent();
        }

        //public void TicTacToeGameWindow_CreateTableSize(NumericUpDown i_RowAndColLength)
        //{
        //    //rowAndColSize = 
        //    //Button[,] gameTable = new Button[rowAndColSize,rowAndColSize];

        //    for (int i = 1; i <= rowAndColSize; i++)
        //    {
        //        for (int j = 1; j <= rowAndColSize; j++)
        //        {
        //            Show();
        //        }
        //    }
        //}

        private static void TicTacToeGameWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
