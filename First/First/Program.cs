using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program //Main class
    {
        static void Main(string[] args) //Main method
        {
            string name = "";
            string index = "";
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("What is your Index Number? ");
            index = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "\nYour Index Number is " + index);
            Console.ReadKey();


            

        }
    }
}
