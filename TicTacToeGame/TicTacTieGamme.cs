using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class TicTacTieGamme
    {
        public void createBoard()
        {
            char[] board = new char[11];
            for (int i = 1; i <= 10; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
