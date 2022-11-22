namespace Exercise_3
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Doe", 35, "+212546895245" , Cities.Casablanca);
            Console.WriteLine($"FirstName = {person1.FirstName}");
            Console.WriteLine($"LastName = {person1.LastName}");
            Console.WriteLine($"Age = {person1.Age}");
            Console.WriteLine($"Phone = {person1.Phone}");
            //Action<int> obj = age => person1.Age = age; // Lambda Expression
            Person.ChangePerson(age => person1.Age = age);
            Console.WriteLine($"New age = {person1.Age}");
            person1.KnowOrigin();

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------------------------------->");
            Console.WriteLine();

            Person person2 = new Person("David", "Alonso", 25, "+212546897589", Cities.Rabat);
            Console.WriteLine($"FirstName = {person2.FirstName}");
            Console.WriteLine($"LastName = {person2.LastName}");
            Console.WriteLine($"Age = {person2.Age}");
            Console.WriteLine($"Phone = {person2.Phone}");
            Person.ChangePerson(age => person2.Age = age);
            Console.WriteLine($"New age = {person2.Age}");
            person2.KnowOrigin();
        }
    }
}