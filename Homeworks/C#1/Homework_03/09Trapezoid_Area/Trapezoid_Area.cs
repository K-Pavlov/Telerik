using System;

class Trapezoid_Area
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give two sides ,a - b, and height");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int area = (a + b) * h / 2;
        Console.WriteLine("Area is " + area);
    }
}

