using System;
using System.IO;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg6
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Path = "tekst.txt";

            while (true)
            {
                Console.WriteLine("Vælg en funktion");
                Console.WriteLine(" 1 - Udskriv filens indhold");
                Console.WriteLine(" 2 - Skriv til filen");
                Console.WriteLine(" 3 - Exit");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                    Console.WriteLine("Skriv et helt tal mellem 1 og 3");

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        var contents = File.Exists(Path) ? File.ReadAllText(Path) : "";

                        Console.WriteLine(contents);
                        Console.WriteLine();
                        Console.WriteLine("Tryk på en knap for at gå tilbage...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Skriv noget som skal tilføjes til files");
                        var line = Console.ReadLine();
                        using (var writer = File.AppendText(Path))
                            writer.WriteLine(line);
                        break;
                    case 3:
                        return;
                }

                Console.WriteLine();
            }
        }
    }
}