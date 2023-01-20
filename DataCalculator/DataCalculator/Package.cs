using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalculator
{
    internal class Package
    {
        public static double Total { get; set; }

        public static double CalDayBlast(double dayUse, double nightUse)
        {
            /*
             * Day Charge (Upto 50GB) = 400
             * Night Charge (Upto 10GB) = 200
             * Rental = 200
             * Addon Day time = 10
             * Addon Night time  = 20
            */

            //Day charge + night charge + rental
            Total = 400 + 200 + 200;

            //addons 
            if (dayUse > 50)
            {
                Total += ((dayUse - 50) * 10);

            }

            if (nightUse > 10)
            {
                Total += ((nightUse - 10) * 20);
            }

            //taxation (happens after the original sum is calculated)
            if (Total > 1000)
            {
                Total += 350;
            }
            else
            {
                Total += 250;
            }
            return Total;
        }

        public static double CalNightBlast(double dayUse, double nightUse)
        {
            /*
             * Day Charge (Upto 10GB) = 200
             * Night Charge (Upto 100GB) = 600
             * Rental = 400
             * Addon Day time = 20
             * Addon Night time  = 10
            */

            //Day charge + night charge + rental
            Total = 200 + 600 + 400;

            //addons 
            if (dayUse > 10)
            {
                Total += ((dayUse - 10) * 20);
            }

            if (nightUse > 100)
            {
                Total += ((nightUse - 100) * 10);
            }


            //taxation (happens after the original sum is calculated)
            if (Total > 1500)
            {
                Total += 450;
            }
            else
            {
                Total += 350;
            }
            return Total;

        }
    }

}
