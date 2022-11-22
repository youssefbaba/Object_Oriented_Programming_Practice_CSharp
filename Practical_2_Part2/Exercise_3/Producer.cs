namespace Exercise_3
{
    public class Producer : Employee
    {
        // Fields
        int _numberUnits;


        // Constructors
        public Producer(string firstName, string lastName, int age, int yearRecrutment, int numberUnits) : base(firstName, lastName, age, yearRecrutment)
        {
            _numberUnits = numberUnits;
        }


        // Methods
        public override void Display()      // Re-Implementation which is optional
        {
            base.Display();
            Console.WriteLine($"Number Of Units = {_numberUnits}");
        }
        public override double CalcSalary()     // Implementation which is mandatory
        {
            return _numberUnits * 5;
        }
    }
}
