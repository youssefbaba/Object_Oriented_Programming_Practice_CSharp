namespace Exercise_3
{
    public class TestStaff
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            Representative representative1 = new Representative("Maks", "Gea", 35, 2010, 80000.5);
            Representative representative2 = new Representative("David", "Alaba", 40, 2019, 90000.5);
            Representative representative3 = new Representative("John", "Doe", 45, 2015, 82000.5);
            Seller seller1 = new Seller("Jim", "Alves", 25, 2018, 75000.5);
            Seller seller2 = new Seller("Jean", "Alba", 35, 2011, 83000.5);
            Producer producer1 = new Producer("Xavi", "Huge", 46, 2020, 1500);
            Producer producer2 = new Producer("Bruno", "Pedri", 26, 2012, 1600);


            staff.AddEmployee(representative1);
            staff.AddEmployee(representative2);
            staff.AddEmployee(representative3);
            staff.AddEmployee(seller1);
            staff.AddEmployee(seller2);
            staff.AddEmployee(producer1);
            staff.AddEmployee(producer2);


            staff.Show();


            Console.WriteLine($"The average salary of the company's employees = {staff.AverageSalary()}");


            staff.NumberEmployees();

        }
    }
}
