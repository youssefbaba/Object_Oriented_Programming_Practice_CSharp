using System;

namespace Exercise_1
{
    public class TestPerson
    {
        // Fields
        List<Person> _listPerson;


        // Constructors
        public TestPerson()
        {
            _listPerson = new List<Person>();
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
            Person person1 = new Person("John", "Doe", 18);
            Person person2 = new Person("David", "Alba", 35);
            Person person3 = new Person("John", "Liva", 86);
            Person person4 = new Person("Sum", "Huge", 25);
            Person person5 = new Person("Marks", "Doe", 45);


            test._listPerson.Add(person1);
            test._listPerson.Add(person2);
            test._listPerson.Add(person3);
            test._listPerson.Add(person4);
            test._listPerson.Add(person5);


            Console.WriteLine("<------ List of persons before sorting ------>");
            test.Display(test._listPerson);


            Console.WriteLine("<------ List of persons after sorting based on FirstName of Person ------>");
            test._listPerson.Sort();
            test.Display(test._listPerson);


            Console.WriteLine("<------ Find the first element in this list that matches these conditions ------>");
            //Person result =  test._listPerson.Find(person => person.Age >= 60 && person.LastName.EndsWith("e"));
            Person result = test._listPerson.Find(person => person.Age >= 30 && person.LastName.EndsWith("e"));
            if (result != null)
            {
                Console.WriteLine($"FirstName = {result.FirstName} - LastName = {result.LastName} - Age = {result.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("<------ Find the last element in this list that matches these conditions ------>");
            //Person result1 = test._listPerson.FindLast(person => person.Age >= 15 && person.FirstName.StartsWith("J"));
            Person result1 = test._listPerson.FindLast(person => person.Age < 15 && person.FirstName.StartsWith("J"));
            if (result1 != null)
            {
                Console.WriteLine($"FirstName = {result1.FirstName} - LastName = {result1.LastName} - Age = {result1.Age}");
            }
            else
            {
                Console.WriteLine("Not Found !");
            }


            Console.WriteLine("<------ Find all elements in this list that matches these conditions ------>");
            List<Person> list = test._listPerson.FindAll(person => person.Age >= 30);
            test.Display(list);
        }
    }
}