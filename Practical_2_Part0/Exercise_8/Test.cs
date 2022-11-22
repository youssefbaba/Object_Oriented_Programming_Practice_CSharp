namespace Exercise_8
{
    // Defining the delegate
    public delegate void DelegateSortingArray(int[] array);
    public class Test
    {
        // Methods
        public static void SortAsc(int[] array)
        {
            Array.Sort(array);

        }
        public static void SortDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public static void SortArray(int[] array, DelegateSortingArray choice)
        {
            choice(array);
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 4, 6, 1, 7, 3 };


            SortArray(array, SortAsc);
            Console.WriteLine();


            SortArray(array, SortDesc);
        }
    }
}
