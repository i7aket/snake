namespace snake;

public class Snake : Element
{
    public Snake():base('%',1)
    {
        
    }

    public bool Right(Element fruits, Element walls)
    {
        
        
        if (EatBlock(fruits))
        {
            AddBody(Blocks[^1].Top, Blocks[^1].Left);
        }

        Console.SetCursorPosition(Blocks[^1].Left, Blocks[^1].Top);
        Console.Write(' ');
        
        Move();
        
        Blocks[0].Left++;
        
        if (CheckCollision(walls))
        { 
            return true;
        }
        Show();
        return false;
    }

    public bool Left(Element fruits, Element walls)
    {
        if (EatBlock(fruits))
        {
            AddBody(Blocks[^1].Top, Blocks[^1].Left+1);
        }

        Console.SetCursorPosition(Blocks[^1].Left, Blocks[^1].Top);
        Console.Write(' ');
        
        Move();
        Blocks[0].Left--;
        if (CheckCollision(walls))
        {
            return true;
        }
        Show();
        return false;
    }

    public bool Up(Element fruits, Element walls)
    {
        if (EatBlock(fruits))
        {
            AddBody(Blocks[^1].Top + 1, Blocks[^1].Left);
        }

        Console.SetCursorPosition(Blocks[^1].Left, Blocks[^1].Top);
        Console.Write(' ');
        
        Move();
        Blocks[0].Top--;
        
        if (CheckCollision(walls))
        {
            return true;
        }
        Show();
        return false;
    }

    public bool Down(Element fruits, Element walls)
    {
        
        if (EatBlock(fruits))
        {
            AddBody(Blocks[^1].Top - 1, Blocks[^1].Left);
        }
        Console.SetCursorPosition(Blocks[^1].Left, Blocks[^1].Top);
        Console.Write(' ');
        Move();
        
        Blocks[0].Top++;
        
        if (CheckCollision(walls))
        {
            return true;
        }
        Show();
        return false;
    }
    

    public bool EatBlock(Element fruits)
    {
        for (int i = 0; i < fruits.Blocks.Count; i++)
        {
            if (Blocks[0].Left == fruits.Blocks[i].Left && Blocks[0].Top == fruits.Blocks[i].Top)
            {
                fruits.Blocks.RemoveAt(i);
                fruits.RandomBlock('*');
                fruits.Show();
                return true;
            }
        }

        return false;
    }
    public bool CheckCollision(Element element)
    {
        foreach (var t in element.Blocks)
        {
            if (Blocks[0].Left == t.Left && Blocks[0].Top == t.Top)
            {
                return true;
            }
        }
        
        for (int i = 1; i < Blocks.Count; i++)
        {
            if (Blocks[0].Left == Blocks[i].Left && Blocks[0].Top == Blocks[i].Top)
            {
                return true; 
            }
        }
        return false;
    }

    public void AddBody(int top, int left)
    {
        Blocks.Add(new Block(top, left, ConsoleColor.Green, 'O'));
    }

    public void Move()
    {
        if (Blocks.Count != 1)
        {
            for (int i = Blocks.Count-1; i > 0; i--)
            {
                Blocks[i].Left = Blocks[i-1].Left;
                Blocks[i].Top = Blocks[i-1].Top;
            }
        }
    }
}