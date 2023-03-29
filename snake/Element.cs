namespace snake;

public abstract class Element
{
    public List<Block> Blocks = new List<Block>(); 
    
    protected const int MaxLeft = 50; 
    protected const int MaxTop = 20;
    
    public Element(char symbol, int n=1)
    {
        for (int i = 0; i < n; i++)
        {
            Random random = new Random();
            int rndTop = random.Next(1, MaxTop - 1);
            int rndLeft = random.Next(1, MaxLeft - 1);
            Blocks.Add(new Block(rndTop, rndLeft, ConsoleColor.Green, symbol));
        }
        Show();
    }

    public void RandomBlock(char symbol, int n=1)
    {
        for (int i = 0; i < n; i++)
        {
            Random random = new Random();
            int rndTop = random.Next(1, MaxTop - 1);
            int rndLeft = random.Next(1, MaxLeft - 1);
            Blocks.Add(new Block(rndTop, rndLeft, ConsoleColor.Green, symbol));
        }
    }

    public void Show()
    {
        for (var block=0; block < Blocks.Count; block++)
        {
            Console.ForegroundColor = Blocks[block].Color;
            Console.SetCursorPosition(Blocks[block].Left,Blocks[block].Top);
            Console.Write(Blocks[block].Char);
        }
    }
}