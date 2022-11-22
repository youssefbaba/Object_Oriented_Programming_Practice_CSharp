namespace Exercise_2
{
    public class Personnel
    {
        // Fields
        List<Employee> _employees = new List<Employee>();       // by default is private

        // Methods
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        //public static List<string> Show()
        public List<string> Show()
        {
            List<string> list = new List<string>();
            foreach (Employee employee in _employees)
            {
                list.Add(employee.Display());
            }
            return list;
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
        public int NumberEmployees()
        {
            return _employees.Count;
        }
    }
}



