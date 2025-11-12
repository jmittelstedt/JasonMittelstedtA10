using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA10.Model.Person
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string HomeAddress { get; set; }

        protected Person(string firstName, string lastName, int id, string homeAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            HomeAddress = homeAddress;
        }

        public abstract string Details { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
