using System.Collections.Generic;

namespace Tic_Tac_Toe_WindowGame
{
    public class PlayerDetails //Contains player's name, symbol and matches won
    {
        public static List<char> s_Symbols = new List<char>(){'X', 'O'};
        private string m_Name;
        private byte m_Points;
        private char m_PlayerSymbol;

        public PlayerDetails(string i_Name, char i_PlayerSymbol)
        {
            m_Name = i_Name;
            m_Points = 0;
            m_PlayerSymbol = i_PlayerSymbol;
        }

        public string Name
        {
            get => m_Name;
            set => m_Name = value;
        }

        public char PlayerSymbol
        {
            get => m_PlayerSymbol;
            set => m_PlayerSymbol = value;
        }

        public byte Points
        {
            get => m_Points;
            set => m_Points = value;
        }
    }
}
