namespace Exercise_3
{
    public abstract class Employee
    {
        // Fields
        string _firstName;      // this feild by default is private
        string _lastName;
        int _age;
        int _yearRecrutment;


        // Constructors
        public Employee(string firstName, string lastName, int age, int yearRecrutment)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _yearRecrutment = yearRecrutment;
        }


        // Methods
        public virtual void Display()       // No-Abstract method
        {
            Console.WriteLine($"FirstName = {_firstName}");
            Console.WriteLine($"LastName = {_lastName}");
            Console.WriteLine($"Age = {_age}");
            Console.WriteLine($"Year Of Recrutement = {_yearRecrutment}");
        }
        public abstract double CalcSalary();  // Abstrat method
    }
}
