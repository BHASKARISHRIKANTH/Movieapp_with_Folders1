using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieapp_with_Folders.Models
{
    internal class MovieManager
    {
        private static Movie[] movies = Serializer.DeserializeMovies();
        private static int movieSize = GetMovieSize();

        public static void PrintDetails()
        {

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    Console.WriteLine(movies[i].DisplayMovie());
                }
            }
        }

        public static bool AddMovies(int movieId, string movieName, string movieGenre, int movieYear)
        {
            if (movieSize >= 5)
            {

                return false;

            }


            movies[movieSize] = new Movie(movieId, movieName, movieGenre, movieYear);
            movieSize++;
            Serializer.SerializeMovies(movies);
            return true;
            

        }



        public static void ClearMovies()
        {
            movies = new Movie[5];
            movieSize = 0;
            Serializer.SerializeMovies(movies);

        }

        public static void SaveAndExit()
        {

            Environment.Exit(0);


        }
        private static int GetMovieSize()
        {
            int size = 0;
            foreach (var movie in movies)
            {
                if (movie != null) size++;
            }
            return size;
        }
    }
}
