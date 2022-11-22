namespace Exercise_3
{
    public abstract class Commercial : Employee
    {
        // Fields
        protected double Income;


        // Constructors
        public Commercial(string firstName, string lastName, int age, int yearRecrutment, double income) : base(firstName, lastName, age, yearRecrutment)
        {
            Income = income;
        }


        // Methods
        public sealed override void Display()       // Re-Implementation which is optional and keyword sealed means any extra Re-Implementation not allowed.
        {
            base.Display();
            Console.WriteLine($"Income = {Income}");
        }
    }
}
