using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello User, welcome to Tic-Tac-Toe!");
            Console.WriteLine("");

            //create array to store choices
            string[] choices = new string[9];
            for (int i = 0; i < 9; i++)
            {
                choices[i] = Convert.ToString(i + 1);
            }

            supporting support = new supporting(choices);

            int winFlag = -1;
            int tieFlag = 0;

            while (winFlag == -1 && tieFlag < 9)
            {
                //these are the spots that player 1 and 2 chose to play their turn
                int place1 = 0;
                int place2 = 0;
                

                Console.WriteLine("Player 1: X's Player 2: O's");

                support.printBoard(choices);
                Console.WriteLine("");
                //print board here calling supporting class

                Console.Write("Player 1's turn. Please select a space to play, then press enter: ");
                place1 = Convert.ToInt32(Console.ReadLine());
                choices[place1-1] = "X";
                tieFlag++;

                support.printBoard(choices);
                Console.WriteLine("");
                if (support.checkWinner(choices) != -1)
                {
                    winFlag = 1;
                    break;
                }

                if (tieFlag == 9)
                {
                    break;
                }

                Console.WriteLine("Player 1: X's Player 2: O's");

                //print board here calling supporting class

                Console.Write("Player 2's turn. Please select a space to play, then press enter: ");
                place2 = Convert.ToInt32(Console.ReadLine());
                choices[place2 - 1] = "O";
                tieFlag++;
                

                //send place to support
                //check win
                
                winFlag = support.checkWinner(choices);
               
            }

            if (winFlag == 1 || winFlag == 2)
            {
                Console.WriteLine("Congratulations! Player " + winFlag + " won the game!");
            }
            else
            {
                Console.WriteLine("There was a tie");
            }
        }
    }
}
