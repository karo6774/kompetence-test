using System;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv første tal:");
            double first;
            while (!double.TryParse(Console.ReadLine(), out first))
                Console.WriteLine("Skriv et tal");

            Console.WriteLine("Skriv andet tal:");
            double second;
            while (!double.TryParse(Console.ReadLine(), out second))
                Console.WriteLine("Skriv et tal");

            var (addition, subtraction, multiplication, division, modulus) = CalculateNumbers(first, second);
            
            Console.WriteLine($"+: {addition}");
            Console.WriteLine($"-: {subtraction}");
            Console.WriteLine($"*: {multiplication}");
            Console.WriteLine($"/: {division}");
            Console.WriteLine($"%: {modulus}");
        }

        static (double, double, double, double, double) CalculateNumbers(double num1, double num2)
        {
            return (num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2);
        }
    }
}