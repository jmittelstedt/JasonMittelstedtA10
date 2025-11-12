using JasonMittelstedtA10.Model.Person;

namespace JasonMittelstedtA10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Assignment 10 by Mittelstedt";
            Demo();
        }

        private void Demo()
        {
            // Polymorphic collection
            List<Person> people = new()
            {
                new Student("Alice", "Johnson", 101, "123 Main St", "Computer Science", "Mathematics"),
                new Teacher("Bob", "Smith", 202, "456 Oak Rd", "History"),
                new Staff("Carol", "Brown", 303, "789 Pine Ave", "Administrator")
            };

            // Display details dynamically
            string output = string.Join("\n\n", people.ConvertAll(p => p.Details));
            MessageBox.Show(output, "People Details");
        }
    }
}
