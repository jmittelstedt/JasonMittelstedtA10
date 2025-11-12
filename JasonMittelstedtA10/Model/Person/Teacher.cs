using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA10.Model.Person
{
    public class Teacher : Person
    {
        private string department;
        public string Department
        {
            get => department;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Department), "Department cannot be null.");
                department = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
            }
        }

        public Teacher(string firstName, string lastName, int id, string homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department;
        }

        public override string Details =>
            $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nDepartment: {Department}";
    }
}
