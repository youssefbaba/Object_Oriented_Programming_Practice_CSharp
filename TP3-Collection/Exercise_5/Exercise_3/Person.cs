namespace Exercise_3
{
    public class Person : IComparable
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
            if (Age > ((Person)obj).Age)
            {
                return -1;
            }
            else if (Age < ((Person)obj).Age)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        //Properties
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
    }
}
