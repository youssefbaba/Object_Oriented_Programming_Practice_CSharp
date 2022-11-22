namespace Exercise_2
{
    public class Representative : Commercial
    {
        // Constructors
        public Representative(string firstName, string lastName, int age, int yearRecruitment, double income) : base(firstName, lastName, age, yearRecruitment, income)
        {
        }

        // Methods
        public override double CalculateSalary()
        {
            return (Income * 0.2) + 800;
        }
    }
}
