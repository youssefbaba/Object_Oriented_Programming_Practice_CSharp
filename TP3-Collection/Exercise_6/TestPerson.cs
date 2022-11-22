namespace Exercise_6
{
    public class TestPerson
    {
        // Fields
        List<Person> _listPersons;

        // Constructors
        public TestPerson(List<Person> listPersons)
        {
            _listPersons = listPersons;
        }

        // Methods
        public void Display()
        {
            foreach (Person person in _listPersons)
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


            List<Person> list = new List<Person>();
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);
            list.Add(person5);


            TestPerson testPerson = new TestPerson(list);


            Console.WriteLine("------ List of persons before sorting ------");
            testPerson.Display();


            Console.WriteLine("------ List of persons after sorting based on FirstName ------");
            testPerson._listPersons = (testPerson._listPersons.OrderBy(person => person.FirstName)).ToList(); // linq to sql
            testPerson.Display();


            Console.WriteLine("------ Find the first item in the list that matches the conditions------");
            //Person result1 = testPerson._listPersons.FirstOrDefault(person => person.Age >= 60 && person.LastName.EndsWith("e"));
            Person result1 = testPerson._listPersons.FirstOrDefault(person => person.Age >= 30 && person.LastName.EndsWith("e"));
            if (result1 != null)
            {
                Console.WriteLine($"FirstName = {result1.FirstName} - LastName = {result1.LastName} - Age = {result1.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("------ Find the last item in the list that matches the conditions------");
            //Person result2 = testPerson._listPersons.LastOrDefault(person => person.Age >= 15 && person.FirstName.StartsWith("J"))
            Person result2 = testPerson._listPersons.LastOrDefault(person => person.Age < 15 && person.FirstName.StartsWith("J"));
            if (result2 != null)
            {
                Console.WriteLine($"FirstName = {result2.FirstName} - LastName = {result2.LastName} - Age = {result2.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("------ Find the all items in the list that matche the conditions------");
            testPerson._listPersons = (testPerson._listPersons.Where(person => person.Age >= 30).OrderBy(person => person.LastName)).ToList();
            testPerson.Display();

        }
    }
}