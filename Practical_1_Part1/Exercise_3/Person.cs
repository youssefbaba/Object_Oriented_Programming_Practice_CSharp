namespace Exercise_3
{
    public enum Cities  // New Type
    {
        Casablanca,
        Safi,
        Rabat,
        Marrakech
    }
    public class Person
    {
        // Fields
        static int _counter = 0;        // by default is private

        // Constructors 
        public Person()  // Parameterless constructor
        {
            if (_counter <= 0)
            {
                Console.WriteLine("Program start");
                ++_counter;
            }
            Console.WriteLine("Construct of Person class");
        }
        public Person(string firstName, string lastName, int age, string phone, Cities origin) : this() // Parameterized constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
            Origin = origin;
        }
        public Person(Person person) // Copy constructor
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Phone = person.Phone;
            Origin = person.Origin;
        }


        // Methods
        public static void ChangePerson(Action<int> oldAge)
        {
            bool check;
            do
            {
                Console.Write("Please enter your new age : ");
                int newAge;
                check = int.TryParse(Console.ReadLine(), out newAge);
                if (check)
                {
                    oldAge(newAge);
                }
                else
                {
                    Console.WriteLine($"Please try to enter a valid number wich is between {int.MinValue} and {int.MaxValue} !");
                }
            } while (!check);

        }
        public void KnowOrigin()
        {
            switch (Origin)
            {
                case Cities.Casablanca:
                    Console.WriteLine($"This person is originally from {Cities.Casablanca}");
                    break;
                case Cities.Safi:
                    Console.WriteLine($"This person is originally from {Cities.Safi}");
                    break;
                case Cities.Marrakech:
                    Console.WriteLine($"This person is originally from {Cities.Marrakech}");
                    break;
                case Cities.Rabat:
                    Console.WriteLine($"This person is originally from {Cities.Rabat}");
                    break;
                default:
                    Console.WriteLine("This origin not found");
                    break;
            }
        }

        // Properties
        public string FirstName { get; }  // Readonly Property
        public string LastName { get; private set; }
        public int Age { get; set; }
        public string Phone { get; private set; }
        public Cities Origin { get; private set; }
    }
}
