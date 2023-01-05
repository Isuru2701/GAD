using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_01_2023Practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parity();
            Calculator();
            Console.ReadKey();

        }

        static void Parity()
        {
            int number;
            Console.WriteLine("Enter number: ");
            number = Convert.ToInt16(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("number is odd");
            }
            else
            {
                Console.WriteLine("number is even");
            }
        }

        static void Calculator() 
        {
            double num1, num2, num3;
            int op;
            Console.WriteLine("---CALCULATOR---");
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation: \n1. addition\n2. substraction\n3. multiplication");
            op = Convert.ToInt16(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("addition = " + (num1 + num2 + num3));
                    break;

                case 2:
                    Console.WriteLine("substraction = " + (num1 - num2 - num3));
                    break;

                case 3:
                    Console.WriteLine("multiplcation = " + (num1 * num2 * num3));
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
