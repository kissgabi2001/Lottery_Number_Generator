using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Number_Generator
{
    class Keno
    {
        private static Random r;
        public Keno()
        {
            r = new Random();
            KenoLottery();
        }

        public void KenoLottery()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "'Kenó'";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            string t = "If you want to know more about the game, choose an option!";

            Console.Write("\nYour numbers to the 10 number played game:\t\t");
            int[] numbersTen = RandomNumbersTen();
            Array.Sort(numbersTen);
            for (int i = 0; i < numbersTen.Length; i++)
            {
                Console.Write(numbersTen[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 9 number played game:\t");
            int[] numbersNine = RandomNumbersNine();
            Array.Sort(numbersNine);
            for (int i = 0; i < numbersNine.Length; i++)
            {
                Console.Write(numbersNine[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 8 number played game:\t\t");
            int[] numbersEight = RandomNumbersEight();
            Array.Sort(numbersEight);
            for (int i = 0; i < numbersEight.Length; i++)
            {
                Console.Write(numbersEight[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 7 number played game:\t");
            int[] numbersSeven = RandomNumbersSeven();
            Array.Sort(numbersSeven);
            for (int i = 0; i < numbersSeven.Length; i++)
            {
                Console.Write(numbersSeven[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 6 number played game:\t\t");
            int[] numbersSix = RandomNumbersSix();
            Array.Sort(numbersSix);
            for (int i = 0; i < numbersSix.Length; i++)
            {
                Console.Write(numbersSix[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 5 number played game:\t\t");
            int[] numbersFive = RandomNumbersFive();
            Array.Sort(numbersFive);
            for (int i = 0; i < numbersFive.Length; i++)
            {
                Console.Write(numbersFive[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 4 number played game:\t\t");
            int[] numbersFour = RandomNumbersFour();
            Array.Sort(numbersFour);
            for (int i = 0; i < numbersFour.Length; i++)
            {
                Console.Write(numbersFour[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 3 number played game:\t\t");
            int[] numbersThree = RandomNumbersThree();
            Array.Sort(numbersThree);
            for (int i = 0; i < numbersThree.Length; i++)
            {
                Console.Write(numbersThree[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 2 number played game:\t\t");
            int[] numbersTwo = RandomNumbersTwo();
            Array.Sort(numbersTwo);
            for (int i = 0; i < numbersTwo.Length; i++)
            {
                Console.Write(numbersTwo[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("\nYour numbers to the 1 number played game:\t\t");
            int[] numbersOne = RandomNumbersOne();
            Array.Sort(numbersOne);
            for (int i = 0; i < numbersOne.Length; i++)
            {
                Console.Write(numbersOne[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < t.Length + 10; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            Console.WriteLine(t + "\n" +
                "\n\t[ 1. ] What is 'Kenó'?\n" +
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
                    KenoStory();
                    break;
                case 2:
                    KenoRules();
                    break;
                case 3:
                    KenoLottery();
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

        private void KenoStory()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What is 'Kenó'?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("In 'Kenó' you decide how many numbers do you want to choose, between 1 and 10.\n" +
                "You have to select those 1-10 numbers out of 80.\n");
            Console.WriteLine("This is a daily game, they draw 20 numbers every day.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                KenoLottery();
            }
            switch (number)
            {
                default:
                    KenoLottery();
                    break;
            }
        }

        private void KenoRules()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string text = "What are the rules of 'Kenó'?";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("In 'Kenó' you decide how many numbers do you want to choose, between 1 and 10.\n");
            Console.WriteLine("The goal is to hit as many of the 20 numbers drawn daily as possible.\n" +
                "In game types ten, nine and eight (so if you played at least 8 numbers) you have to hit at least 5 numbers.\n" +
                "In game types seven and six you have to hit at least 4 numbers,\n" +
                "in the five and four at least 3 numbers,\n" +
                "in the three and two at least 2 numbers,\n" +
                "and in the one you have to hit that one to the prize.\n");
            Console.WriteLine("[ BACK ] - PRESS ANY KEY");

            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                KenoLottery();
            }
            switch (number)
            {
                default:
                    KenoLottery();
                    break;
            }
        }

        private int[] RandomNumbersOne()
        {
            int[] numbers = new int[1];
            int n = 0;
            while (n < 1)
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

        private int[] RandomNumbersTwo()
        {
            int[] numbers = new int[2];
            int n = 0;
            while (n < 2)
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

        private int[] RandomNumbersThree()
        {
            int[] numbers = new int[3];
            int n = 0;
            while (n < 3)
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

        private int[] RandomNumbersFour()
        {
            int[] numbers = new int[4];
            int n = 0;
            while (n < 4)
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

        private int[] RandomNumbersFive()
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

        private int[] RandomNumbersSix()
        {
            int[] numbers = new int[6];
            int n = 0;
            while (n < 6)
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

        private int[] RandomNumbersSeven()
        {
            int[] numbers = new int[7];
            int n = 0;
            while (n < 7)
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

        private int[] RandomNumbersEight()
        {
            int[] numbers = new int[8];
            int n = 0;
            while (n < 8)
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

        private int[] RandomNumbersNine()
        {
            int[] numbers = new int[9];
            int n = 0;
            while (n < 9)
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

        private int[] RandomNumbersTen()
        {
            int[] numbers = new int[10];
            int n = 0;
            while (n < 10)
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
            return r.Next(1, 16);
        }
    }
}
