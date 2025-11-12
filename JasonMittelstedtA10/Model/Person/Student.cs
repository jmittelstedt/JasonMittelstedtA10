using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA10.Model.Person
{
    public class Student : Person
    {
        private string major;
        private string minor;

        public string Major
        {
            get => major;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Major), "Major cannot be null.");
                major = string.IsNullOrWhiteSpace(value) ? "Undeclared" : value;
            }
        }

        public string Minor
        {
            get => minor;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Minor), "Minor cannot be null.");
                minor = string.IsNullOrWhiteSpace(value) ? "Undeclared" : value;
            }
        }

        public Student(string firstName, string lastName, int id, string homeAddress, string major, string minor) : base(firstName, lastName, id, homeAddress)
        {
            Major = major;
            Minor = minor;
        }

        public override string Details
        {
            get
            {
                string result = $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nMajor: {Major}";
                if (Minor != "Undeclared")
                    result += $", Minor: {Minor}";
                return result;
            }
        }
    }
}
