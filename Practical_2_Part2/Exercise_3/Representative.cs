namespace Exercise_3
{
    public class Representative : Commercial
    {
        // Constructors
        public Representative(string firstName, string lastName, int age, int yearRecrutment, double income) : base(firstName, lastName, age, yearRecrutment, income)
        {
        }


        // Methods
        public override double CalcSalary()
        {
            return (0.2 * Income) + 800;
        }
    }
}
