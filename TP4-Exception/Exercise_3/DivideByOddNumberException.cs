using System.Runtime.Serialization;

namespace Exercise_3
{
    [Serializable]
    public class DivideByOddNumberException : Exception
    {
        // Constructors
        public DivideByOddNumberException() : base("Cannot divide by odd number !")
        {
        }
        public DivideByOddNumberException(string message) : base(message)
        {
        }

        public DivideByOddNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DivideByOddNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
