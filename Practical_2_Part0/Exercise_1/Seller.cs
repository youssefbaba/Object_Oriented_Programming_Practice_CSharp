namespace Exercise_1
{
    public class Seller : Commercial
    {
        // Constructors
        public Seller(string firstName, string lastName, int age, int yearRecruitment, double income) : base(firstName, lastName, age, yearRecruitment, income)
        {
        }

        // Methods
        public override double CalculateSalary()
        {
            return (Income * 0.2) + 400;
        }
    }
}
