using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Game
{
    public class Program
    {
        public static string[] board = new string[9];
        public static List<string> playersList = new List<string> { "X", "O" };
        public static string current;
        public static string prev;
        public static int turnCount = 0;

        [STAThread]
        static void Main()
        {
            Console.WriteLine("Welcome");
            createBoard();

            currentPlayer();
            Console.WriteLine("Starting player is: " + current);
            Console.WriteLine("Turn count is: " + turnCount);

            makeMove();
            Console.WriteLine(board[0].ToString());

            spaceInUse(board[0].ToString());

            changePlayer();
            Console.WriteLine("Current player is: " + current);
            Console.WriteLine("Turn count is: " + turnCount);
        }

        public static void createBoard()
        {
            List<string> board = new List<string> { "+", "+", "+", "+", "+", "+", "+", "+", "+" };
            Console.WriteLine(board.ToString());
        }
        public static void currentPlayer()
        {
            Random random = new Random();

            int i = random.Next(playersList.Count);
            current = playersList[i];
            turnCount++;
        }


        public static void changePlayer()
        {
            string temp;
            if (current == playersList[0])
            {
                temp = current;
                current = playersList[1];
                turnCount++;
            }
            else
            {
                temp = current;
                prev = current;
                current = playersList[0];
                turnCount++;
            }
        }

        public static void makeMove()
        {
            board[0] = playersList[0];
            board[1] = playersList[1];
            board[2] = playersList[0];
            board[3] = playersList[1];
            board[4] = playersList[0];
            board[5] = playersList[1];
            board[6] = playersList[0];
            board[7] = playersList[1];
            board[8] = playersList[0];
        }


        public static void spaceInUse(string i)
        {
            bool check = false;

            if (i.Equals("+"))
            {
                check = false;
            }
            else
            {
                check = true;
            }
            Console.WriteLine(check);
        }

        public int[] Board { get; set; }
    }
}