namespace Exercise_1
{
    public class Segment
    {
        // Constructors
        public Segment(int extremityOne, int extremityTwo)
        {
            ExtremityOne = extremityOne;
            ExtremityTwo = extremityTwo;
        }

        // Methods
        public int LengthSegment()
        {
            return Math.Abs(ExtremityTwo - ExtremityOne);
        }
        public void Order()
        {
            if (ExtremityOne > ExtremityTwo)
            {
                int temp = ExtremityOne;
                ExtremityOne = ExtremityTwo;
                ExtremityTwo = temp;
            }
        }
        public bool Include(int number)
        {
            return number >= Math.Min(ExtremityOne, ExtremityTwo) && number <= Math.Max(ExtremityOne, ExtremityTwo);
        }
        public override string ToString()
        {
            return $"Segment [{Math.Min(ExtremityOne, ExtremityTwo)} , {Math.Max(ExtremityOne, ExtremityTwo)}]";
        }

        // Properties
        public int ExtremityOne { get; private set; }
        public int ExtremityTwo { get; private set; }
    }
}
