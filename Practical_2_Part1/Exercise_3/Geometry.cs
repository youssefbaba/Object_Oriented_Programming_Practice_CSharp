namespace Exercise_3
{
    public class Geometry
    {
        // Fields
        double _xCoordinateVertexOne;
        double _yCoordinateVertexOne;
        double _xCoordinateVertexTwo;
        double _yCoordinateVertexTwo;
        double _xCoordinateVertexThree;
        double _yCoordinateVertexThree;
        double _sideOne;
        double _sideTwo;
        double _sideThree;

        // Constructors
        public Geometry(double xCoordinateVertexOne, double yCoordinateVertexOne, double xCoordinateVertexTwo, double yCoordinateVertexTwo, double xCoordinateVertexThree, double yCoordinateVertexThree)
        {
            _xCoordinateVertexOne = xCoordinateVertexOne;
            _yCoordinateVertexOne = yCoordinateVertexOne;
            _xCoordinateVertexTwo = xCoordinateVertexTwo;
            _yCoordinateVertexTwo = yCoordinateVertexTwo;
            _xCoordinateVertexThree = xCoordinateVertexThree;
            _yCoordinateVertexThree = yCoordinateVertexThree;
            _sideOne = Math.Sqrt(Math.Pow((_xCoordinateVertexTwo - _xCoordinateVertexOne), 2) + Math.Pow((_yCoordinateVertexTwo - _yCoordinateVertexOne), 2));
            _sideTwo = Math.Sqrt(Math.Pow((_xCoordinateVertexThree - _xCoordinateVertexOne), 2) + Math.Pow((_yCoordinateVertexThree - _yCoordinateVertexOne), 2));
            _sideThree = Math.Sqrt(Math.Pow((_xCoordinateVertexThree - _xCoordinateVertexTwo), 2) + Math.Pow((_yCoordinateVertexThree - _yCoordinateVertexTwo), 2));
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of traingle = {_sideOne + _sideTwo + _sideThree}");
        }
        public void IsIsosceles()
        {
            if (_sideOne == _sideTwo || _sideOne == _sideThree || _sideTwo == _sideThree)
            {
                Console.WriteLine($"The triangle is isosceles");
            }
            else
            {
                Console.WriteLine($"The triangle is not isosceles");
            }
        }
    }
}
