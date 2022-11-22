namespace Exercise_5
{
    internal class Test
    {
        public static void Display()
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

            // Select items from the collection
            /*
            //var x = from person in listPersons select person;
            IEnumerable<Person> x = from person in listPersons select person;
            List<Person> listPersonsTwo = x.ToList();
            foreach (Person person in listPersonsTwo)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
            */
            List<Person> listPersonsThree = (from person in listPersons select person).ToList();
            foreach (Person person in listPersonsThree)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
            Console.WriteLine();


            // Select items from the collection based on a condition
            /*
            //var x = from person in listPersons where person.Age >= 30 select person;
            IEnumerable<Person> x = from person in listPersons where person.Age >= 20  select person;
            List<Person> listPersonsFour = x.ToList();
            foreach (Person person in listPersonsFour)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
            */

            List<Person> listPersonsFive = (from person in listPersons where person.FirstName.EndsWith("d") && person.Age >= 30 select person).ToList();
            foreach (Person person in listPersonsFive)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
            Console.WriteLine();


            // Sort collection items
            /*
            //var x = from person in listPersons orderby person.Age descending select person;
            IEnumerable<Person> x = from person in listPersons orderby person.Age descending select person;
            List<Person> listPersonsSix = x.ToList();
            foreach (Person person in listPersonsSix)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
            */

            List<Person> listPersonsSeven = (from person in listPersons orderby person.FirstName descending select person).ToList();
            foreach (Person person in listPersonsSeven)
            {
                Console.WriteLine($"FirstName = {person.FirstName} - LastName = {person.LastName} - Age = {person.Age}");
            }
        }
    }
}
