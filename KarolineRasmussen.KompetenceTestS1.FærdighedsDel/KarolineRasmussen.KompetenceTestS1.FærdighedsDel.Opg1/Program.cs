using System;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dit fornavn:");
            string first = Console.ReadLine();
            Console.WriteLine("Skriv dit efternavn:");
            string last = Console.ReadLine();

            Console.WriteLine($"Du hedder {first} {last}");
        }
    }
}