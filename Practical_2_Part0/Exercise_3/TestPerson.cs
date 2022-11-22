using System.Diagnostics.Tracing;

namespace Exercise_3
{
    public class TestPerson
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Doe", 25);
            Person person2 = new Person("David", "Alonso", 30);
            Person person3 = new Person("Gerard", "Pedri", 35);
            Person person4 = new Person("Marks", "Alves", 29);
            Person person5 = new Person("Andres", "Fonti", 24);
            List<Person> listPersons = new List<Person>();
            listPersons.Add(person1);
            listPersons.Add(person2);
            listPersons.Add(person3);
            listPersons.Add(person4);
            listPersons.Add(person5);

            Console.WriteLine("<------ Display listPerson before sorting ------>");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
            Console.WriteLine();


            Console.WriteLine("<------ Display listPerson after sorting based on Firstname ------>");
            listPersons.Sort();
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
            Console.WriteLine();


            Console.WriteLine("<------ Find first item that matches the condition ------>");
            Person person6 = listPersons.Find(person => person.Age >= 30);
            Console.WriteLine($"The first person over 30 years old : FirstName = {person6.FirstName} , LastName = {person6.LastName} , Age = {person6.Age}");
            Console.WriteLine();


            Console.WriteLine("<------ Find last item that matches the condition ------>");
            Person person7 = listPersons.FindLast(person => person.Age >= 30);
            Console.WriteLine($"The last person over 30 years old : FirstName = {person7.FirstName} , LastName = {person7.LastName} , Age = {person7.Age}");
            Console.WriteLine();


            Console.WriteLine("<------ Find all items that matche the condition ------>");
            List<Person> persons = listPersons.FindAll(person => person.FirstName.EndsWith("d"));
            Console.WriteLine($"All persons that their FirstName end with 'd'");
            foreach (Person person in persons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
        }
    }
}