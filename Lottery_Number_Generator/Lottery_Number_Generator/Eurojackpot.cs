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
            string text = "Eurojackpot";
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
                "\n\t[ 1. ] What is Eurojackpot?\n" +
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

            string text = "What is Eurojackpot?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The Eurojackpot is a little bit different than the other lotteries before.\n");
            Console.WriteLine("Eurojackpot is a transnational European lottery.\n" +
                "The countries participating in the lottery are: Croatia, Czech Republic, Denmark, Estonia, Finland, Germany, Hungary,\n" +
                "Iceland, Italy, Latvia, Lithuania, Netherlands, Norway, Poland, Slovakia, Slovenia, Spain and Sweden.\n");
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

            string text = "What are the rules of Eurojackpot?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The Eurojacpot is a five plus two-number draw lottery.\n");
            Console.WriteLine("The goal is to match 5 correct numbers out of 50 plus another 2 supplementary numbers out of ten.\n" +
                "You have to mark 5 numbers in the field 'A' and another 2 in the field 'B'.\n" +
                "You can get a prize when you hit total of at least 3 numbers.\n");
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
