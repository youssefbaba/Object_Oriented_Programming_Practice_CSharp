namespace Exercise_1
{
    public class ProfessionalHabitation : Habitation
    {
        // Fields
        int NumberEmployees;


        // Constructors
        public ProfessionalHabitation(string owner, string address, double area, int numberEmployees) : base(owner, address, area)
        {
            NumberEmployees = numberEmployees;
        }


        // Methods
        public override double Tax()
        {
            return base.Tax() + (NumberEmployees * 100);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Number Of Employees ==> {NumberEmployees}");
        }
    }
}
