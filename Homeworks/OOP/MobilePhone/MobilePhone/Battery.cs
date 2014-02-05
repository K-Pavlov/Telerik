using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCdm, LiPoly
    }

    class Battery
    {
        private string model;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int? hoursIdle;
        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The hours idle can't be a negative number");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        private int? hoursTalk;
        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The hours talk can't be a negative number");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        private BatteryType? batteryType;
        public BatteryType? BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        
        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public string GetBatteryInfo()
        {
            string batteryInfo =
                "model- " + model + ", hours idle- " + hoursIdle + ", hours talk- " 
                + hoursTalk + ", battery type- " + batteryType + ".";
            return batteryInfo;
        }
    }
}
