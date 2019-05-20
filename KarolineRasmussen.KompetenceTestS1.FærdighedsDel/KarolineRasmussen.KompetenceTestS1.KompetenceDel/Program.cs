using System;

namespace KarolineRasmussen.KompetenceTestS1.KompetenceDel
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = Storage.LoadFrom("film.txt");

            while (true)
            {
                Console.WriteLine("Vælg en funktion:");
                Console.WriteLine(" 1 - Tilføj en film");
                Console.WriteLine(" 2 - Vis alle film");
                Console.WriteLine(" 3 - Søg");
                Console.WriteLine(" 4 - Exit");

                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                    Console.WriteLine("Skriv et helt tal mellem 1 og 4");

                switch (choice)
                {
                    case 1:
                        AddNewMovie(storage);
                        break;
                    case 2:
                        ListAllMovies(storage);
                        break;
                    case 3:
                        SearchMovies(storage);
                        break;
                    default:
                        return;
                }

                Console.Clear();
            }
        }

        static void AddNewMovie(Storage storage)
        {
            Console.Clear();

            Console.WriteLine("Skriv titlen på filmen");
            var title = Console.ReadLine();

            Console.WriteLine("Skriv instruktøren på filmen");
            var director = Console.ReadLine();

            Console.WriteLine("Skriv udgivelsesåret på filmen");
            int releaseYear;
            while (!int.TryParse(Console.ReadLine(), out releaseYear) || releaseYear < 0)
                Console.WriteLine("Skriv et helt tal som er større end nul");

            Console.WriteLine("Skriv filmselskabet på filmen");
            var company = Console.ReadLine();

            var movie = new Movie(title, releaseYear, director, company);
            storage.AddMovie(movie);
            
            Console.WriteLine();
            Console.WriteLine($"Tilføjet {movie}");

            Console.WriteLine();
            Console.WriteLine("Tryk på en knap for at gå tilbage til menuen...");
            Console.ReadKey();
        }

        static void ListAllMovies(Storage storage)
        {
            Console.Clear();

            Console.WriteLine("Alle film:");
            storage.Movies.ForEach(it => Console.WriteLine($" {it}"));

            Console.WriteLine();
            Console.WriteLine("Tryk på en knap for at gå tilbage til menuen...");
            Console.ReadKey();
        }

        static void SearchMovies(Storage storage)
        {
            Console.Clear();

            Console.WriteLine("Søg i filmtitler");
            var keyword = Console.ReadLine();

            var movies = storage.Search(keyword);
            if (movies.Count > 0)
            {
                Console.WriteLine("Fandt følgende film:");
                movies.ForEach(it => Console.WriteLine($" {it}"));
            }
            else
                Console.WriteLine("Fandt ingen film");
            
            Console.WriteLine();
            Console.WriteLine("Tryk på en knap for at gå tilbage til menuen...");
            Console.ReadKey();
        }
    }
}