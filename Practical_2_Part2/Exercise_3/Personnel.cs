namespace Exercise_3
{
    public class Personnel
    {
        // Fields
        Employee[] _arrayEmployees;
        int _currentIndex;


        // Constructors
        public Personnel()
        {
            _arrayEmployees = new Employee[4];
            _currentIndex = -1;
        }


        // Methods
        public void AddEmployee(Employee employee)
        {
            if (_currentIndex == _arrayEmployees.Length - 1)
            {
                Employee[] newArrayEmployees = new Employee[_arrayEmployees.Length * 2];
                Array.Copy(_arrayEmployees, newArrayEmployees, _arrayEmployees.Length);
                _arrayEmployees = newArrayEmployees;
            }
            _arrayEmployees[++_currentIndex] = employee;
        }
        public void Show()
        {
            for (int i = 0; i <= _currentIndex; i++)
            {
                _arrayEmployees[i].Display();
                Console.WriteLine();
            }
        }
        public double AverageSalary()
        {
            double sum = 0.0;
            for (int i = 0; i <= _currentIndex; i++)
            {
                sum += _arrayEmployees[i].CalcSalary();
            }
            return sum / (_currentIndex + 1);
        }
        public void NumberEmployees()
        {
            int NumberSellers = 0;
            int NumberProducers = 0;
            int NumberRepresentatives = 0;

            for (int i = 0; i <= _currentIndex; i++)
            {
                switch (_arrayEmployees[i].GetType().Name)
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
