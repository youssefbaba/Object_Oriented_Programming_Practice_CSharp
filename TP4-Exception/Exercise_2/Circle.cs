using System.Runtime.Intrinsics.Arm;

namespace Exercise_2
{
    public class Circle
    {
        // Fields
        double _xCoordinate;
        double _yCoordinate;
        double _radius;
        string _color;


        // Constructors
        public Circle(double xCoordinate, double yCoordinate, double radius, string color)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            Radius = radius;
            Color = color;
            if (string.IsNullOrEmpty(Color) || Color.ToLower() == "red")
            {
                Color = "Default Color"; 
            }
        }


        //Methods
        public override string ToString()
        {
            return $"X-Coordinate = {_xCoordinate}\nY-Coordinate = {_yCoordinate}\nRadius = {Radius}\nColor = {Color}";
        }


        // Properties
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ValRadiusValidException();
                    }
                    else
                    {
                        _radius = value;
                    }
                }
                catch (ValRadiusValidException exp1)
                {
                    Console.WriteLine(exp1.Message);
                    _radius = -value;
                }
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new NullReferenceException();
                    }
                    else if (value.ToLower() == "red")
                    {
                        throw new ColorValidException();
                    }
                    else
                    {
                        _color = value;
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Please the color of the circle cannot be null or empty !");
                }
                catch (ColorValidException exp2)
                {
                    Console.WriteLine(exp2.Message);
                }
            }
        }
    }
}
