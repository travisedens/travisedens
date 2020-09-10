using System;
using System.Dynamic;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            Console.WriteLine("Hey! This is the main menu! Press one of the following keys to continue to the next methods.");
            Console.WriteLine("1 - Dice Roller\n2 - Factorial\n3 - Make it Naked\n0 - Exit");
            string input = Console.ReadLine();
            Console.WriteLine("You input " + input);

            if (input == "1")
            {
                DiceRoller();
            }
            else if (input == "2")
            {
                Console.WriteLine("Want a factorial? Enter the number.");
                string factorialInputString = Console.ReadLine();
                int factorialInput = Int32.Parse(factorialInputString);
                double factorialResult = factorial_Recursion(factorialInput);
                Console.WriteLine("The factorial of given number is " + factorialResult);
            }
            else if (input == "3")
            {
                Naked();
            }
            else if (input == "0")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please input 1, 2, 3, or 0 to continue.");
            }
            MainMenu();
        }
        public static void DiceRoller()
        {
            string input = "";
            int DieQuantity = 0;
            int DieSize = 0;
            string userinput = "y";

            Random random = new Random();

            // START HERE //

            Console.WriteLine("Welcome to Travis' Dice Roller");

            while (userinput == "y" || userinput == "Y")
            {
                //Asks how many dice to roll
                Console.Write("How many dice would you like to roll? (1 or 2) Type -1 to exit.  ");

                input = Console.ReadLine();
                bool check = Int32.TryParse(input, out DieQuantity);

                if (DieQuantity == -1)
                    break;

                else if (DieQuantity < 1 || DieQuantity > 2)
                {
                    Console.WriteLine("Hey dumb dumb! Use 1 or 2!");
                    continue;
                }
                Console.Write("Would you like to roll a 6 or 20 sided dice? ");

                input = Console.ReadLine();
                check = Int32.TryParse(input, out DieSize);

                if (DieSize != 6 && DieSize != 20)
                {
                    Console.WriteLine("6 or 20!!!!");
                    continue;
                }
                for (int i = 0; i < DieQuantity; i++)
                {
                    Console.WriteLine(random.Next(1, DieSize + 1));
                }
                Console.Write("Would you like to roll again? ");
                Console.Write("Type 'y'or 'Y' to play again? ");

                input = Console.ReadLine();
           
            }
            MainMenu();

        }
        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
            MainMenu();
        }
        public static void Naked()
        {
            Console.WriteLine("Write any sentence and I'll make it funny (assuming your sense of humor = 3rd Grade Level.)");
            string input = Console.ReadLine();
            Console.WriteLine(input.Trim() + ", " + "naked.");
            MainMenu();
        }

    }
}
