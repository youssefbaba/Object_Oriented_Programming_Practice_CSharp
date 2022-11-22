namespace Exercise_1
{
    public class Person1 : IComparable<Person1>
    {
        // Constructors
        public Person1(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        // Methods
        public int CompareTo(Person1 other)
        {
            return FirstName.CompareTo(other.FirstName);    // Comparison based on FirstName
        }


        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
    }
}
