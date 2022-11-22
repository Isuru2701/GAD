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

        public void SpeedUp(int a) //behaviours (method)
        {
            speed += a;

            Console.WriteLine("Current speed: " + speed);
        }

        public void SpeedDown(int a)
        {
            speed -= a;
            Console.WriteLine("Current speed: " + speed);

        }

        public void GearUp(int a)
        {
            gear += a;
            Console.WriteLine("Current gear: " + speed);

        }
        public void GearDown(int a)
        {
            gear -= a;
            Console.WriteLine("Current gear: " + speed);

        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Pulsar2000 bike1 = new Pulsar2000();
            bike1.SpeedUp(1);

            Console.ReadKey();
        }
    }
}
