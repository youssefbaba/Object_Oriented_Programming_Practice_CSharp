namespace Exercise_2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            /*
            CountersBank countersBankOne = new CountersBank(-10);  // throwing an exception
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                countersBankOne.ChangeState(random.Next(0, 10));
            }
            Console.WriteLine($"First free counter exists in position : {countersBankOne.FirstFreeCounter()}");
            Console.WriteLine($"Total number of free counters is : {countersBankOne.TotalFreeCounters()}");
            */

            
            CountersBank countersBankTwo = new CountersBank(10);
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                countersBankTwo.ChangeState(random.Next(0, 10));
            }
            Console.WriteLine($"First free counter exists in position : {countersBankTwo.FirstFreeCounter()}");
            Console.WriteLine($"Total number of free counters is : {countersBankTwo.TotalFreeCounters()}");
           

        }
    }
}