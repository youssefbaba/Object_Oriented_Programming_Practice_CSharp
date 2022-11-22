namespace Exercise_4
{
    public class TestPerson
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("John", "Doe", 25);
            Person person2 = new Person("David", "Alonso", 30);
            Person person3 = new Person("Gerard", "Pedri", 35);
            Person person4 = new Person("John", "Alves", 29);
            Person person5 = new Person("Ana", "Fonti", 24);
            List<Person> listPersons = new List<Person>();
            listPersons.Add(person1);
            listPersons.Add(person2);
            listPersons.Add(person3);
            listPersons.Add(person4);
            listPersons.Add(person5);


            Console.WriteLine("<------ items of listPersons before sorting ------>");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , Age = {person.Age}");
            }
            Console.WriteLine();


            listPersons.Sort(new Person());
            Console.WriteLine("<------ items of listPersons after sorting ------>");
            foreach (var item in listPersons)
            {
                Console.WriteLine($"FirstName = {item.FirstName} , LastName = {item.LastName} , Age = {item.Age}"); 
            }
            Console.WriteLine();


            Console.WriteLine("<------ find younger person ------>");
            listPersons.Sort();
            Person person6 = listPersons.Find(person => person.FirstName.StartsWith("J"));
            Console.WriteLine($"FirstName = {person6.FirstName} , LastName = {person6.LastName} , Age = {person6.Age}");

        }
    }
}