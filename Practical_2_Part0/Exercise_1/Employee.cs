namespace Exercise_1
{
    public abstract class Employee
    {
        // Fields
        protected string FirstName;
        protected string LastName;
        protected int Age;
        protected int YearRecruitment;

        // Constructors
        public Employee(string firstName, string lastName, int age, int yearRecruitment) // Parameterized Constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            YearRecruitment = yearRecruitment;
        }

        // Methods
        public virtual void Display()
        {
            Console.WriteLine($"{GetType().Name} : FirstName = {FirstName} , LastName = {LastName} , Age = {Age} , YearRecruitment = {YearRecruitment}");
        }
        public abstract double CalculateSalary();
    }
}
