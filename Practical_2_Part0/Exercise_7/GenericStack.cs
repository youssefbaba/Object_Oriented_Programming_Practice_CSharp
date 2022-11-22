namespace Exercise_7
{
    public class GenericStack<T>
    {
        // Fields
        T[] _array;     // by default is private
        int _currentIndex;

        // Constructors
        public GenericStack()
        {
            _array = new T[100]; // max = 100
            _currentIndex = -1;
        }

        // Methods
        public void Push(T item)
        {
            if (_currentIndex == _array.Length)
            {
                throw new StackOverflowException();
            }
            _array[++_currentIndex] = item;
        }
        public T Pop()
        {
            T selectedItem;
            if (_currentIndex < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                selectedItem = _array[_currentIndex];
                T[] newArray = new T[_array.Length - 1];
                Array.Copy(_array, newArray, _currentIndex);
                _array = newArray;
                --_currentIndex;
            }
            return selectedItem;
        }
        public void Display()
        {
            if (_currentIndex >= 0)
            {
                for (int i = 0; i <= _currentIndex; i++)
                {
                    Console.Write($"{_array[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
