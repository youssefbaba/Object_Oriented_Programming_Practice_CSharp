using System.Collections;

namespace Exercise_2
{
    public class Person : IComparer<Person> , IComparable<Person>
    {
        // Fields
        int _counter;
        int _enteredValue;


        // Constructors
        public Person()
        {
            int _counter = default;
            int _enteredValue = default;
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
            while (_counter <= 0)
            {
                Console.WriteLine("Please if you want to sort your list by age try to type number 1.");
                Console.WriteLine("Or if you want to sort your list by firstname and lastname try to type number 2.");
                int.TryParse(Console.ReadLine(), out _enteredValue);
                if (_enteredValue != 1 && _enteredValue != 2)
                {
                    Console.WriteLine($"Please tyr to enter a valid number which is between {int.MinValue} and {int.MaxValue} !");
                }
                else
                {
                    _counter++;
                }
            }
            if (_enteredValue == 1)
            {
                return person1.Age.CompareTo(person2.Age);
            }
            else
            {
                if (person1.FirstName.CompareTo(person2.FirstName) != 0)
                {
                    return person1.FirstName.CompareTo(person2.FirstName);
                }
                return person1.LastName.CompareTo(person2.LastName);
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
