using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SurfaceOfTriangle
{
    static void SideAndAltitude(double side, double altitude)
    {
        double result = (side * altitude) / 2;
        Console.WriteLine("Side and altitude area: {0}", result);
    }
    static void ThreeSides(double sideOne, double sideTwo, double sideThree)
    {
        double p = (sideOne + sideTwo + sideThree) / 2;
        double result = Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
        Console.WriteLine("Three sides area: {0}", result);
    }

    static void TwoSidesAndAngle(double sideOne, double sideTwo, double angle)
    {
        double result = (sideOne * sideTwo * Math.Sin(angle)) / 2;
        Console.WriteLine("Two sides and angle area: {0}", result);
    }
    static void Main()
    {
        Console.Write(
            "Choose a method, 1 for side and altitude, 2 for three sides ");
        Console.WriteLine("3 for two sides and angle");
        int keyPressed = Convert.ToInt32(Console.ReadKey().KeyChar) - 48;
        Console.WriteLine();
        if (keyPressed == 1)
        {
            Console.WriteLine(
                "Give me side and altitude");
            SideAndAltitude(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        else if(keyPressed == 2)
        {
            Console.WriteLine(
                "Give me three sides");
            ThreeSides(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        else if(keyPressed == 3)
        {
            Console.WriteLine(
                "Give me two and sides and an angle");
            TwoSidesAndAngle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        else
        {
            Console.WriteLine("Nope");
        }
    }

}

