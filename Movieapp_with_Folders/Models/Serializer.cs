using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Movieapp_with_Folders.Models
{
    internal class Serializer
    {
        public static Movie[] DeserializeMovies()
        {
            var filePath = ConfigurationManager.AppSettings["MyPath"].ToString();

            if (File.Exists(filePath))
            {
                string moviesData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Movie[]>(moviesData);
            }
            return new Movie[5];
        }

        public static void SerializeMovies(Movie[] movies)
        {
            var filePath = ConfigurationManager.AppSettings["MyPath"].ToString();
            string jsonData = JsonSerializer.Serialize(movies);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
