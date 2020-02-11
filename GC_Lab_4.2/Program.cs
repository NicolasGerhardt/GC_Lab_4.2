using System;
using System.Collections.Generic;

namespace GC_Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Muncher!!!");
            List<Movie> movieList = PopulateMovieListData();

            do
            {
                string searchString = GetSearchStringFromUser();
                List<Movie> searchResults = SearchForCategoryInMovieList(searchString, movieList);
                ShowMovieList($"Results for \'{searchString}\'",searchResults);

            } while (SearchAgainPrompt());
        }

        private static List<Movie> SearchForCategoryInMovieList(string searchString, List<Movie> movieList)
        {
            var resultsList = new List<Movie>();

            foreach (Movie movie in movieList)
            {
                if (movie.Category.ToString().Contains(searchString) )
                {
                    resultsList.Add(movie);
                }
            }

            return resultsList;
        }

        private static string GetSearchStringFromUser()
        {
            bool validCategory = false;
            string input = string.Empty;

            while (!validCategory)
            {
                Console.Write("What movie category do you want to look for?\n> ");
                input = Console.ReadLine().ToLower();


                if (Movie.MovieCategories.animated.ToString().Contains(input) ||
                    Movie.MovieCategories.drama.ToString().Contains(input) ||
                    Movie.MovieCategories.horror.ToString().Contains(input) ||
                    Movie.MovieCategories.scifi.ToString().Contains(input))
                {
                    validCategory = true;
                }
                else
                {
                    Console.WriteLine($"Please choose from one of following: ");
                    Console.WriteLine($" - {Movie.MovieCategories.animated}");
                    Console.WriteLine($" - {Movie.MovieCategories.drama}");
                    Console.WriteLine($" - {Movie.MovieCategories.horror}");
                    Console.WriteLine($" - {Movie.MovieCategories.scifi}");
                    Console.WriteLine();
                }


            }
            Console.WriteLine();
            return input;
        }

        private static void ShowMovieList(string listTitle, List<Movie> movieList)
        {
            Console.WriteLine($"|============");
            Console.WriteLine($"| {listTitle} ");
            Console.WriteLine($"|============");
            foreach (var movie in movieList)
            {
                Console.WriteLine($"|- {movie.Title}");
            }
            Console.WriteLine($"|============");
            Console.WriteLine();
        }

        private static List<Movie> PopulateMovieListData()
        {
            var movieList = new List<Movie>();
            movieList.Add(new Movie("How to Train your dragon", Movie.MovieCategories.animated));
            movieList.Add(new Movie("Coco", Movie.MovieCategories.animated));
            movieList.Add(new Movie("Spiderman: Into the Spiderverse", Movie.MovieCategories.animated));
            movieList.Add(new Movie("Zootopia", Movie.MovieCategories.animated));
            movieList.Add(new Movie("Joker", Movie.MovieCategories.drama));
            movieList.Add(new Movie("Rocketman", Movie.MovieCategories.drama));
            movieList.Add(new Movie("Bohemian Rhapsody", Movie.MovieCategories.drama));
            movieList.Add(new Movie("Kings Speech", Movie.MovieCategories.drama));
            movieList.Add(new Movie("Us", Movie.MovieCategories.horror));
            movieList.Add(new Movie("Get Out", Movie.MovieCategories.horror));
            movieList.Add(new Movie("The Shining", Movie.MovieCategories.horror));
            movieList.Add(new Movie("Carrie", Movie.MovieCategories.horror));
            movieList.Add(new Movie("Annihilation", Movie.MovieCategories.scifi));
            movieList.Add(new Movie("Ex Machina", Movie.MovieCategories.scifi));
            movieList.Add(new Movie("Arrival", Movie.MovieCategories.scifi));
            movieList.Add(new Movie("2001: A Space Odyssey", Movie.MovieCategories.scifi));
            return movieList;
        }

        private static bool SearchAgainPrompt()
        {
            do
            {
                Console.Write("Do you want to search again? ");
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
