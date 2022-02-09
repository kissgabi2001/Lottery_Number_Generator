using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Number_Generator
{
    class Luxor
    {
        private static Random r;
        public Luxor()
        {
            r = new Random();
            Lux();
        }

        public void Lux()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Luxor";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            string t = "If you want to know more about the game, choose an option!";

            Console.Write("\nThe first 4 random numbers are:\t\t");
            int[] numbersFirst = RandomNumbersFirst();
            Array.Sort(numbersFirst);
            for (int i = 0; i < numbersFirst.Length; i++)
            {
                Console.Write(numbersFirst[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nThe second 4 random numbers are:\t");
            int[] numbersSecond = RandomNumbersSecond();
            Array.Sort(numbersSecond);
            for (int i = 0; i < numbersSecond.Length; i++)
            {
                Console.Write(numbersSecond[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nThe third 4 random numbers are:\t\t");
            int[] numbersThird = RandomNumbersThird();
            Array.Sort(numbersThird);
            for (int i = 0; i < numbersThird.Length; i++)
            {
                Console.Write(numbersThird[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nThe fourth 4 random numbers are:\t");
            int[] numbersFourth = RandomNumbersFourth();
            Array.Sort(numbersFourth);
            for (int i = 0; i < numbersFourth.Length; i++)
            {
                Console.Write(numbersFourth[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nThe fifth 4 random numbers are:\t\t");
            int[] numbersFifth = RandomNumbersFifth();
            Array.Sort(numbersFifth);
            for (int i = 0; i < numbersFifth.Length; i++)
            {
                Console.Write(numbersFifth[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < t.Length + 10; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            Console.WriteLine(t + "\n" +
                "\n\t[ 1. ] What is Luxor?\n" +
                "\n\t[ 2. ] What are the rules?\n");
            Console.WriteLine("Do you want to generate new random numbers?\n" +
                "\n\t[ 3. ] Generate new random numbers\n");
            Console.WriteLine("Menu options:\n" +
                "\n\t[ 4. ] Back to the main menu\n" +
                "\n\t[ PRESS ANY KEY ] Close the program");

            for (int i = 0; i < t.Length + 10; i++)
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
                    LuxorStory();
                    break;
                case 2:
                    LuxorRules();
                    break;
                case 3:
                    Lux();
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

        private void LuxorStory()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What is Luxor?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("Luxor is the 5 times four-number (totally 20 numbers) draw lottery.\n" +
                "The numbers are in 5 clumns (1-15, 16-30, 31-45, 46-60, 61-75).\n");
            Console.WriteLine("\nAfter you have marked 5x4 numbers,\n" +
                "the computer generates a cube with your numbers and with 4 extra symbols - bonus sygns.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Lux();
            }
            switch (number)
            {
                default:
                    Lux();
                    break;
            }
        }

        private void LuxorRules()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What are the rules of Luxor?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("Luxor is the 5 times four-number (totally 20 numbers) draw lottery.\n");
            Console.WriteLine("The numbers are in 5 clumns (1-15, 16-30, 31-45, 46-60, 61-75).\n" +
                "You have to select 4 numbers from each column (5x4 numbers).\n");
            Console.WriteLine("After you have marked 5x4 numbers,\n" +
                "the computer generates a cube with your numbers and with 4 extra symbols - bonus sygns.\n");
            Console.WriteLine("You can win in different ways:\n" +
                "\t - You hit all the numbers in the middle, in the 3x3 cube.\t= Pitcure hit\n" +
                "\t - You hit all the numbers at the edge of the cube.\t= Frame hit\n" +
                "\t - You hit all the numbers.\n\t= Direct hit");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Lux();
            }
            switch (number)
            {
                default:
                    Lux();
                    break;
            }
        }

        private int[] RandomNumbersFirst()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
            {
                int number = 0;
                number = RandomNumberGeneratorFirst();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorFirst()
        {
            return r.Next(1, 16);
        }

        private int[] RandomNumbersSecond()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
            {
                int number = 0;
                number = RandomNumberGeneratorSecond();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorSecond()
        {
            return r.Next(16, 31);
        }

        private int[] RandomNumbersThird()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
            {
                int number = 0;
                number = RandomNumberGeneratorThird();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorThird()
        {
            return r.Next(31, 46);
        }

        private int[] RandomNumbersFourth()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
            {
                int number = 0;
                number = RandomNumberGeneratorFourth();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorFourth()
        {
            return r.Next(46, 61);
        }

        private int[] RandomNumbersFifth()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
            {
                int number = 0;
                number = RandomNumberGeneratorFifth();
                if (!numbers.Contains(number))
                {
                    numbers[n] += number;
                    n++;
                }
            }

            return numbers;
        }

        private int RandomNumberGeneratorFifth()
        {
            return r.Next(61, 76);
        }
    }
}
