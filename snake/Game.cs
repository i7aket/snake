namespace snake;

public class Game
{
    Walls _walls = new Walls();
    Fruits _fruits = new Fruits();
    Snake _snake = new Snake();
    private Timer _timer;
    ConsoleKeyInfo e;
    private int t = 250;

    public Game()
    {
        Console.CursorVisible = false;

        _timer = new Timer(Callback, null, t, t);

        do
        {
            e = Console.ReadKey();

        } while (e.Key != ConsoleKey.Escape);
    }

    private void Callback(object? state)
    {
        switch (e.Key)
        {
            case ConsoleKey.RightArrow:
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                if (_snake.Right(_fruits, _walls)) GameOver();
                _timer.Change(t, t);
                break;

            case ConsoleKey.DownArrow:
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                if (_snake.Down(_fruits, _walls)) GameOver();
                _timer.Change(t, t);
                break;

            case ConsoleKey.LeftArrow:
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                if (_snake.Left(_fruits, _walls)) GameOver();
                _timer.Change(t, t);
                break;

            case ConsoleKey.UpArrow:
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                if (_snake.Up(_fruits, _walls)) GameOver();
                _timer.Change(t, t);
                break;
        }
    }

    public void GameOver()
    {
        Console.SetCursorPosition(13,10);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Length of your snake is {_snake.Blocks.Count}");
        Console.SetCursorPosition(21,11);
        Console.WriteLine("Game Over");
        Console.ReadKey();
        Console.Clear();
        _walls = new Walls();
        _fruits = new Fruits();
        _snake = new Snake();
    }
}