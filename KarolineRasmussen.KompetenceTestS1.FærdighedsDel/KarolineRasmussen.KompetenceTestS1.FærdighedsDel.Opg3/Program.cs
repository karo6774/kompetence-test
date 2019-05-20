using System;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var num = rand.Next(1, 11);
            
            Console.WriteLine("Gæt et tal mellem 1 og 10.");
            while (true)
            {
                int guess;
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10)
                    Console.WriteLine("Skriv et helt tal mellem 1 og 10");
                if (guess == num)
                    break;
                else
                    Console.WriteLine("Forkert. Prøv igen.");
            }
        }
    }
}