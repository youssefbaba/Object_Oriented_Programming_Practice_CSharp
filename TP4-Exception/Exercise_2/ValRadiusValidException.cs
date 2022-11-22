namespace Exercise_2
{
    public class ValRadiusValidException : Exception
    {
        // Constructors
        public ValRadiusValidException():base("Please the radius of the circle cannot be negative !")
        {
        }
    }
}
