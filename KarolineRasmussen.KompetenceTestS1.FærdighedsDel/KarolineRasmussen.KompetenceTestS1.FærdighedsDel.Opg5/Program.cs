using System;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg5
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("John", "Doe", new DateTime(1986, 11, 30));
            var person2 = new Person("Jane", "Doe", new DateTime(1990, 5, 12));
            var person1Age = person1.CalculateAge();
            var person2Age = person2.CalculateAge();
        }
    }
}