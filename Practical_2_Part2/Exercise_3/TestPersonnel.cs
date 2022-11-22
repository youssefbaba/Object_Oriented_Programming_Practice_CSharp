namespace Exercise_3
{
    internal class TestPersonnel
    {
        static void Main(string[] args)
        {
            Personnel personnel = new Personnel();
            Representative representative1 = new Representative("Maks", "Gea", 35, 2010, 80000.5);
            Representative representative2 = new Representative("David", "Alaba", 40, 2019, 90000.5);
            Representative representative3 = new Representative("John", "Doe", 45, 2015, 82000.5);
            Seller seller1 = new Seller("Jim", "Alves", 25, 2018, 75000.5);
            Seller seller2 = new Seller("Jean", "Alba", 35, 2011, 83000.5);
            Producer producer1 = new Producer("Xavi", "Huge", 46, 2020, 1500);
            Producer producer2 = new Producer("Bruno", "Pedri", 26, 2012, 1600);


            personnel.AddEmployee(representative1);
            personnel.AddEmployee(representative2);
            personnel.AddEmployee(representative3);
            personnel.AddEmployee(seller1);
            personnel.AddEmployee(seller2);
            personnel.AddEmployee(producer1);
            personnel.AddEmployee(producer2);


            personnel.Show();


            Console.WriteLine($"The average salary of the company's employees = {personnel.AverageSalary()}");


            personnel.NumberEmployees();

        }
    }
}