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
        protected string car = "a sedan";
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
            Father  father = new Father();
            Console.WriteLine("House attribute is visible outside the class: " + father.house);
            Child child = new Child();
            Console.WriteLine("House attribute is visible outside the class: " + child.house);

            child.display();
            Console.ReadKey();
        }
    }
}
