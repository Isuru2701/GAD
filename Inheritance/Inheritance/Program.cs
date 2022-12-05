using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Father
    {
        public string house = "two-storey";
        public string car = "sedan";
        string designation = "Director";

    }

    class Child : Father //inheritance
    {
        public void display()
        {
            Console.WriteLine("This is my car: " + car);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.display();
        }
    }
}
