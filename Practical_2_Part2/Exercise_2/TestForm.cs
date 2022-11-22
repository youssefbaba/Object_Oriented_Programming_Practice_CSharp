namespace Exercise_2
{
    internal class TestForm
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Square square2 = new Square(15);
            Square square3 = new Square(15.5);
            Console.WriteLine($"{square1}");
            Console.WriteLine($"{square2}");
            Console.WriteLine($"{square3}");

            Console.WriteLine();

            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle(20,10);
            Rectangle rectangle3 = new Rectangle(20.5 , 10.5);
            Console.WriteLine($"{rectangle1}");
            Console.WriteLine($"{rectangle2}");
            Console.WriteLine($"{rectangle3}");
        }
    }
}