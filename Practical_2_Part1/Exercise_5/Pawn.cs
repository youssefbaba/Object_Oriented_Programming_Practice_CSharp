namespace Exercise_5
{
    public class Pawn
    {
        // Fields
        string _color;
        bool _speed;


        // Constructors
        public Pawn(string color, bool speed, int position)
        {
            _color = color;
            _speed = speed;
            Position = position;
        }
        public Pawn(string color, bool speed)
        {
            _color = color;
            _speed = speed;
            if (_color.ToLower() == "yellow")
            {
                Position = 0;
            }
            else if (_color.ToLower() == "red")
            {
                Position = 10;
            }
        }

        // Methods
        public bool IsArrive()
        {
            if ((_color.ToLower() == "yellow") && (Position >= 29))
            {
                return true;
            }
            else if ((_color.ToLower() == "red") && (Position >= 39))
            {
                return true;
            }
            return false;
        }

        public void ToAdvance(int step)
        {
            Position += step;
            if ((_color.ToLower() == "yellow") && (Position > 29))
            {
                Position = 29;
            }
            else if ((_color.ToLower() == "red") && (Position > 39))
            {
                Position = 39;
            }
        }
        public static void ToAdvance(int step, Pawn pawn)
        {
            pawn.ToAdvance(step);
        }

        public bool Conflict(Pawn pawn)
        {
            if (Position == pawn.Position)
            {
                if (_color.ToLower() == "yellow")
                {
                    Position = 0;
                }
                else if (_color.ToLower() == "red")
                {
                    Position = 10;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MovingForwardInConflict(int step, Pawn pawn)
        {
            Position += step;
            if (Conflict(pawn))
            {
                return;
            }
            else
            {
                ToAdvance(step);
            }
        }

        // Properties
        public int Position { get; private set; }
    }
}
