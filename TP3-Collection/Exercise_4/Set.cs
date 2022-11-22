namespace Exercise_4
{
    public class Set
    {
        // Fields
        List<int> _list;


        // Constructors
        public Set()
        {
            _list = new List<int>();
        }
        public Set(List<int> list)
        {
            _list = list;
        }


        // Methods
        public void Add(int number)
        {
            _list.Add(number);
        }
        public static bool Exist(int number, Set set)
        {
            return set._list.Contains(number);
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new IndexOutOfRangeException();
            }
            _list.RemoveAt(index);
        }
        public Set GetOr(Set set1, Set set2)
        {
            Set set3 = new Set();
            for (int i = 0; i < set1._list.Count; i++)
            {
                if (!Exist(set1._list[i], set2))
                {
                    set3._list.Add(set1._list[i]);
                }
            }
            for (int j = 0; j < set2._list.Count; j++)
            {
                if (!Exist(set2._list[j], set1))
                {
                    set3._list.Add(set2._list[j]);
                }
            }
            return set3;
        }
        public void Display()
        {
            foreach (int item in _list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
