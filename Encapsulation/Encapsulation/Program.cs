using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Pulsar2000
    {
        int speed = 0, gear = 0; // state (attribute)
        string color; 

        void SpeedUp(int a) //behaviours (method)
        {
            speed += a;
            Console.WriteLine("Current speed: " + speed);
        }

        void SpeedDown(int a)
        {
            speed -= a;
            Console.WriteLine("Current speed: " + speed);

        }

        void GearUp(int a)
        {
            gear += a;
            Console.WriteLine("Current gear: " + speed);

        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }   
}
