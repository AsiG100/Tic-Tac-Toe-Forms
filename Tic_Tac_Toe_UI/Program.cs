using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tic_Tac_Toe_UI;

namespace Tic_Tac_Toe_WindowGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGameSettings());
            Application.Run(new TicTacToeGameWindow());

        }
    }
}
