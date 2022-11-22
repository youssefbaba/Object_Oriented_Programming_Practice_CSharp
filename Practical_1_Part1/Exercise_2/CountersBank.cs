namespace Exercise_2
{
    public class CountersBank
    {
        // Fields
        bool[] _arrayCounters;      // by default is private

        // Constructors
        public CountersBank(int NumberOfCounters)
        {
            if (NumberOfCounters <= 0)
            {
                throw new NullReferenceException("Please try to enter a number of counters greater than zero!");
            }
            else
            {
                _arrayCounters = new bool[NumberOfCounters];
                for (int i = 0; i < _arrayCounters.Length; i++)
                {
                    _arrayCounters[i] = true;
                }
            }
        }

        // Methods
        public int FirstFreeCounter()
        {
            if (Array.IndexOf(_arrayCounters, true) != -1)
            {
                return Array.IndexOf(_arrayCounters, true);
            }
            else
            {
                Console.WriteLine("Execuse me , there is no free counter !");
                return Array.IndexOf(_arrayCounters, true);
            }
        }

        public void ChangeState(int counterNumber)
        {
            try
            {
                _arrayCounters[counterNumber] = _arrayCounters[counterNumber] ? false : true;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Please number of counter must be between 0 and {_arrayCounters.Length - 1} !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int TotalFreeCounters()
        {
            int totalFreeCounters = 0;
            int startIndex = 0;
            while (Array.IndexOf(_arrayCounters, true, startIndex) != -1)
            {
                totalFreeCounters++;
                if (Array.IndexOf(_arrayCounters, true, startIndex) < _arrayCounters.Length - 1)
                {
                    int newStartIndex = Array.IndexOf(_arrayCounters, true, startIndex);
                    startIndex = ++newStartIndex;
                }
                else
                {
                    break;
                }
            }
            return (totalFreeCounters > 0) ? totalFreeCounters : -1;
        }
    }
}
