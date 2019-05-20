using System.Collections.Generic;
using System.IO;
using System.Web;

namespace KarolineRasmussen.KompetenceTestS1.KompetenceDel
{
    public class Storage
    {
        public static Storage LoadFrom(string path)
        {
            var storage = new Storage(path);
            if (!File.Exists(path)) return storage;

            var lines = File.ReadLines(path);

            foreach (var line in lines)
            {
                var movie = DeserializeMovie(line);
                storage._movies.Add(movie);
            }

            return storage;
        }

        public static string SerializeMovie(Movie movie)
        {
            var parts = new[]
            {
                HttpUtility.UrlEncode(movie.Title),
                movie.ReleaseYear.ToString(),
                HttpUtility.UrlEncode(movie.Director),
                HttpUtility.UrlEncode(movie.Company)
            };
            return string.Join(',', parts);
        }

        public static Movie DeserializeMovie(string line)
        {
            var parts = line.Split(',');

            var title = HttpUtility.UrlDecode(parts[0]);
            var releaseYear = int.Parse(parts[1]);
            var director = HttpUtility.UrlDecode(parts[2]);
            var company = HttpUtility.UrlDecode(parts[3]);

            return new Movie(title, releaseYear, director, company);
        }

        private readonly string _path;
        private readonly List<Movie> _movies = new List<Movie>();

        public List<Movie> Movies => _movies;

        public Storage(string path)
        {
            _path = path;
        }

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
            File.WriteAllLines(_path, new[] {SerializeMovie(movie)});
        }

        public List<Movie> Search(string keyword)
        {
            return _movies.FindAll(it => it.Title.ToLower().Contains(keyword.ToLower()));
        }
    }
}