using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitbookExercises
{
    internal class H1_WorkingWithVS
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("| Chapter 1: Working with Visual Studio |");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();
            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Which exercise would you like to view? ");
                Console.WriteLine("                                       ");
                Console.WriteLine("Make your choice:                      ");
                Console.WriteLine("\t0. Back to main menu           ");
                Console.WriteLine("\t1. MyFirstProgram              ");
                Console.WriteLine("\t2. Rubbish                     ");
                Console.WriteLine("\t3. ColoredRubbish              ");
                Console.WriteLine("\t4. AddressCard                 ");
                Console.ResetColor();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        MyFirstProgram();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Rubbish();
                        break;
                    case 3:
                        Console.Clear();
                        ColoredRubbish();
                        break;
                    case 4:
                        Console.Clear();
                        AddressCard();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("! Unrecognized input value. Please try again.");
                        break;
                }
            } while (choice != 0);
        }
        public static void MyFirstProgram()
        {
            Console.WriteLine("This is my first C#-program.");
            Console.WriteLine("............................");
            Console.Write("Type your first name: ");
            string name = Console.ReadLine();
            Console.Write("Type your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"So your name is: {lastName} {name}\nOr: {name} {lastName}");
        }

        public static void Rubbish()
        {
            Console.WriteLine("What's your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What's your favorite dish?");
            string favDish = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What's your favorite car?");
            string favCar = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What's your favorite movie?");
            string favMovie = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What's your favorite book?");
            string favBook = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Your favorite color is {favDish}.\nYou love to eat {favCar}.\nYour favorite movie is {favBook} and your favorite book is {favMovie}.");
            Console.WriteLine();
        }

        public static void ColoredRubbish()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What's your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("What's your favorite dish?");
            string favDish = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What's your favorite car?");
            string favCar = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What's your favorite movie?");
            string favMovie = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What's your favorite book?");
            string favBook = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your favorite color is {favDish}.\nYou love to eat {favCar}.\nYour favorite movie is {favBook} and your favorite book is {favMovie}.");
            Console.WriteLine();
        }

        public static void AddressCard()
        {
            Console.Write("What's your first name?: ");
            string fName = Console.ReadLine();
            Console.Write("What's your last name?: ");
            string lName = Console.ReadLine();
            Console.Write("What's your streetname?: ");
            string streetName = Console.ReadLine();
            Console.Write("What's your housenumber?: ");
            int houseNr = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's your zip code?: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("What city do you live in?: ");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("| AddressCard |");
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine();
            Console.WriteLine($"{fName} {lName}");
            Console.WriteLine($"{streetName} {houseNr}");
            Console.WriteLine($"{zip} {city}");
            Console.WriteLine();
        }
    }
}
