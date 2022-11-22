namespace Exercise_3
{
    public class Test
    {
        public static void Division()
        {

            double numerator = default;
            double denominator = default;
            bool check1;
            bool check2;

            do
            {
                Console.Write($"Please enter the first number : ");
                check1 = double.TryParse(Console.ReadLine(), out numerator);
                if (!check1)
                {
                    Console.WriteLine($"Please try again to enter a valid number !");
                }
                else
                {
                    do
                    {
                        Console.Write($"Please enter the second number : ");
                        check2 = double.TryParse(Console.ReadLine(), out denominator);
                        if (!check2)
                        {
                            Console.WriteLine($"Please try again to enter a valid number wich is between {double.MinValue} and {double.MaxValue} !");
                        }
                        else
                        {
                            try
                            {
                                if (denominator == 0)
                                {
                                    throw new DivideByZeroException();
                                }
                                else if ((denominator % 2) != 0)
                                {
                                    //throw new DivideByOddNumberException("Other Message");
                                    throw new DivideByOddNumberException();
                                }
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Cannot divide by zero !");
                                Console.WriteLine($"Please try again to enter a valid number wich is between {double.MinValue} and {double.MaxValue} and different from zero !");
                            }
                            catch (DivideByOddNumberException exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                        }
                    } while (!check2 || denominator == 0 || (denominator % 2) != 0);
                }
            } while (!check1);
            Console.WriteLine($"The result of {numerator} / {denominator} == {numerator/denominator} ");

        }
        static void Main(string[] args)
        {
                Division();
        }
    }
}