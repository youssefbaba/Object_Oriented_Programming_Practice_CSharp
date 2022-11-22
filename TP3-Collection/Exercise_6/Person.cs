namespace Exercise_6
{
    public class Person
    {
        // Constructors
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        // Properties
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
    }
}
