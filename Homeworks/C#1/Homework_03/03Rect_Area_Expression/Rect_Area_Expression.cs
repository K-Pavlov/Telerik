using System;

class Rect_Area
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give width and height pls");
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("Area is: " + area);
    }
}

