using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    static class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            return Math.Sqrt(
                Math.Pow(
                point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2) + Math.Pow(point1.z - point2.z, 2));
        }
    }
}
