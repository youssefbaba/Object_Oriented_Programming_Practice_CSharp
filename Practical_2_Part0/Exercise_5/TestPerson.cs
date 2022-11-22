namespace Exercise_5
{
    internal class TestPerson
    {
        static void Main(string[] args)
        {
            
            List<Person> listPersons = new List<Person>();
            Person person1 = new Person("John", "Doe", 25);
            Person person2 = new Person("David", "Alonso", 30);
            Person person3 = new Person("Gerard", "Pedri", 35);
            Person person4 = new Person("Marks", "Alves", 29);
            Person person5 = new Person("Andres", "Fonti", 24);
            listPersons.Add(person1);
            listPersons.Add(person2);
            listPersons.Add(person3);
            listPersons.Add(person4);
            listPersons.Add(person5);

            Console.WriteLine("<------ Display listPersons before sorting ------>");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
            Console.WriteLine();


            Console.WriteLine("<------ Display listPersons after sorting ------>");
            listPersons = listPersons.OrderBy(person => person.FirstName).ToList();
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
            Console.WriteLine();


            Console.WriteLine("<------ Finding all items which matche my conditions ------>");
            List<Person> subListPersons = listPersons.Where(person => person.FirstName.EndsWith("d") && person.Age >= 30).ToList();
            if (subListPersons.Count > 0)
            {
                foreach (Person person in subListPersons)
                {
                    Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
                }
            }
            else
            {
                Console.WriteLine("No item matches these conditions");
            }
            Console.WriteLine();


            Console.WriteLine("<------ Finding first item which matches my conditionsons ------>");
            Person person6 = listPersons.FirstOrDefault(person => person.FirstName.EndsWith("d") && person.Age < 30);
            if (person6 != null)
            {
                Console.WriteLine($"FirstName = {person6.FirstName} , LastName = {person6.LastName} , Age = {person6.Age}");
            }
            else
            {
                Console.WriteLine("No item matches these conditions");
            }
            

            //Test.Display();
        }
    }
}