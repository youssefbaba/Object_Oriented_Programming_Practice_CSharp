using System.ComponentModel;

namespace Exercise_8
{
    // Difining the delegate
    public delegate double DelegateOperation(int number1, int number2);
    public delegate void DelegateCalc(int number1, int number2);
    public class Calculator
    {
        public static double Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public static double Sub(int number1, int number2)
        {
            return number1 - number2;
        }
        public static double Mul(int number1, int number2)
        {
            return number1 * number2;
        }
        public static double Div(int number1, int number2)
        {
            return (number2 == 0) ? 0 : (double)number1 / number2;
        }

        //public void Calc(int number1 , int number2 , Add(number1 , number2)) //we cannot add method as parameter but we can use delegate
        public void Calc(int number1, int number2, DelegateOperation operation)
        {
            Console.WriteLine($"The result = {operation(number1, number2)}");
           
            /*
            // using anonymous method
            DelegateCalc op = delegate (int x, int y)
            {
                Console.WriteLine($"{x * y * 10}");
            };
            op(1, 2);
            */

            // using lambda expression
            DelegateCalc op = (x, y) => Console.WriteLine($"{x * y * 10}");
            op(1, 2);

        }


        static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                Console.WriteLine($"The result = {Add(10, 20)}");
                Console.WriteLine($"The result = {Sub(17, 2)}");
                Console.WriteLine($"The result = {Mul(10, 3)}");
                Console.WriteLine($"The result = {Div(24, 5)}");
                Console.WriteLine();


                //DelegateOperation obj1 = Add;
                //calculator.Calc(10, 20, obj1);
                calculator.Calc(10, 20, Add);


                //DelegateOperation obj2 = Sub;
                //calculator.Calc(17, 2, obj2);
                calculator.Calc(17, 2, Sub);


                //DelegateOperation obj3 = Mul;
                //calculator.Calc(10, 3, obj3);
                calculator.Calc(10, 3, Mul);


                //DelegateOperation obj4 = Div;
                //calculator.Calc(24, 5, obj4);
                calculator.Calc(24, 5, Div);


            }
        }
    }
