namespace Exercise_1
{
    public class Person:IComparable
    {
        // Constructors
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        // Methods
        public int CompareTo(object? obj)
        {
            return FirstName.CompareTo(((Person)obj).FirstName);    // Comparison based on FirstName
        }


        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
    }
}
