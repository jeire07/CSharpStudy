using static System.Console;

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If you want to run Tic-Tac-Toe game code,
            // uncomment the following 2 lines.
            //Game01TicTacToe tictactoe = new Game01TicTacToe();
            //tictactoe.PlayTicTacToe();

            // If you want to run Snake game code,
            // uncomment the following 2 lines.
            //Game02Snake game = new Game02Snake();
            //game.PlaySnake();

            // If you want to run Blackjack game code,
            // uncomment the following 2 lines.
            //Game03Blackjack game = new Game03Blackjack();
            //game.PlayBlackjack();

            // If you want to run Text game code,
            // uncomment the following 2 lines.
            Game04TextGame textGame = new Game04TextGame();
            textGame.PlayText();
        }
    }
}