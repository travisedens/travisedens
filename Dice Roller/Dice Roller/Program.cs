using System;

namespace Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int DieQuantity = 0;
            int DieSize = 0;
            string userinput = "y";

            Random random = new Random();

            // START HERE //

            Console.WriteLine("Welcome to Travis' Dice Roller");

            while (userinput == "y" ||userinput == "Y")
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
        }
    }
}

