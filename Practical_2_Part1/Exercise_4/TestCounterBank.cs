namespace Exercise_4
{
    internal class TestCounterBank
    {
        static void Main(string[] args)
        {
            CounterBank counterBank = new CounterBank(7);
            //counterBank.ChangeState(0);
            counterBank.ChangeState(2);
            counterBank.ChangeState(3);
            Console.WriteLine($"The first free counter is in position : {counterBank.FirstFreeCounter()}");
            Console.WriteLine($"The total free counters is : {counterBank.TotalFreeCounter()}");
        }

    }
}