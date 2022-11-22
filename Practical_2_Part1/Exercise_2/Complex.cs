namespace Exercise_2
{
    public class Complex
    {
        // Fields
        double _realPart;        // by default is private
        double _imaginarypart;


        // Constructors
        public Complex() // Parameterless Constructor
        {
        }
        public Complex(double realPart, double imaginarypart) // Parameterized Constructor
        {
            _realPart = realPart;
            _imaginarypart = imaginarypart;
        }
        public Complex(Complex complex) // Copy Constructor
        {
            _realPart = complex._realPart;
            _imaginarypart = complex._imaginarypart;
        }


        // Methods
        public void Add(Complex complex)
        {
            _realPart += complex._realPart;
            _imaginarypart += complex._imaginarypart;
        }
        public static Complex Add(Complex complex1 , Complex complex2) // Overload Method
        {
            return new Complex(complex1._realPart + complex2._realPart, complex1._imaginarypart + complex2._imaginarypart);
        }

        public override string ToString()
        {
            return $"{_realPart} + {_imaginarypart}*i";
        }
    }
}
