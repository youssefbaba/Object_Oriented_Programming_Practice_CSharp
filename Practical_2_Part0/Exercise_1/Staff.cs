namespace Exercise_1
{
    public class Staff
    {
        // Fields
        Employee[] _employees;      // by default is private
        const int _length = 1000;
        static int _numberEmployee;


        // Constructors
        public Staff()
        {
            _employees = new Employee[_length];
            _numberEmployee = 0;
        }

        // Methods
        public void AddEmployee(Employee employee)
        {
            if (_numberEmployee <= _employees.Length)
            {
                ++_numberEmployee;
                _employees[_numberEmployee - 1] = employee;
            }
            else
            {
                Console.WriteLine($"we cannot add more than {_length} employees !");
            }
        }
        public void Show()
        {
            for (int i = 0; i < _numberEmployee; i++)
            {
                _employees[i].Display();
            }
        }
        public double AverageSalary()
        {
            double sum = 0.0;
            for (int i = 0; i < _numberEmployee; i++)
            {
                sum += _employees[i].CalculateSalary();
            }
            return sum / _numberEmployee;
        }
        public void NumberEmployees()
        {
            Console.WriteLine($"The number of employees in the company = {_numberEmployee}");
        }
    }
}
