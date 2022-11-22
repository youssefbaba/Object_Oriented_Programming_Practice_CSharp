namespace Exercise_1
{
    public class Test1
    {
        public static double Division()
        {
            double[] numbers = new double[5];
            bool check , check1 , check2;
            int counter = 0, index;
            double value , divisor = default;

            while (counter < numbers.Length)
            {
                Console.Write($"Please enter a value {counter + 1} : ");
                check = double.TryParse(Console.ReadLine(), out value);
                if (check)
                {
                    numbers[counter] = value;
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Please try to enter a valid value wich is between {double.MinValue} and {double.MaxValue} !");
                }
            }
            do
            {
                Console.Write("Please enter an index : ");
                check1 = int.TryParse(Console.ReadLine(), out index);
                if (!check1)
                {
                    Console.WriteLine($"Please try again to enter a valid index wich is between {0} and {numbers.Length - 1} !");
                }
                else
                {
                    try
                    {
                        if (index < 0 || index >= numbers.Length)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Please enter a divisor : ");
                                check2 = double.TryParse(Console.ReadLine(), out divisor);
                                if (!check2)
                                {
                                    Console.WriteLine($"Please try again to enter a valid divisor wich is between {double.MinValue} and {double.MaxValue} !");
                                }
                                else
                                {
                                    try
                                    {
                                        if (divisor == 0)
                                        {
                                            throw new DivideByZeroException();
                                        }
                                    }
                                    catch (DivideByZeroException)
                                    {
                                        Console.WriteLine("Please cannot divide by zero !");
                                        Console.WriteLine($"Please try again to enter a valid divisor wich is between {double.MinValue} and {double.MaxValue} and different from zero !");
                                    }
                                }
                            } while (!check2 || divisor == 0);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine($"Please the index must be between 0 and {numbers.Length - 1} !");
                        Console.WriteLine($"Please try again to enter a valid index wiwh is between 0 and {numbers.Length - 1} !");
                    }
                }
            } while (!check1 || index < 0 || index >= numbers.Length);

            return numbers[index] / divisor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"The result is : {Division()}");
        }
    }
}