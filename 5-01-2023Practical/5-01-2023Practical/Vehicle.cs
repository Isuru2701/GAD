using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_01_2023Practical
{
    internal class Vehicle
    {
        private int number;
        private string color;

        public Vehicle(int n, string c)
        {
            number = n;
            color = c;
        }
    }

    class VehicleMain
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(2941, "white");
            

        }
    }
    
}
