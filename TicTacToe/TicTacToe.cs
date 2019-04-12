using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "O";

        public static int count = 0;


        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                if (playerTurn == "X") {
                    playerTurn = "O";
                }else{
                    playerTurn = "X";
                }
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
            if (board[row][column] == " ") {
                if (playerTurn == "X") {
                    board[row][column]= "X";
                }else{
                    board[row][column] = "0";
                }
                count++;
            }else{
                Console.WriteLine("That spot has already been chosen. Choose another.");
            }

        }

        public static bool CheckForWin()
        {
            if (HorizontalWin() || VerticalWin() || DiagonalWin()) {
                Console.WriteLine("Player "+playerTurn+", you win!");
                DrawBoard();
                return true;
            }

            return false;
        }

        public static bool CheckForTie()
        {
            if (!CheckForWin() && count >= 9) {
                Console.WriteLine("It's a tie!");
                DrawBoard();
                return true;
            }
            return false;
        }

        public static bool HorizontalWin()
        {
            if (playerTurn == board[0][0] && playerTurn == board[0][1] && playerTurn == board[0][2]) {
                return true;
            }else if (playerTurn == board[1][0] && playerTurn == board[1][1] && playerTurn == board[1][2]) {
                return true;
            }else if (playerTurn == board[2][0] && playerTurn == board[2][1] && playerTurn == board[2][2]) {
                return true;
            }
        return false;
        }

        public static bool VerticalWin()
        {
            if (playerTurn == board[0][0] && playerTurn == board[1][0] && playerTurn == board[2][0]) {
                return true;
            }else if (playerTurn == board[0][1] && playerTurn == board[1][1] && playerTurn == board[2][1]) {
                return true;
            }else if (playerTurn == board[0][2] && playerTurn == board[1][2] && playerTurn == board[2][2]) {
                return true;
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            if (playerTurn == board[0][0] && playerTurn == board[1][1] && playerTurn == board[2][2]) {
                return true;
            }else if (playerTurn == board[0][2] && playerTurn == board[1][1] && playerTurn == board[2][0]) {
                return true;
            }
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
