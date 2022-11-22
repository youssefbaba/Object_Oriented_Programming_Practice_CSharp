namespace Exercise_1
{
    public class Equation
    {
        // Fields
        double _coefficientOne;     // by default is private
        double _coefficientTwo;
        double _coefficientThree;
        double _discriminant;
        double _rootOne;
        double _rootTwo;

        // Constructors
        public Equation(double coefficientOne, double coefficientTwo, double coefficientThree)
        {
            if (coefficientOne == 0)
            {
                Console.WriteLine("The program does not deal with the case where CoefficientOne = 0");
            }
            else
            {
                _coefficientOne = coefficientOne;
            }
            _coefficientTwo = coefficientTwo;
            _coefficientThree = coefficientThree;
        }

        // Methods
        public void DisplayEquation()
        {
            if (_coefficientOne != 0)
            {
                Console.WriteLine($"{_coefficientOne}X^2 + {_coefficientTwo}X + {_coefficientThree} = 0");
            }
        }
        public void CalculRoots()
        {
            if (_coefficientOne != 0)
            {
                _discriminant = Math.Pow(_coefficientTwo, 2) - (4 * _coefficientOne * _coefficientThree);
                if (_discriminant > 0)
                {
                    _rootOne = (-_coefficientTwo + Math.Sqrt(_discriminant)) / (2 * _coefficientOne);
                    _rootTwo = (-_coefficientTwo - Math.Sqrt(_discriminant)) / (2 * _coefficientOne);
                    Console.WriteLine($"There are two real roots RootOne = {_rootOne} and RootTwo = {_rootTwo}.");
                }
                else if (_discriminant < 0)
                {
                    Console.WriteLine(ToString());
                }
                else
                {
                    _rootOne = _rootTwo = -_coefficientTwo / (2 * _coefficientOne);
                    Console.WriteLine($"There is one root RootOne = RootTwo = {_rootOne}.");
                }
            }
        }
        public override string ToString()
        {
            return $"There are no real roots, there are 2 complex roots: RootOne = {-_coefficientTwo / (2 * _coefficientOne)} + {Math.Sqrt(-_discriminant) / (2 * _coefficientOne)}i and RootTwo = {-_coefficientTwo / (2 * _coefficientOne)} - {Math.Sqrt(-_discriminant) / (2 * _coefficientOne)}i";
        }
    }
}
