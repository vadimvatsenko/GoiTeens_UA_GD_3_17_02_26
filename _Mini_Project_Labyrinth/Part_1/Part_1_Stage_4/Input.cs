namespace Part_1_Stage_4;

public class Input
{
    public Action OnMoveLeft;
    public Action OnMoveRight;
    public Action OnMoveUp;
    public Action OnMoveDown;

    public void Update()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (!Console.KeyAvailable)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow or ConsoleKey.A:
                    OnMoveLeft?.Invoke();
                    break;
                case ConsoleKey.RightArrow or ConsoleKey.D:
                    OnMoveRight?.Invoke();
                    break;
                case ConsoleKey.UpArrow or ConsoleKey.W:
                    OnMoveUp?.Invoke();
                    break;
                case ConsoleKey.DownArrow or ConsoleKey.S:
                    OnMoveDown?.Invoke();
                    break;
                default:
                    break;
            }
        }
    }
}