namespace Exercise_4
{
    public class Class2 : Interface3 , Interface4
    {
        public void Show()
        {
            Console.WriteLine("Interfaces method implemented in child class");
        }
        void Interface3.show()
        {
            Console.WriteLine("Declared in interface3 implemented in child class");
        }

        void Interface4.show()
        {
            Console.WriteLine("Declared in interface4 implemented in child class");
        }
    }
}
