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
        
        //Override makes the class reference the abstract class. The lack of it would present an error
        public override void SpeedUp()
        {
            Console.WriteLine("Car speeds up");
        }
        public override void Brake() 
        {
            Console.WriteLine("Car brakes");
        }
        public override void ChangeGear()
        {
            Console.WriteLine("Car changes gear");
        }

    }

    class Ship : Vehicle
    {
        public override void SpeedUp()
        {
            Console.WriteLine("Ship speeds up");

        }

        public override void Brake()
        {
            Console.WriteLine("Ship slows down");
        }

        public override void ChangeGear()
        {
            Console.WriteLine("Ship changes gear");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SpeedUp();
            car.Brake();
            car.ChangeGear();

            Ship ship = new Ship();
            ship.SpeedUp();
            ship.Brake();
            ship.ChangeGear();

            Console.ReadLine();
        }


       
    }
}
