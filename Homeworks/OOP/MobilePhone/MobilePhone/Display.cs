using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private int? size ;
        private long? colours; 

        public Display(int size, int colours)
        {
            this.size = size;
            this.colours = colours;
        }

        public int? Size
        {
            get{ return this.size; }
            set{ this.size = value; }
        }

        public long? Colours
        {
            get { return this.colours; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The colours can't be a negative number");
                }
                else
                {
                    this.colours = value;
                }
                
                
            }
        }

        public Display(int? size, int? colours)
        {
            this.size = size;
            this.colours = colours;
        }

        public string GetDisplayInfo()
        {
            string displayInfo =
                "size- " + size + ", colours- " + colours + ".";
            return displayInfo;
        }
    }
}
