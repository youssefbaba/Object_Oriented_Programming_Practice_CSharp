namespace Exercise_1
{
    public class TestPerson1
    {
        // Fields
        List<Person1> _listPerson1;


        // Constructors
        public TestPerson1()
        {
            _listPerson1 = new List<Person1>();
        }

        // Methods
        public void Display(List<Person1> listPersons)
        {
            foreach (Person1 person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
        }
        static void Main(string[] args)
        {
            TestPerson1 test = new TestPerson1();
            Person1 person1 = new Person1("John", "Doe", 18);
            Person1 person2 = new Person1("David", "Alba", 35);
            Person1 person3 = new Person1("John", "Liva", 86);
            Person1 person4 = new Person1("Sum", "Huge", 25);
            Person1 person5 = new Person1("Marks", "Doe", 45);


            test._listPerson1.Add(person1);
            test._listPerson1.Add(person2);
            test._listPerson1.Add(person3);
            test._listPerson1.Add(person4);
            test._listPerson1.Add(person5);


            Console.WriteLine("<------ List of persons before sorting ------>");
            test.Display(test._listPerson1);


            Console.WriteLine("<------ List of persons after sorting based on FirstName of Person ------>");
            test._listPerson1.Sort();
            test.Display(test._listPerson1);


            Console.WriteLine("<------ Find the first element in this list that matches these conditions ------>");
            //Person1 result =  test._listPerson1.Find(person => person.Age >= 60 && person.LastName.EndsWith("e"));
            Person1 result = test._listPerson1.Find(person => person.Age >= 30 && person.LastName.EndsWith("e"));
            if (result != null)
            {
                Console.WriteLine($"FirstName = {result.FirstName} - LastName = {result.LastName} - Age = {result.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("<------ Find the last element in this list that matches these conditions ------>");
            //Person1 result1 = test._listPerson1.FindLast(person => person.Age >= 15 && person.FirstName.StartsWith("J"));
            Person1 result1 = test._listPerson1.FindLast(person => person.Age < 15 && person.FirstName.StartsWith("J"));
            if (result1 != null)
            {
                Console.WriteLine($"FirstName = {result1.FirstName} - LastName = {result1.LastName} - Age = {result1.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("<------ Find all elements in this list that matches these conditions ------>");
            List<Person1> list = test._listPerson1.FindAll(person => person.Age >= 30);
            test.Display(list);
        }
    }
}
