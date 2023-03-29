//version 0.1
namespace snake;

public class Block
{
    public int Top;
    public int Left;
    public ConsoleColor Color;
    public char Char;
    
    public Block(int top, int left, ConsoleColor color, char symbol = '*')
    {
        Top = top;
        Left = left;
        Color = color;
        Char = symbol;
    }
}