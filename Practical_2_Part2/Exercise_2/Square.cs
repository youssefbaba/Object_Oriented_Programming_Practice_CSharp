namespace Exercise_2
{
    public class Square : IForm     // Implementation of Interface
    {
        // Conctructors
        public Square()
        {
        }
        public Square(double side)
        {
            Side = side;
        }


        // Methods
        public double Perimeter()       // Implementation which is mandatory
        {
            return 4 * Side;
        }
        public double Aria()        // Implementation which is mandatory
        {
            return Side * Side;
        }
        public override string ToString()       // Re-Implementation which is optional
        {
            return $"The square that has side = {Side} its Perimeter = {Perimeter()} and Aria = {Aria()}";
        }


        // Properties
        public double Side { get; set; }
    }
}
