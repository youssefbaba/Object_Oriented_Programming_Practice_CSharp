namespace Exercise_4
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Interface1 i1 = new Class1();
            Interface2 i2 = new Class1();
            Class1 c1 = new Class1();
            Console.WriteLine($"The result = {i1.Sub(20, 10)}");
            Console.WriteLine($"The result = {i2.Sub(18, 5)}");
            Console.WriteLine($"The result = {c1.Sub(16, 8)}");
        }
    }
}