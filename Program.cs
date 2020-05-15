using System;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            StartTicTacToe();
            Console.ReadKey();
        }
        public static void StartTicTacToe()
        {
            string player1 = "x";
            string player2 = "o";
           

            string[,] ticTac2DArray = new string[3, 3]{
           {"1","2","3"},
           {"4","5","6"},
           {"7","8","9"}
           };




            Console.WriteLine("Welcome to TicTacToe!");
            Console.WriteLine("Player 1 Please enter if you want to be X or, O Player 1.");
            string input = Console.ReadLine();

            if (input == "x" || input == "o")
            {
                if (input == "x")
                {
                    player1 = "x";
                    player2 = "o";
                    Console.WriteLine("Player 1: " + player1);
                    Console.WriteLine("Player 2: " + player2);

                }
                else
                {
                    player1 = "o";
                    player2 = "x";
                    Console.WriteLine("Player 1: " + player1);
                    Console.WriteLine("Player 2: " + player2);
                    Console.WriteLine("Let's start!!");

                }
            }
            else
            {
                Console.WriteLine("Invalid Response, please try again.");

            }

            Console.WriteLine("Player One start!");

            string[] inputButton = new string[9] { ticTac2DArray[0, 0], ticTac2DArray[0, 1], ticTac2DArray[0, 2], ticTac2DArray[1, 0], 
                                                 ticTac2DArray[1, 1], ticTac2DArray[1, 2], ticTac2DArray[2, 0], ticTac2DArray[2, 1], ticTac2DArray[2, 2] };
            foreach (string space in inputButton)
            {

                for (int i = 0; i < 10; i++) {


                    
                    Console.WriteLine("Choose the avaiable spot. PLAYER 1");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[6], inputButton[7], inputButton[8]);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[3], inputButton[4], inputButton[5]);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[0], inputButton[1], inputButton[2]);


                    int count;
                    string input2 = Console.ReadLine();
                    int.TryParse(input2, out count);
                    inputButton[count-1] = player1;
              

                    // int.TryParse(input2, out inputButton);

                    Console.WriteLine("Choose the avaiable spot. PLAYER 2");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[6], inputButton[7], inputButton[8]);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[3], inputButton[4], inputButton[5]);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("{0} || {1} || {2}", inputButton[0], inputButton[1], inputButton[2]);

                    string input3 = Console.ReadLine();
                    int.TryParse(input3, out count);
                    inputButton[count-1] = player2;
                    
                }
            }
        }
    }
}
