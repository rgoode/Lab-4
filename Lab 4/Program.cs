using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");

            Console.WriteLine("There are 10 movies in this list.");


            Movie movie1 = new Movie("Star Wars", "scifi");
            Movie movie2 = new Movie("Encanto", "animated");
            Movie movie3 = new Movie("Girl Interupted", "drama");
            Movie movie4 = new Movie("It Follows", "horror");
            Movie movie5 = new Movie("E.T The Extra-Terrestrial", "scifi");
            Movie movie6 = new Movie("Little Mermaid", "animated");
            Movie movie7 = new Movie("Tallulah", "drama");
            Movie movie8 = new Movie("Evil Dead", "horror");
            Movie movie9 = new Movie("Coco", "animated");
            Movie movie10 = new Movie("Scary Stories To Tell In The Dark", "horror");



            List<Movie> movies = new List<Movie>();
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            movies.Add(movie8);
            movies.Add(movie9);
            movies.Add(movie10);

            movies = movies.OrderBy(movie => movie.Title).ToList();





            string continue_search = "y";
            do
            {

                Console.WriteLine("What category are you interested in?");
                string movie_category = Console.ReadLine().ToLower();



                List<Movie> filteredMovies = movies.Where(movie => movie_category == movie.Category.ToLower()).ToList();
                foreach (Movie movie in filteredMovies)
                {
                    Console.WriteLine(movie.Title);

                }
                Console.WriteLine("Continue? y/n");
                continue_search = Console.ReadLine();


            } while (continue_search == "y");
            Console.WriteLine("Enjoy your movie!");

        }


        class Movie
        {
            public Movie(string title, string category)
            {
                _movieTitle = title;
                _movieCategory = category;

            }

            private string _movieTitle;
            private string _movieCategory;


            public string Title
            {
                get
                {
                    return _movieTitle;
                }
                set
                {
                    _movieTitle = value;
                }

            }
            public string Category
            {
                get
                {
                    return _movieCategory;
                }
                set
                {
                    _movieTitle = value;
                }

            }

        }

    }
}

