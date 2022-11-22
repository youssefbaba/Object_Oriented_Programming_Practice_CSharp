namespace Exercise_2
{
    public class Test
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(10, 20, 15, "blue");
            circle1.Color = null; 
            Console.WriteLine(circle1);
            Console.WriteLine();


            Circle circle2 = new Circle(10, 20, 15, "green");
            circle2.Radius = -13;
            Console.WriteLine(circle2);
            Console.WriteLine();


            Circle circle3 = new Circle(10, 20, 15, "Black");
            circle3.Color = "";
            Console.WriteLine(circle3);
            Console.WriteLine();


            Circle circle4 = new Circle(10, 20, 15, "yellow");
            circle4.Color = "red";
            Console.WriteLine(circle4);
            Console.WriteLine();


            Circle circle5 = new Circle(10, 20, 15, null);
            Console.WriteLine(circle5);
            Console.WriteLine();


            Circle circle6 = new Circle(10, 20, -15, "blue");
            Console.WriteLine(circle6);
            Console.WriteLine();


            Circle circle7 = new Circle(10, 20, 15, "");
            Console.WriteLine(circle7);
            Console.WriteLine();


            Circle circle8 = new Circle(10, 20, 15, "red");
            Console.WriteLine(circle8);
            Console.WriteLine();
        }
    }
}