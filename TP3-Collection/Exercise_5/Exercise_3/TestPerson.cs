namespace Exercise_3
{
    internal class TestPerson
    {
        // Fields
        Person[] _arrayPersons;


        // Constructors
        public TestPerson(Person[] arrayPersons)
        {
            _arrayPersons = arrayPersons;
        }


        // Methods
        public void Display()
        {
            foreach (Person person in _arrayPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Doe", 18);
            Person person2 = new Person("David", "Alba", 35);
            Person person3 = new Person("John", "Liva", 86);
            Person person4 = new Person("Sum", "Huge", 25);
            Person person5 = new Person("Marks", "Doe", 45);


            Person[] arrayPersons = new Person[] { person1, person2, person3, person4, person5 };


            TestPerson testPerson = new TestPerson(arrayPersons);


            Console.WriteLine("<------ Array of persons before sorting ------>");
            testPerson.Display();


            Console.WriteLine("<------ array of persons after sorting based on Age of Person ------>");
            Array.Sort(testPerson._arrayPersons);
            testPerson.Display();


            Console.WriteLine("<------ Find the first element in this array that matches these conditions ------>");
            //Person result = Array.Find(testPerson._arrayPersons, person => person.Age >= 60 && person.LastName.EndsWith("e"));
            Person result = Array.Find(testPerson._arrayPersons, person => person.Age >= 30 && person.LastName.EndsWith("e"));
            if (result != null)
            {
                Console.WriteLine($"FirstName = {result.FirstName} - LastName = {result.LastName} - Age = {result.Age}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }


            Console.WriteLine("<------ Find the last element in this list that matches these conditions ------>");
            //Person result1 = Array.FindLast(testPerson._arrayPersons, person => person.Age >= 15 && person.FirstName.StartsWith("J"));
            Person result1 = Array.FindLast(testPerson._arrayPersons, person => person.Age < 15 && person.FirstName.StartsWith("J"));
            if (result1 != null)
            {
                Console.WriteLine($"FirstName = {result1.FirstName} - LastName = {result1.LastName} - Age = {result1.Age}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }


            Console.WriteLine("<------ Find all elements in this list that matches these conditions ------>");
            testPerson._arrayPersons = Array.FindAll(testPerson._arrayPersons, person => person.Age >= 30);
            testPerson.Display();
        }
    }
}