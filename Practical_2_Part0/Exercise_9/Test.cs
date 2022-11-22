namespace Exercise_9
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<User> listUsers = new List<User>
            {
                new User("Xavier" , "Smith" ,1 ),
                new User("Alexander" , "Smith" , 2),
                new User("Alexander" , "Smith" , 1),
                new User("Bob" , "Hawke" , 2),
            };
            Console.WriteLine("---- Users before sorting ----");
            foreach (User user in listUsers)
            {
                Console.WriteLine($"{user.FirstName} - {user.LastName} - {user.Rank}");
            }
            Console.WriteLine();


            Console.WriteLine("---- Users after sorting ----");
            listUsers.Sort(new User());
            foreach (User user in listUsers)
            {
                Console.WriteLine($"{user.FirstName} - {user.LastName} - {user.Rank}");
            }
            Console.WriteLine();


            List<Customer> listCustomers = new List<Customer>
            {
                new Customer("Xavier" , "Smith" ,1000 ),
                new Customer("Alexander" , "Smith" , 2000),
                new Customer("Alexander" , "Smith" , 1000),
                new Customer("Bob" , "Hawke" , 2000),
            };
            Console.WriteLine("---- Customers before sorting ----");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"{customer.FirstName} - {customer.LastName} - {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("---- Customers after sorting ----");
            listCustomers.Sort();
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"{customer.FirstName} - {customer.LastName} - {customer.Balance}");
            }
            Console.WriteLine();

        }
    }
}