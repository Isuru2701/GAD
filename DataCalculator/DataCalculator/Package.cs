using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalculator
{
    internal class Package
    {
        public static double DayCharge { get; set; }
        public static double NightCharge { get; set; }
        public static double DayAddon { get; set; }
        public static double NightAddon { get; set; }
        public static double Rental { get; set; }
        public static double Total { get; set; }

        private static double Calculate()
        {
            Total = DayCharge + NightCharge + Rental;
            return Total;
        }

        public static void CalDayBlast(double dayUse, double nightUse)
        {
            Package.DayCharge = 400;
            Package.NightCharge = 200;
            Package.DayAddon = 10;
            Package.NightAddon = 20;
            Package.Rental = 200;

            if (dayUse > 50)
            {
                Package.DayCharge += ((dayUse - 50) * Package.DayAddon);
            }

            if (nightUse > 10)
            {
                Package.NightCharge += ((nightUse - 10) * Package.NightAddon);
            }

            Calculate();
            //taxation
            if (Package.Total > 1000)
            {
                Package.Total += 350;
            }
            else
            {
                Package.Total += 250;
            }
        }

        public static void CalNightBlast(double dayUse, double nightUse)
        {
            Package.DayCharge = 200;
            Package.NightCharge = 600;
            Package.DayAddon = 20;
            Package.NightAddon = 10;
            Package.Rental = 400;

            if (dayUse > 10)
            {
                Package.DayCharge += ((dayUse - 10) * Package.DayAddon);
            }

            if (nightUse > 100)
            {
                Package.NightCharge += ((nightUse - 100) * Package.NightAddon);
            }

            Calculate();

            //taxation
            if (Package.Total > 1500)
            {
                Package.Total += 450;
            }
            else
            {
                Package.Total += 350;
            }

        }
    }

}
