using System;

namespace KarolineRasmussen.KompetenceTestS1.FærdighedsDel.Opg5
{
    public class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly DateTime _birthdate;

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public DateTime Birthdate => _birthdate;

        public Person(string firstName, string lastName, DateTime birthdate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthdate = birthdate;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - _birthdate.Year -
                   (DateTime.Now.DayOfYear < _birthdate.DayOfYear 
                ? 1
                : 0);
        }
    }
}