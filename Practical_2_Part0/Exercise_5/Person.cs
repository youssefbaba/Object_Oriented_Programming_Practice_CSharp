namespace Exercise_5
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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

    }
}
