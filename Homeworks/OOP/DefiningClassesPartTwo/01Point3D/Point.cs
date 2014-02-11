using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    public struct Point3D
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        private static readonly Point3D zero = new Point3D(0,0,0);
        public static Point3D Zero
        {
            get { return zero; }
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.y = z;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", this.x, this.y, this.z);
        }
    }
}
