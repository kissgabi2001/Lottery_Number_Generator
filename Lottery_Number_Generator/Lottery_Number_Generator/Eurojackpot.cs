using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Number_Generator
{
    class Eurojackpot
    {
        private static Random r;
        public Eurojackpot()
        {
            r = new Random();
            Euro();
        }

        public void Euro()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Scandinavian Lottery";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            string t = "If you want to know more about the game, choose an option!";

            Console.Write("\nThe field A's random numbers are:\t");
            int[] numbersA = RandomNumbersA();
            Array.Sort(numbersA);
            for (int i = 0; i < numbersA.Length; i++)
            {
                Console.Write(numbersA[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nThe field B's random numbers are:\t");
            int[] numbersB = RandomNumbersB();
            Array.Sort(numbersB);
            for (int i = 0; i < numbersB.Length; i++)
            {
                Console.Write(numbersB[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < t.Length + 17; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            Console.WriteLine(t + "\n" +
                "\n\t[ 1. ] What is Scandinavian Lottery?\n" +
                "\n\t[ 2. ] What are the rules?\n");
            Console.WriteLine("Do you want to generate new random numbers?\n" +
                "\n\t[ 3. ] Generate new random numbers\n");
            Console.WriteLine("Menu options:\n" +
                "\n\t[ 4. ] Back to the main menu\n" +
                "\n\t[ PRESS ANY KEY ] Close the program");

            for (int i = 0; i < t.Length + 17; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\nChosen option:");
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Good luck! :)\n");
                Environment.Exit(0);
            }
            switch (number)
            {
                case 1:
                    SevenDrawStory();
                    break;
                case 2:
                    SevenDrawRules();
                    break;
                case 3:
                    Euro();
                    break;
                case 4:
                    UI ui = new UI();
                    break;
                default:
                    Console.WriteLine("\nGood luck! :)\n");
                    Environment.Exit(0);
                    break;
            }

        }

        private void SevenDrawStory()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What is Scandinavian lottery?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The Scandinavian lottery is the seven-draw lottery.\n");
            Console.WriteLine("Instead of the word lottery, often the word lotto is used to describe the same game.\n" +
                "This is one of the most popular gambling games in Hungary.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Euro();
            }
            switch (number)
            {
                default:
                    Euro();
                    break;
            }
        }

        private void SevenDrawRules()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What are the rules of Scandinavian lottery?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The Scandinavian lottery is the seven-draw lottery.\n" +
                "You have to select seven numbers out of 35.\n");
            Console.WriteLine("You have to mark the numbered squares on a play slip,\n" +
                "then take the play slip to a lottery retailer.\n" +
                "The retailer enters your selection in the on-line terminal, which produces your game ticket.\n" +
                "The ticket, not the play slip, is the official receipt and must be presented and validated in the event of a win.\n");
            Console.WriteLine("You win the grand prize if you hit all the 7 numbers,\n" +
                "but win 6,5 and 4 hit you still can get smaller prizes.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Euro();
            }
            switch (number)
            {
                default:
                    Euro();
                    break;
            }
        }

        private int[] RandomNumbersA()
        {
            int[] numbers = new int[5];
            int n = 0;
            while (n < 5)
            {
                int number = 0;
                number = RandomNumberGeneratorA();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorA()
        {
            return r.Next(1, 51);
        }

        private int[] RandomNumbersB()
        {
            int[] numbers = new int[2];
            int n = 0;
            while (n < 2)
            {
                int number = 0;
                number = RandomNumberGeneratorB();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorB()
        {
            return r.Next(1, 11);
        }
    }
}
