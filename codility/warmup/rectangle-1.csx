using System;

// To execute C#, please define "static void Main" on a class
// named Solution.
class Rect
{
    public int Width { get; set; }
    public int Height { get; set; }
    
    public Rect(int w, int h)
    {
        Width = w;
        Height = h;
    }
    
    public Rect(): this(1, 1) { }
    
    public int Area() 
    {
        return Width * Height;
    }
    
    public int Perimeter()
    {
        return (2 * Width) + (2 * Height);
    }
    
    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
    }
    
    public override string ToString()
    {
       return $"--> H={Height} W={Width} Area={Area()}";
    }
}

class Util
{
    public static int fact(int n)
    {
        if (n == 1) return 1;
        
        return n * fact(n-1);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello, World");
        }
        
        var n = 6;
        var result = Util.fact(6);
        Console.WriteLine($"--> RECURSIVE --- factorial({n})={result}");
        
        var rectangle = new Rect(4, 4);
        Console.WriteLine(rectangle.ToString());
            
    }
}

var args = new string[] { "a", "b" };
Solution.Main(args);