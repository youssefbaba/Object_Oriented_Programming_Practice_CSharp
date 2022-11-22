namespace Exercise_3
{
    public class TestGeometry
    {
        static void Main(string[] args)
        {
            Geometry triangle1 = new Geometry(5, -2, 6, 4, 7, -2);
            triangle1.Perimeter();
            triangle1.IsIsosceles();
            Console.WriteLine();


            Geometry triangle2 = new Geometry(2, 5, 3, -4, 7, -1);
            triangle2.Perimeter();
            triangle2.IsIsosceles();
            Console.WriteLine();

        }
    }
}