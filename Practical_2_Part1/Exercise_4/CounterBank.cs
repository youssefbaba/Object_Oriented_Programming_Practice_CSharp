namespace Exercise_4
{
    public class CounterBank
    {
        // Fields
        bool[] _arrayCounter;       // by default is private

        // Constructors
        public CounterBank(int length)
        {
            _arrayCounter = new bool[length];
            for (int i = 0; i < _arrayCounter.Length; i++)
            {
                _arrayCounter[i] = true;
            }
        }

        public int FirstFreeCounter()
        {
            // Method 1
            //for (int i = 0; i < _arrayCounter.Length; i++)
            //{
            //    if (_arrayCounter[i] == true)
            //    {
            //        return i;
            //    }
            //}
            //Console.WriteLine("No counter is free !");
            //return -1;


            // Method 2
            if (Array.IndexOf(_arrayCounter, true) >= 0)
            {
                return Array.IndexOf(_arrayCounter, true);
            }
            Console.WriteLine("No counter is free !");
            return Array.IndexOf(_arrayCounter, true);
        }
        public void ChangeState(int index)
        {
            _arrayCounter[index] = (_arrayCounter[index] == true) ? false : true;
        }
        public int TotalFreeCounter()
        {
            // Method 1
            //int counter = 0;
            //for (int i = 0; i < _arrayCounter.Length; i++)
            //{
            //    if (_arrayCounter[i] == true)
            //    {
            //        counter++;
            //    }
            //}
            //return counter;


            // Method 2
            int counter = 0;
            int startIndex = 0;
            while (Array.IndexOf(_arrayCounter, true, startIndex) >= 0)
            {
                counter++;
                startIndex = Array.IndexOf(_arrayCounter, true, startIndex) + 1;
                if (startIndex > _arrayCounter.Length)
                {
                    break;
                }
            }
            return counter;
        }
    }
}
