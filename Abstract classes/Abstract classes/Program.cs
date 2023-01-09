using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    abstract class Vehicle
    {
        public abstract void SpeedUp();
        public abstract void Brake();
        public abstract void ChangeGear();

    }

    class Car : Vehicle
    {
        public Car()
        {

        }

        public override void SpeedUp()
        {

        }
        public override void Brake() 
        { 
        
        }
        public override void ChangeGear()
        {
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }

       
    }
}
