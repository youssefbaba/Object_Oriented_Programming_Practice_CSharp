namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> generic = new GenericStack<int>();    
            generic.Push(1);
            generic.Push(2);
            generic.Push(3);
            generic.Push(4);
            generic.Display();
            //generic.Push(5); // StackOverflowException
            generic.Pop();
            generic.Pop();
            generic.Display();
            generic.Pop();
            generic.Pop(); 
            //generic.Pop();  // InvalidOperationException

        }
    }
}