namespace Exercise_1
{
    public class Commune
    {
        // Fields
        Habitation[] _arrayHabitations;  // by default is private
        int _currentIndex;
        int _length = 4;


        // Constructors
        public Commune()
        {
            _arrayHabitations = new Habitation[_length];
            _currentIndex = -1;
        }


        // Methods
        public void Add(Habitation item)
        {
            if (_currentIndex == _arrayHabitations.Length - 1)
            {
                Habitation[] newArrayHabitations = new Habitation[_length * 2];
                Array.Copy(_arrayHabitations, newArrayHabitations, _arrayHabitations.Length);
                _arrayHabitations = newArrayHabitations;
            }
            _arrayHabitations[++_currentIndex] = item;
        }
       public void Show()
        {
            for (int i = 0; i <= _currentIndex; i++)
            {
                _arrayHabitations[i].Display();
                Console.WriteLine($"Tax = {_arrayHabitations[i].Tax()} DH");
                Console.WriteLine();
            }
        }
    }
}
