namespace Exercise_4
{
    public class Test
    {
        static void Main(string[] args)
        {
            Set set1 = new Set(new List<int> { 1, 5, 7, 8, 9});//  3, 6, 5
            Set set2 = new Set(new List<int> { 2, 0, 3, 8}); // 9, 7, 3
            Set set = new Set();


            set1.Add(3);
            set1.Add(6);
            set2.Add(9);
            set2.Add(7);


            set1.Remove(1); // 5
            set2.Remove(2); // 3
            //set2.Remove(-2); // Exception
            //set2.Remove(10); // Exception


            set1.Add(5);
            set2.Add(3);


            set1.Display();
            set2.Display();


            set.GetOr(set1, set2).Display();
        }
    }
}