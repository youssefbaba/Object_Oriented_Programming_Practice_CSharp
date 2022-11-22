namespace Exercise_3
{
    public class Staff
    {
        // Fields
        List<Employee> _listEmployees;


        // Constructors
        public Staff()
        {
            _listEmployees = new List<Employee>();
        }


        // Methods
        public void AddEmployee(Employee employee)
        {
            _listEmployees.Add(employee);
        }
        public void Show()
        {
            foreach (Employee employee in _listEmployees)
            {
                employee.Display();
                Console.WriteLine();
            }
        }
        public double AverageSalary()
        {
            double sum = 0.0;
            foreach (Employee employee in _listEmployees)
            {
                sum += employee.CalcSalary();
            }
            return sum / _listEmployees.Count;
        }
        public void NumberEmployees()
        {
            int NumberSellers = 0;
            int NumberProducers = 0;
            int NumberRepresentatives = 0;

            for (int i = 0; i < _listEmployees.Count; i++)
            {
                switch (_listEmployees[i].GetType().Name)
                {
                    case "Producer":
                        NumberProducers++;
                        break;
                    case "Seller":
                        NumberSellers++;
                        break;
                    case "Representative":
                        NumberRepresentatives++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"The number of sellers is : {NumberSellers}");
            Console.WriteLine($"The number of producers is : {NumberProducers}");
            Console.WriteLine($"The number of representatives is : {NumberRepresentatives}");
        }

    }
}

