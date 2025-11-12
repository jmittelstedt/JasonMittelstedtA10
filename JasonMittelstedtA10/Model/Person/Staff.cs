using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA10.Model.Person
{
    public class Staff : Person
    {
        public string Title { get; set; }

        // Base constructor chaining
        public Staff(string firstName, string lastName, int id, string homeAddress, string title)
            : base(firstName, lastName, id, homeAddress)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null or empty.", nameof(title));
            Title = title;
        }

        // Overloaded constructors
        public Staff(string firstName, string lastName, int id, string homeAddress)
            : this(firstName, lastName, id, homeAddress, "Unknown") { }

        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID – {Id}; Title – {Title}";
        }

        public override string Details =>
            $"{FirstName} {LastName} ({Id}/{Title})\n{HomeAddress}";
    }
}
