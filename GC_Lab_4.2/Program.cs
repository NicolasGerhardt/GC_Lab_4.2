using System;
using System.Collections.Generic;

namespace GC_Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Merch");
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("How to Train your dragon", "animated,"));
            movieList.Add(new Movie("", "animated,"));
            movieList.Add(new Movie("", "animated,"));
            movieList.Add(new Movie("", "animated,"));
            movieList.Add(new Movie("", "drama,"));
            movieList.Add(new Movie("", "drama,"));
            movieList.Add(new Movie("", "drama,"));
            movieList.Add(new Movie("", "drama,"));
            movieList.Add(new Movie("", "horror,"));
            movieList.Add(new Movie("", "horror,"));
            movieList.Add(new Movie("", "horror,"));
            movieList.Add(new Movie("", "horror,"));
            movieList.Add(new Movie("", "scifi."));
            movieList.Add(new Movie("", "scifi."));
            movieList.Add(new Movie("", "scifi."));
            movieList.Add(new Movie("", "scifi."));
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
