using System;

class CirclePerimeterArea
{
    public static float pi = 3.14f;

    static float circlePerimeter(float r)
    {
        return 2*pi*r;
    }

    static float circleArea(float r)
    {
        return pi * r * r;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Pls give radius");
        float r = float.Parse(Console.ReadLine());
        float perimeter = circlePerimeter(r);
        float area = circleArea(r);
        Console.WriteLine("Perimeter: {0}, area: {1}", perimeter, area);
    }
}

