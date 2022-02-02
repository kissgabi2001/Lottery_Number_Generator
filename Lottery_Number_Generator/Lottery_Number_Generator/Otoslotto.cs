using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Number_Generator
{
    class Otoslotto
    {
        private static Random r;
        public Otoslotto()
        {
            r = new Random();
            FiveDraw();
        }

        public void FiveDraw()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "'Ötöslottó'";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            string t = "If you want to know more about the game, choose an option!";

            Console.Write("\nYour random numbers:\t");
            int[] numbers = RandomNumbers();
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            Console.WriteLine(t + "\n" +
                "\n\t[ 1. ] What is 'Ötöslottó'?\n" +
                "\n\t[ 2. ] What are the rules?\n");
            Console.WriteLine("Do you want to generate new random numbers?\n" +
                "\n\t[ 3. ] Generate new random numbers\n");
            Console.WriteLine("Menu options:\n" +
                "\n\t[ 4. ] Back to the main menu\n" +
                "\n\t[ PRESS ANY KEY ] Close the program");

            for (int i = 0; i < t.Length; i++)
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
                    FiveDrawStory();
                    break;
                case 2:
                    FiveDrawRules();
                    break;
                case 3:
                    FiveDraw();
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

        private void FiveDrawStory()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What is 'Ötöslottó'?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The 'Ötöslottó' is the five-draw lottery.\n");
            Console.WriteLine("Instead of the word lottery, often the word lotto is used to describe the same game.\n" +
                "This is one of the most popular gambling games in Hungary,\n" +
                "but with this lottery type your chance to win the grand prize is the slightest.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                FiveDraw();
            }
            switch (number)
            {
                default:
                    FiveDraw();
                    break;
            }
        }

        private void FiveDrawRules()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What are the rules of 'Ötöslottó'?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("The 'Ötöslottó' is the five-draw lottery.\n" +
                "You have to select five numbers out of 90.\n");
            Console.WriteLine("You have to mark the numbered squares on a play slip,\n" +
                "then take the play slip to a lottery retailer.\n" +
                "The retailer enters your selection in the on-line terminal, which produces your game ticket.\n" +
                "The ticket, not the play slip, is the official receipt and must be presented and validated in the event of a win.\n");
            Console.WriteLine("You win the grand prize if you hit all the 5 numbers,\n" +
                "but win 4,3 and 2 hit you still can get smaller prizes.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                FiveDraw();
            }
            switch (number)
            {
                default:
                    FiveDraw();
                    break;
            }
        }

        private int[] RandomNumbers()
        {
            int[] numbers = new int[5];
            int n = 0;
            while (n < 5)
            {
                int number = 0;
                number = RandomNumberGenerator();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }
            
            return numbers;
        }

        private int RandomNumberGenerator()
        {
            return r.Next(1, 91);
        }
    }
}
