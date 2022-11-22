namespace Exercise_2
{
    public class Rectangle : IForm      // Implementation of Interface
    {
        // Conctructors
        public Rectangle()
        {
        }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }


        // Methods
        public double Perimeter()       // Implementation which is mandatory
        {
            return 2 * (Width + Length);
        }
        public double Aria()        // Implementation which is mandatory
        {
            return Width * Length;
        }
        public override string ToString()       // Re-Implementation which is optional
        {
            return $"The rectangle that has width = {Width} and Length = {Length} its Perimeter = {Perimeter()} and Aria = {Aria()}";
        }


        // Properties
        public double Width { get; set; }
        public double Length { get; set; }
    }
}
