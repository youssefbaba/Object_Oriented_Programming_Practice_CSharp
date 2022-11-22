namespace Exercise_5
{
    public class Game
    {
        // Fields
        Pawn _yellowFast;
        Pawn _yellowSlow;
        Pawn _redFast;
        Pawn _redSlow;

        public Game()
        {
            _yellowFast = new Pawn("yellow", true);
            _yellowSlow = new Pawn("yellow", false);
            _redFast = new Pawn("red", true);
            _redSlow = new Pawn("red", false);
        }

        // Constructors
        public void Play(string color)
        {
            Random random = new Random();
            int randomSelect = random.Next(0, 2);
            int stepSlow = random.Next(1, 7);
            int stepFast = random.Next(1, 7) + random.Next(1, 7);
            if (color.ToLower() == "yellow")
            {
                switch (randomSelect)
                {
                    case 0:
                        if ((stepSlow + _yellowSlow.Position) == _redSlow.Position)
                        {
                            _yellowSlow.MovingForwardInConflict(stepSlow, _redSlow);
                        }
                        else if ((stepSlow + _yellowSlow.Position) == _redFast.Position)
                        {
                            _yellowSlow.MovingForwardInConflict(stepSlow, _redFast);
                        }
                        else
                        {
                            _yellowSlow.ToAdvance(stepSlow);
                        }
                        break;
                    case 1:
                        if ((stepFast + _yellowFast.Position) == _redSlow.Position)
                        {
                            _yellowFast.MovingForwardInConflict(stepFast, _redSlow);
                        }
                        else if ((stepFast + _yellowFast.Position) == _redFast.Position)
                        {
                            _yellowFast.MovingForwardInConflict(stepFast, _redFast);
                        }
                        else
                        {
                            _yellowFast.ToAdvance(stepFast);
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (color.ToLower() == "red")
            {
                switch (randomSelect)
                {
                    case 0:
                        if ((stepSlow + _redSlow.Position) == _yellowSlow.Position)
                        {
                            _redSlow.MovingForwardInConflict(stepSlow, _yellowSlow);
                        }
                        else if ((stepSlow + _redSlow.Position) == _yellowFast.Position)
                        {
                            _redSlow.MovingForwardInConflict(stepSlow, _yellowFast);
                        }
                        else
                        {
                            _redSlow.ToAdvance(stepSlow);
                        }
                        break;
                    case 1:
                        if ((stepFast + _redFast.Position) == _yellowSlow.Position)
                        {
                            _redFast.MovingForwardInConflict(stepFast, _yellowSlow);
                        }
                        else if ((stepFast + _redFast.Position) == _yellowFast.Position)
                        {
                            _redFast.MovingForwardInConflict(stepFast, _yellowFast);
                        }
                        else
                        {
                            _redFast.ToAdvance(stepFast);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void PlayEdit(string color)
        {
            Random random = new Random();
            int randomSelect = random.Next(0, 2);
            int stepSlow = random.Next(1, 7);
            int stepFast = random.Next(1, 7) + random.Next(1, 7);
            if (color.ToLower() == "yellow")
            {
                switch (randomSelect)
                {
                    case 0:
                        if (!_yellowSlow.IsArrive())
                        {
                            if ((stepSlow + _yellowSlow.Position) == _redSlow.Position)
                            {
                                _yellowSlow.MovingForwardInConflict(stepSlow, _redSlow);
                            }
                            else if ((stepSlow + _yellowSlow.Position) == _redFast.Position)
                            {
                                _yellowSlow.MovingForwardInConflict(stepSlow, _redFast);
                            }
                            else
                            {
                                _yellowSlow.ToAdvance(stepSlow);
                            }
                        }
                        break;
                    case 1:
                        if (!_yellowFast.IsArrive())
                        {
                            if ((stepFast + _yellowFast.Position) == _redSlow.Position)
                            {
                                _yellowFast.MovingForwardInConflict(stepFast, _redSlow);
                            }
                            else if ((stepFast + _yellowFast.Position) == _redFast.Position)
                            {
                                _yellowFast.MovingForwardInConflict(stepFast, _redFast);
                            }
                            else
                            {
                                _yellowFast.ToAdvance(stepFast);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (color.ToLower() == "red")
            {
                switch (randomSelect)
                {
                    case 0:
                        if (!_redSlow.IsArrive())
                        {
                            if ((stepSlow + _redSlow.Position) == _yellowSlow.Position)
                            {
                                _redSlow.MovingForwardInConflict(stepSlow, _yellowSlow);
                            }
                            else if ((stepSlow + _redSlow.Position) == _yellowFast.Position)
                            {
                                _redSlow.MovingForwardInConflict(stepSlow, _yellowFast);
                            }
                            else
                            {
                                _redSlow.ToAdvance(stepSlow);
                            }
                        }
                        break;
                    case 1:
                        if (!_redFast.IsArrive())
                        {
                            if ((stepFast + _redFast.Position) == _yellowSlow.Position)
                            {
                                _redFast.MovingForwardInConflict(stepFast, _yellowSlow);
                            }
                            else if ((stepFast + _redFast.Position) == _yellowFast.Position)
                            {
                                _redFast.MovingForwardInConflict(stepFast, _yellowFast);
                            }
                            else
                            {
                                _redFast.ToAdvance(stepFast);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public bool HasWon(string color)
        {
            if (color.ToLower() == "yellow" && _yellowSlow.IsArrive() && _yellowFast.IsArrive())
            {
                Console.WriteLine($"Yellow is the winner");
                return true;
            }
            else if (color.ToLower() == "red" && _redSlow.IsArrive() && _redFast.IsArrive())
            {
                Console.WriteLine($"Red is the winner");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void FullGame()
        {
            Random random = new Random();
            int randomStart = random.Next(0, 2);
            do
            {
                if (randomStart == 0)
                {
                    PlayEdit("yellow");
                    randomStart = 1;
                    if (HasWon("yellow"))
                    {
                        break;
                    }
                }
                else if (randomStart == 1)
                {
                    PlayEdit("red");
                    randomStart = 0;
                    if (HasWon("red"))
                    {
                        break;
                    }
                }
            } while (!HasWon("yellow") && !HasWon("red"));
        }
    }
}
