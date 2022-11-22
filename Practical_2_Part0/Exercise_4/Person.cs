namespace Exercise_4
{
    public class Person : IComparer<Person>, IComparable<Person>
    //public class Person 
    {
        // Fields
        static int _counter = 0;        // by default is private
        static int _number = 0;


        // Constructors
        public Person()
        {
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Methods

        public int Compare(Person person1, Person person2)
        {
            bool check;
            while (_counter <= 0)
            {
                do
                {
                    Console.WriteLine("Please if you want to sort this list in alphabetical order of first name and last name type 1");
                    Console.WriteLine("Or if you want to sort this list based on age (from the youngest to the oldest) type 2");
                    check = int.TryParse(Console.ReadLine(), out _number);
                    if (!check || (check && _number != 1 && _number != 2))
                    {
                        Console.WriteLine($"Please try to enter a valid number which is between {int.MinValue} and {int.MaxValue} !");
                    }
                } while (!check || (check && _number != 1 && _number != 2));
                _counter++;
            }
            if (_number == 1)
            {
                if (person1.FirstName.CompareTo(person2.FirstName) != 0)
                {
                    return person1.FirstName.CompareTo(person2.FirstName);
                }
                else if (person1.LastName.CompareTo(person2.LastName) != 0)
                {
                    return person1.LastName.CompareTo(person2.LastName);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return person1.Age.CompareTo(person2.Age);
            }
        }
        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other.Age);
        }

        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

    }
}
