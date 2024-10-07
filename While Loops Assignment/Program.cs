using System.Diagnostics.CodeAnalysis;

namespace While_Loops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            bool done = false;
            Random generator = new Random();
            int flip;
            int points = 3;
            Console.WriteLine("Hello! Welcome to the Casino!");
            Console.WriteLine();
            Console.WriteLine();
            while (!done)
            {
                
                Console.WriteLine("You have " + points + " point(s).");
                Console.WriteLine();
                Console.WriteLine("Please choose heads or tails,");
                Console.WriteLine("'h' for heads. 't' for tails. 'q' to quit.");
                choice = Console.ReadLine().ToLower();
                flip = generator.Next(2);

                if (points == 0)
                {
                    Console.WriteLine("You have no points to wager.");
                    Console.WriteLine("You lose sorry. :(");
                    done = true;
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thanks for Playing");
                    Console.WriteLine("You finished with " + points + " points");
                    done = true;
                }

                else if ((choice != "h") && (choice != "t"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. -1 point");
                    Console.WriteLine();
                    Console.WriteLine();
                    points -= 1;
                }

                else if (choice == "h" && flip == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("That is correct. It was Heads!");
                    Console.WriteLine();
                    Console.WriteLine();
                    points += 1;
                }
                else if (choice == "t" && flip == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("That is correct. It was Tails!");
                    Console.WriteLine();
                    Console.WriteLine();
                    points += 1;
                }
                else if (choice == "h" && flip == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("That is incorrect. It was Tails.");
                    Console.WriteLine();
                    Console.WriteLine();
                    points -= 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That is incorrect. It was Heads.");
                    Console.WriteLine();
                    Console.WriteLine();
                    points -= 1;
                }
            }
            
            

        }
    }
}
