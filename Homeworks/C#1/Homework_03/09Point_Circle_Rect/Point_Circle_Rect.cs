using System;

class Point
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give x,y");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float need_x = x - 1;
        float need_y = y - 1;
        bool in_circle = Math.Sqrt(need_x * need_x + need_y * need_y) <= 3;
        bool out_rect = (y > 1 || y < -1 && x < 5 || x > -1); 
        Console.WriteLine(in_circle && out_rect  == true ? "It is good" : "Bad");
    }
}

