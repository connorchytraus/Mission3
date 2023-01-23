using System;

namespace Mission3
{
    public class supporting
    {

        private string[] board = new string[9];

        public supporting(string[] choices)
        {
            board = choices;
        }

        public void printBoard(string[] choices)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", choices[0], choices[1], choices[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", choices[3], choices[4], choices[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", choices[6], choices[7], choices[8]);
            Console.WriteLine("     |     |      ");
        }

        public int checkWinner(string[] choices)
        {
            //horizontal Xs
            if ("X" == choices[0] && "X" == choices[1] && "X" == choices[2])
            {
                return 1;
            }
            else if ("X" == choices[3] && "X" == choices[4] && "X" == choices[5])
            {
                return 1;
            }
            else if ("X" == choices[6] && "X" == choices[7] && "X" == choices[8])
            {
                return 1;
            }

            //horizotal Os
            else if ("O" == choices[0] && "O" == choices[1] && "O" == choices[2])
            {
                return 2;
            }

            else if ("O" == choices[3] && "O" == choices[4] && "O" == choices[5])
            {
                return 2;
            }

            else if ("O" == choices[6] && "O" == choices[7] && "O" == choices[8])
            {
                return 2;
            }

            //Vertical Xs
            else if ("X" == choices[0] && "X" == choices[3] && "X" == choices[6])
            {
                return 1;
            }

            else if ("X" == choices[1] && "X" == choices[4] && "X" == choices[7])
            {
                return 1;
            }

            else if ("X" == choices[2] && "X" == choices[5] && "X" == choices[8])
            {
                return 1;
            }

            // vertical O's
            else if ("O" == choices[0] && "O" == choices[3] && "O" == choices[6])
            {
                return 2;
            }

            else if ("O" == choices[1] && "O" == choices[4] && "O" == choices[7])
            {
                return 2;
            }

            else if ("O" == choices[2] && "O" == choices[5] && "O" == choices[8])
            {
                return 2;
            }

            // diagonal O's
            else if ("O" == choices[0] && "O" == choices[4] && "O" == choices[8])
            {
                return 2;
            }

            else if ("O" == choices[2] && "O" == choices[4] && "O" == choices[6])
            {
                return 2;
            }

            // diagonal X's
            else if ("X" == choices[0] && "X" == choices[4] && "X" == choices[8])
            {
                return 1;
            }

            else if ("X" == choices[2] && "X" == choices[4] && "X" == choices[6])
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }
    }
}