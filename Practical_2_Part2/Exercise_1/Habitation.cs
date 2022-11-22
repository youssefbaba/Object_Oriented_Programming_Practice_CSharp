namespace Exercise_1
{
    public class Habitation
    {
        // Fields
        string _owner;      // by default is private
        string _address;
        double _area;


        // Constructors
        public Habitation(string owner , string address , double area)
        {
            _owner = owner;
            _address = address;
            _area = area;
        }


        // Methods
        public virtual double Tax()
        {
            return _area * 10; 
        }
        public virtual void Display()
        {
            Console.WriteLine($"Owner ==> {_owner}");
            Console.WriteLine($"Address ==> {_address}");
            Console.WriteLine($"Area ==> {_area}");
        }   
    }
}
