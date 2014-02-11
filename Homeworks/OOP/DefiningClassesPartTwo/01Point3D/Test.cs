using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    class Test
    {
        public static void Main()
        {
            Point3D point = new Point3D(3,3,5);
            double distance = Distance.CalculateDistance(Point3D.Zero, point );
            Console.WriteLine(distance);
        }
    }
}
