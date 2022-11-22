namespace Exercise_2
{
    public class TestPerson
    {
        // Fields 
        List<Person> _listPersons;


        // Constructors
        public TestPerson()
        {
            _listPersons = new List<Person>();
        }


        // Methods
        public void Display(List<Person> listPersons)
        {
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
        }
        static void Main(string[] args)
        {
            TestPerson test = new TestPerson();
            Person person1 = new Person("John", "Liva", 18);
            Person person2 = new Person("David", "Alba", 45);
            Person person3 = new Person("John", "Doe", 86);
            Person person4 = new Person("Sum", "Huge", 25);
            Person person5 = new Person("Marks", "Doe", 35);


            test._listPersons.Add(person1);
            test._listPersons.Add(person2);
            test._listPersons.Add(person3);
            test._listPersons.Add(person4);
            test._listPersons.Add(person5);


            Console.WriteLine("<------ List of persons before sorting ------>");
            test.Display(test._listPersons);


            Console.WriteLine("<------ List of persons after sorting based on FirstName and LastName or Age of Person ------>");
            test._listPersons.Sort(new Person());
            test.Display(test._listPersons);


            Console.WriteLine("<------ Find element in this list that matches these conditions ------>");
            test._listPersons.Sort();
            Person firtsYoungestPerson = test._listPersons.Find(person => person.Age >= 30);
            Console.WriteLine($"FirstName = {firtsYoungestPerson.FirstName} - LastName = {firtsYoungestPerson.LastName} - Age = {firtsYoungestPerson.Age}");
        }
    }   
}