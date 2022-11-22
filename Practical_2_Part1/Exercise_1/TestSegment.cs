namespace Exercise_1
{
    public class TestSegment
    {
        static void Main(string[] args)
        {
            Segment segment1 = new Segment(2, 9);
            Console.WriteLine($"Length of segment is : {segment1.LengthSegment()}");
            Console.WriteLine();


            Segment segment2 = new Segment(-9, -2);
            Console.WriteLine($"Length of segment is : {segment2.LengthSegment()}");
            Console.WriteLine();


            Segment segment3 = new Segment(-5, 2);
            Console.WriteLine($"Length of segment is : {segment3.LengthSegment()}");
            Console.WriteLine();


            Segment segment4 =  new Segment(9, 2);
            Console.WriteLine($"is 4 included between {segment4.ExtremityOne} and {segment4.ExtremityTwo} ? {segment4.Include(4)}");
            Console.WriteLine($"is 10 included between {segment4.ExtremityOne} and {segment4.ExtremityTwo} ? {segment4.Include(10)}");
            Console.WriteLine();


            segment4.Order();
            Console.WriteLine(segment4);
            Console.WriteLine();


            Segment segment5 = new Segment(-2, -9);
            Console.WriteLine($"is -6 included between {segment5.ExtremityOne} and {segment5.ExtremityTwo} ? {segment5.Include(-6)}");
            Console.WriteLine($"is -12 included between {segment5.ExtremityOne} and {segment5.ExtremityTwo} ? {segment5.Include(-12)}");
            Console.WriteLine();


            segment5.Order();
            Console.WriteLine(segment5);
            Console.WriteLine();


            Segment segment6 = new Segment(-5, 2);
            Console.WriteLine($"is 1 included between {segment6.ExtremityOne} and {segment6.ExtremityTwo} ? {segment6.Include(1)}");
            Console.WriteLine($"is -6 included between {segment6.ExtremityOne} and {segment6.ExtremityTwo}  ?  {segment6.Include(-6)}");
            Console.WriteLine();


            segment6.Order();
            Console.WriteLine(segment6);
            Console.WriteLine();

        }
    }
}