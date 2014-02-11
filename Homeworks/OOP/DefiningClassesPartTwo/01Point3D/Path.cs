using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private readonly List<Point3D> route;

        public List<Point3D> Route
        {
            get { return route; }
        }

        public Path()
        {
            route = new List<Point3D>();
        }

        public Path(int pathSize)
        {
            route = new List<Point3D>(pathSize);
        }

        public void AddPoint(Point3D point)
        {
            route.Add(point);
        }
    }
}
