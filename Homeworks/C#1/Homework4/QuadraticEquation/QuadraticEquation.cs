using System;

class QuadraticEquation
{
    static int Main(string[] args)
    {
        Console.WriteLine("Quadratic equation: pls give a,b,c");
        float a = float.Parse(Console.ReadLine()),
            b = float.Parse(Console.ReadLine()),
            c = float.Parse(Console.ReadLine()),
            D;

        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation, will solve tho\nx1 = {0}", -b / c);
            return 0;
        }

        D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("No real roots, sorreh");
        }
        else if (D == 0)
        {
            Console.WriteLine("Double root x1 = {0}",-b/2*a);
        }
        else
        {
            Console.WriteLine( "Root x1 = {0} ; x2 = {1}",( -b + Math.Sqrt(D) )/2*a ,( -b - Math.Sqrt(D) )/2*a );
        }
        return 0;
    }
}

