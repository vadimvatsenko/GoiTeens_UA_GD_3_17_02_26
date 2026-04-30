namespace Part_1_Stage_4;

public class Player: IDisposable
{
    private MazeGenerator _maze;
    public Vector2 Position { get; private set; }
    private Input _input;
    public string Symbol {get; private set; }


    public Player(Input input, MazeGenerator mazeGenerator,  Vector2 position, string symbol)
    {
        Position = position;
        _input = input;
        Symbol = symbol;
        _maze = mazeGenerator;
        
        _input.OnMoveLeft += NextMoveLeft;
        _input.OnMoveRight += NextMoveRight;
        _input.OnMoveDown += NextMoveDown;
        _input.OnMoveUp += NextMoveUp;
    }
    
    public void NextMoveLeft()
    {
        Vector2 nextStep = Position + new Vector2(Position.X - 1, Position.Y);
        Position = CanPlayerMove(nextStep) ? nextStep : Position;
    }

    public void NextMoveRight()
    {
        Vector2 nextStep = Position + new Vector2(Position.X + 1, Position.Y);
        Position = CanPlayerMove(nextStep) ? nextStep : Position;
    }

    public void NextMoveUp()
    {
        Vector2 nextStep = Position + new Vector2(Position.X, Position.Y - 1);
        Position = CanPlayerMove(nextStep) ? nextStep : Position;
    }

    public void NextMoveDown()
    {
        Vector2 nextStep = Position + new Vector2(Position.X, Position.Y + 1);
        Position = CanPlayerMove(nextStep) ? nextStep : Position;
    }

    private bool CanPlayerMove(Vector2 nextStep)
    {
        int x = (int)nextStep.X;
        int y = (int)nextStep.Y;

        // Проверка, чтобы игрок не вышел за границы карты
        if (y < 0 || y >= _maze.GameBoard.GetLength(0))
            return false;

        if (x < 0 || x >= _maze.GameBoard.GetLength(1))
            return false;

        // Получаем символ клетки, куда хочет пойти игрок
        string cell = _maze.GameBoard[y, x];

        // Например, если '#' — это стена
        if (cell == StaticFields.WallSymbol)
            return false;

        return true;
    }

    public void Dispose()
    {
        _input.OnMoveLeft -= NextMoveLeft;
        _input.OnMoveRight -= NextMoveRight;
        _input.OnMoveDown -= NextMoveDown;
        _input.OnMoveUp -= NextMoveUp;
    }
}