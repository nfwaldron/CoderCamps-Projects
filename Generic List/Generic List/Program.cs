using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Star Wars"},
                new Movie {Title="King Kong"},
                new Movie {Title="Memento"}
            };

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
            

        }
    }
}
