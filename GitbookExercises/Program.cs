namespace GitbookExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            string batLogo = @"
              /\                 /\
             / \'._   (\_/)   _.'/ \
            /_.''._'--('.')--'_.''._\
            | \_ / `;=/ "" \=;` \ _/ |
             \/ `\__|`\___/`|__/`  \/
                     \(/|\)/";

            Console.WriteLine(batLogo);
            Console.WriteLine();

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("| Welcome to my solutions to the exercises  |");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();

            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Which chapter would you like to view?  ");
                Console.WriteLine("                                       ");
                Console.WriteLine("Make your choice:                      ");
                Console.WriteLine("\t0. Quit program                ");
                Console.WriteLine("\t1. Working with Visual Studio  ");
                Console.WriteLine("\t2. VariablesAndDataTypes       ");
                Console.ResetColor();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(batLogo);
                        Console.WriteLine();
                        Console.WriteLine("Quitting program...");
                        Console.ResetColor();
                        break;
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(batLogo);
                        Console.ResetColor();
                        Console.WriteLine();
                        H1_WorkingWithVS.Menu();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(batLogo);
                        Console.ResetColor();
                        Console.WriteLine();
                        H2_VariablesAndDataTypes.Menu();
                        Console.WriteLine();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("! Unrecognized input value. Please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
}

