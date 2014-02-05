using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {
        public static GSM iPhone4s = new GSM(
            "iPhone", "Apple", "SomeDude", 300f, new Battery("someModel", 800, 200, BatteryType.LiIon), new Display(30, 5000));

        private string manufacturer;
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
      
        private float? price;
        public float? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price can't be a negative number");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        
        private string owner;
        public string Owner
        {
            get { return this.owner; }
            set 
            {
                this.owner = value; 
            }
        }
        
        private string model;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private List<Call> callHistory;
        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }
        }
        private Battery battery;
        private Display display;
        
        //Full constructor
        public GSM(string manufacturer, string owner, string model, float? price, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.model = model;
            this.price = price;
            this.battery = battery;
            this.display = display;
            callHistory = new List<Call>();
        }

        //A partial constructor
        public GSM(string manufacturer, string owner, string model, float price)
        {
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.model = model;
            this.price = price;
        }

        //Another partial constructor
        public GSM(string manufacturer, string owner)
        {
            this.manufacturer = manufacturer;
            this.owner = owner;
        }

        //
        public override string ToString()
        {
            string gsmInfo = "Gsm: model- " + model  + "manufacturer- " + manufacturer  + 
                "price- " + price + "owner- " + owner;
            if (battery != null)
            {
                gsmInfo += "\nBattery: " + battery.GetBatteryInfo();
            }
            if (display != null)
            {
                gsmInfo += "\nDisplay: " + display.GetDisplayInfo() + "\n";
            }
            return gsmInfo;
        }

        //Adds a call to the call history
        public void AddCall(string dateString, int phoneNumber, int duration)
        {
            this.callHistory.Add(
                new Call(
                    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture), phoneNumber, duration));
        }

        //Removes a call from the call history
        public void RemoveCall(float callDuration)
        {
            if (callDuration < 0) throw new ArgumentException("Please enter valid call duration");
            this.callHistory.RemoveAll(delegate(Call call) { return call.CallDurationInSeconds == callDuration; });
        }

        //Clears the call history
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public float GetCallsCost(float perMinutesCost)
        {
            float cost = 0f;
            foreach (Call call in callHistory)
            {
                cost += ((call.CallDurationInSeconds / 60) * perMinutesCost);
            }

            return cost;
        }
    }
}
