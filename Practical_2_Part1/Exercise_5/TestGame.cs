namespace Exercise_5
{
    internal class TestGame
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Game game = new Game();
                game.FullGame();
            }

        }
    }
}