using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieapp_with_Folders.Models
{
    internal class Menu
    {
        MovieManager moviemanager = new MovieManager();
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome To Simple Movies App");
            Console.WriteLine();

            bool check = true;

            while (check)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Display Movies");
                Console.WriteLine("2. Add Movies");
                Console.WriteLine("3. Clear All");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());
                check = Choices(choice);
            }
        }

        private bool Choices(int choice)
        {
            switch (choice)
            {
                case 1:
                    PrintDetails();
                    return true;
                case 2:
                    AddMovies();
                    return true;
                case 3:
                    ClearMovies();
                    return true;
                case 4:
                    SaveAndExit();
                    return false;
                default:
                    Console.WriteLine("Invalid Input");
                    return true;
            }
        }
        public static void PrintDetails()
        {

            MovieManager.PrintDetails();
        }

        public static void AddMovies()
        {

            Console.WriteLine("Enter the Movie ID");
            int movieId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Movie Name");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter the Movie Genre");
            string movieGenre = Console.ReadLine();
            Console.WriteLine("Enter the Movie Year");
            int movieYear = int.Parse(Console.ReadLine());
            bool success = MovieManager.AddMovies(movieId, movieName, movieGenre, movieYear);
            if (!success)
            {
                Console.WriteLine("Movie list is full, you cannot add more movies.");
            }



        }
        public static void ClearMovies()
        {
            MovieManager.ClearMovies();
            Console.WriteLine("All Movies Cleared.");
        }
        public static void SaveAndExit()
        {
            MovieManager.SaveAndExit();
            Console.WriteLine("bye");
        }
    }
}

