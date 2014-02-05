using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        private DateTime dateTime;
        public DateTime DateTime
        {
            get { return this.dateTime; }
            set
            {
                if (value > DateTime.Now) throw new ArgumentException("Are you from the future?");
                this.dateTime = value;
            }
        }

        private int numberDialed;
        public int NumberDialed
        {
            get { return this.numberDialed; }
            set { this.numberDialed = value; }
        }

        private float callDurationInSeconds;
        public float CallDurationInSeconds
        {
            get { return this.callDurationInSeconds; }
            set{
                if (value < 0)
                {
                    throw new ArgumentException("Please enter a valid call duration");
                }
                else
                {
                    this.callDurationInSeconds = value; 
                }
            }
        }
        public Call(DateTime dateTime, int numberDialed, int callDurationInSeconds)
        {
            this.dateTime = dateTime;
            this.numberDialed = numberDialed;
            this.callDurationInSeconds = callDurationInSeconds;
        }
    }
}
