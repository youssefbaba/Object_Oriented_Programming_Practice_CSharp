namespace Exercise_1
{
    public class Personnel
    {
        // Fields
        List<Employee> _employees;      // by default is private


        // Constructors
        public Personnel()
        {
            _employees = new List<Employee>();
        }

        // Methods
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Show()
        {
            foreach (Employee employee in _employees)
            {
                employee.Display();
            }
        }
        public double AverageSalary()
        {
            double sum = 0.0;
            foreach (Employee employee in _employees)
            {
                sum += employee.CalculateSalary();
            }
            return sum / _employees.Count;
        }
        public void NumberEmployees()
        {
            Console.WriteLine($"The number of employees in the company = {_employees.Count}");
        }
    }
}



