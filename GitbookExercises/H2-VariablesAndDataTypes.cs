using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitbookExercises
{
    internal class H2_VariablesAndDataTypes
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("| Chapter : Variables & Datatypes |");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();
            int choice;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Which exercise would you like to view? ");
                Console.WriteLine("                                       ");
                Console.WriteLine("Make your choice:                      ");
                Console.WriteLine("\t0. Back to main menu           ");
                Console.WriteLine("\t1. AddUp                       ");
                Console.WriteLine("\t2. FuelConsumption              ");
                Console.WriteLine("\t3.             ");
                Console.WriteLine("\t4.                ");
                Console.ResetColor();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        AddUp();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        FuelConsumption();
                        break;
                    case 3:
                        Console.Clear();
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("! Unrecognized input value. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        public static void AddUp()
        {
            Console.WriteLine("What's the first number?");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What's the second number?");
            int nr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"The sum of both number is {nr1 + nr2}");
        }

        public static void FuelConsumption()
        {

        }
    }
}
