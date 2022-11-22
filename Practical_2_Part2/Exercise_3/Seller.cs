namespace Exercise_3
{
    public class Seller : Commercial
    {
        // Constructors
        public Seller(string firstName, string lastName, int age, int yearRecrutment, double income) : base(firstName, lastName, age, yearRecrutment, income)
        {
        }


        // Methods
        public override double CalcSalary()
        {
            return (0.2 * Income) + 400;
        }
    }
}
