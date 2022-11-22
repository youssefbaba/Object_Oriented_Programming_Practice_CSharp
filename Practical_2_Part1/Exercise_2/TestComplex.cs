namespace Exercise_2
{
    internal class TestComplex
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            Complex complex2 = new Complex(2,4);   
            Complex complex3 = new Complex(2.5,4.2);
            Complex complex4 = new Complex(complex2);


            Console.WriteLine(complex1); // Console.WriteLine(complex1.ToString());
            Console.WriteLine(complex2); // Console.WriteLine(complex2.ToString());
            Console.WriteLine(complex3); // Console.WriteLine(complex3.ToString());
            Console.WriteLine(complex4); // Console.WriteLine(complex4.ToString());
            Console.WriteLine();


            complex2.Add(complex3);
            Console.WriteLine(complex2); // Console.WriteLine(complex2.ToString());
            Console.WriteLine();


            Complex addTwoComplex = Complex.Add(complex4, complex3);
            Console.WriteLine(addTwoComplex); // Console.WriteLine(ddTwoComplex.ToString());

        }
    }
}