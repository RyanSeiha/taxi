using System;

namespace Class
{
    internal class Taxi
    {
        

        public string DriverName { get;  set; }
        public bool OnDuty { get; set; }
        public int NumbOfPassenger { get; set; }
        public string status { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name         : {0}", DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty             : {0}", status);
            Console.WriteLine("Number of Passenger : {0}\n", NumbOfPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang", DriverName);
        }

        public void DropOfPassenger()
        {
            Console.WriteLine("{0} Sedang mengantar penumpang", DriverName);
        }
    }        
}