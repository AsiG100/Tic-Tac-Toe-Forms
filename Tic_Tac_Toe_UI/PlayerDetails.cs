namespace Tic_Tac_Toe_WindowGame
{
    class PlayerDetails //Contains player's name, symbol and matches won
    {
        public string m_Name;
        public byte m_Points;
        public char m_PlayerSymbol;

        public PlayerDetails()
        {
            m_Name = string.Empty;
            m_Points = 0;
            m_PlayerSymbol = ' ';
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
    }
}
