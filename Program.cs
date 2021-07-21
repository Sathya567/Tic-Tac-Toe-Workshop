using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToeGame obj = new TicTacToeGame();
            obj.gameBoard();
            obj.abilityToInput();
        }
    }
}
