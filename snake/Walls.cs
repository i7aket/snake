namespace snake;

public class Walls : Element
{
    public Walls() : base('█',0)
    {
        
        for (int i = 0; i < MaxTop; i++)
        {
            Blocks.Add(new Block(i,0, ConsoleColor.Red, '█'));
        }
        for (int i = 0; i < MaxTop; i++)
        {
            Blocks.Add(new Block(i,MaxLeft, ConsoleColor.Red, '█'));
        }
        for (int i = 0; i < MaxLeft; i++)
        {
            Blocks.Add(new Block(0,i, ConsoleColor.Red, '█'));
        }
        for (int i = 0; i < MaxLeft; i++)
        {
            Blocks.Add(new Block(MaxTop,i, ConsoleColor.Red, '█'));
        }
        Show();
    }
}