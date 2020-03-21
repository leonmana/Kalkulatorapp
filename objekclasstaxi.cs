using System;
namespace LatClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.driverName     = "leon cihuy";
            taxi.onDuty         = true;
            taxi.NumPassenger   = 15;
          
            taxi.TaxiInfo();
            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
    class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0}", driverName);
            if(onDuty)
            {
                Console.WriteLine("On Duty              : Yes");
            } else
            {
                Console.WriteLine("On Duty              : No");
            }
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} sedang menjemput penumpang", driverName);
            } else
            {
                Console.WriteLine("Driver {0} tidak menjemput penumpang", driverName);
            }
        }
        public void DropOffPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} selesai mengantar penumpang", driverName);
            } else
            {
                Console.WriteLine("Driver {0} penumpang tidak tersedia  ", driverName);
            }
        }
    }
}