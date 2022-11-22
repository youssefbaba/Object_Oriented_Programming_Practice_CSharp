namespace Exercise_1
{
    public class Test
    {
        static void Main(string[] args)
        {
            Equation myEquationOne = new Equation(3, 5, 2);
            myEquationOne.DisplayEquation();
            myEquationOne.CalculRoots();
            Console.WriteLine();


            Equation myEquationTwo = new Equation(3, -6, 3);
            myEquationTwo.DisplayEquation();
            myEquationTwo.CalculRoots();
            Console.WriteLine();


            Equation myEquationThree = new Equation(1, 2, 5);
            myEquationThree.DisplayEquation();
            myEquationThree.CalculRoots();
            Console.WriteLine();


            Equation myEquationFour = new Equation(0, 6, 3);
            myEquationFour.DisplayEquation();
            myEquationFour.CalculRoots();
            Console.WriteLine();
        }
    }
}