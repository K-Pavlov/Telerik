using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01Point3D
{
    static class PathStorage
    {
        public static Path LoadPath(string filePath)
        {
            StreamReader input = new StreamReader(filePath);
            Path path = new Path();

            using (input)
            {
                string inputLine = input.ReadLine();
                while (inputLine != null)
                {
                    string[] point = inputLine.Split(' ');
                    path.AddPoint(
                        new Point3D( int.Parse(point[0]), int.Parse(point[1]), int.Parse(point[2]) ));
                    inputLine = input.ReadLine();
                }
            }

            return path;
        }

        public static void SavePath(string filePath, Path path)
        {
            StreamWriter output = new StreamWriter(filePath);

            using (output)
            {
                foreach (var point in path.Route)
                {
                    output.WriteLine("{0} {1} {2}", point.x, point.y, point.z);
                }
            }
        }
    }
}
