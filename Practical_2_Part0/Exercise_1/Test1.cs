namespace Exercise_1
{
    public class Test1
    {
        static void Main(string[] args)
        {
            Personnel personnel = new Personnel();
            personnel.AddEmployee(new Representative("John", "Doe", 25, 2001, 2000.00)); // Conversion implicit
            personnel.AddEmployee(new Representative("David", "Alonso", 26, 2003, 2100.00));
            personnel.AddEmployee(new Representative("Jim", "Pedri", 35, 2010, 2000.00));
            personnel.AddEmployee(new Seller("Marks", "Gea", 40, 1996, 3000.00));
            personnel.AddEmployee(new Seller("Gerard", "Bernard", 36, 2006, 1800.00));
            personnel.AddEmployee(new Producer("Daniel", "Junior", 29, 2004, 210));
            personnel.AddEmployee(new Producer("Huge", "Luis", 41, 2014, 190));

            personnel.Show();

            Console.WriteLine($"Average salary of company's employees = {personnel.AverageSalary()}");

            personnel.NumberEmployees();
        }
    }
}
