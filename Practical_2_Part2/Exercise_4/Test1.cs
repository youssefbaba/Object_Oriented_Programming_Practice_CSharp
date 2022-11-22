namespace Exercise_4
{
    public class Test1
    {
        static void Main(string[] args)
        {
            Interface3 i3 = new Class2();
            Interface3 i4 = new Class2();
            Class2 c2 = new Class2();
            i3.show();
            i4.show();
            c2.Show();
        }
    }
}
