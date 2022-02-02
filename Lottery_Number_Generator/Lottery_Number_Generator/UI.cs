using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_Number_Generator
{
    class UI
    {
        public UI()
        {
            Menu();
        }

        private void Menu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Lottery Number Generator";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.WriteLine("\nThis program generates random numbers to all the lottery types people plays in Hungary.\n" +
                "From the options you can choose the game type you want to play.\n" +
                "If you want to know more about the one of the games, you can read its description and rules after you have chosen.\n" +
                "The type of the games:\n");
            Console.WriteLine("\t[ 1. ] 'Ötöslottó'\n" +
                "\n" +
                "\t[ 2. ] 'Hatoslottó'\n" +
                "\n" +
                "\t[ 3. ] Scandinavian lottery\n" +
                "\n" +
                "\t[ 4. ] Eurojackpot\n" +
                "\n" +
                "\t[ 5. ] Luxor\n" +
                "\n" +
                "\t[ 6. ] 'Kenó'\n");
            Console.WriteLine("Menu options:\n" +
                "\n\t[ PRESS ANY KEY ] Close the program\n");
            string t = "Please, select the type of lottery you want to play!";
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n" + t + "\nThe number of the game:");

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
                    Otoslotto otoslotto = new Otoslotto();
                    break;
                case 2:
                    Hatoslotto hatoslotto = new Hatoslotto();
                    break;
                case 3:
                    //Scandinavian();
                    break;
                case 4:
                    //Eurojackpot();
                    break;
                case 5:
                    //Luxor();
                    break;
                case 6:
                    //Keno();
                    break;
                default:
                    Console.WriteLine("Good luck! :)\n");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
