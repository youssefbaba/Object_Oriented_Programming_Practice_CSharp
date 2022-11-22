namespace Exercise_3
{
    //public class Person : IComparable   // First Way
    public class Person : IComparable<Person>  // second way
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


        // Methods

        /*
        // First way
        public int CompareTo(object? obj)
        {
            Person person = obj as Person;
            return FirstName.CompareTo(person.FirstName);
        }
        */
        
        // Second way
        public int CompareTo(Person? other) // Comparison based on FirstName
        {
            return FirstName.CompareTo(other.FirstName);
        }
        
    }
}
