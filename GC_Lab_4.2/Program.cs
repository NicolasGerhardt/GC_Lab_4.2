using System;

namespace GC_Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Merch");

            do
            {

            } while (SearchAgainPrompt());
        }

        private static bool SearchAgainPrompt()
        {
            do
            {
                Console.Write("Do you want to search again?");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if ("Yy".Contains(key))
                {
                    return true;
                }
                else if ("Nn".Contains(key))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("type y for yes or n for no");
                }
            } while (true);
        }
    }
}
