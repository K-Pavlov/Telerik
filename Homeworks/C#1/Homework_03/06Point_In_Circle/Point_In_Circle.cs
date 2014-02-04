using System;

class Point_In_Circle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give x and y");
        float x = float.Parse( Console.ReadLine() );
        float y = float.Parse( Console.ReadLine() );
        Console.WriteLine( ( Math.Sqrt(x*x + y*y) <= 5 ) == true ? "Point is in circle" : "Point is not in Circle");
    }
}

