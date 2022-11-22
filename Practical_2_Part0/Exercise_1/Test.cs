namespace Exercise_1
{
    public class Test
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            staff.AddEmployee(new Representative("John", "Doe", 25, 2001, 2000.00)); // Conversion implicit
            staff.AddEmployee(new Representative("David", "Alonso", 26, 2003, 2100.00));
            staff.AddEmployee(new Representative("Jim", "Pedri", 35, 2010, 2000.00));
            staff.AddEmployee(new Seller("Marks", "Gea", 40, 1996, 3000.00));
            staff.AddEmployee(new Seller("Gerard", "Bernard", 36, 2006, 1800.00));
            staff.AddEmployee(new Producer("Daniel", "Junior", 29, 2004, 210));
            staff.AddEmployee(new Producer("Huge", "Luis", 41, 2014, 190));

            staff.Show();

            Console.WriteLine($"Average salary of company's employees = {staff.AverageSalary()}");

            staff.NumberEmployees();


        }
    }
}