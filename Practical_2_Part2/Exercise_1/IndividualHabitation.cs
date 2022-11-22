namespace Exercise_1
{
    public class IndividualHabitation : Habitation
    {
        // Fields
        int _numberPieces;      // by default is private
        bool _hasPool; 


        // Constructors
        public IndividualHabitation(string owner, string address, double area , int numberPieces , bool hasPool) : base(owner, address, area)
        {
            _numberPieces = numberPieces;
            _hasPool = hasPool;
        }


        // Methods
        public override double Tax()
        {
            return _hasPool ? base.Tax() + (_numberPieces * 100) + 400 : base.Tax() + (_numberPieces * 100);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Numbers Of Pieces ==> {_numberPieces}");
            Console.WriteLine($"Has Pool ==> {_hasPool}");
        }
    }
}
