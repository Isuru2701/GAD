using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string op;
            Console.WriteLine("Console Calculator");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter a number: ");
            do {
                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                    break;
                } catch (Exception)
                {
                    Console.WriteLine("please enter a number only");
                }
            } while (true);
            Console.WriteLine("Enter another number: ");
            do
            {
                try
                {
                    num2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("please enter a number only");
                }
            } while (true);
            Console.WriteLine("Choose option:\na - Add\ns - Substract\nm - Multiply\nd - Divide");
            bool flag = true;
            do
            {
                op = Console.ReadLine();
                switch (op)
                {
                    case "a":
                        Console.WriteLine("Addition of the 2 numbers: " + (num1 + num2));
                        flag = false;
                        break;

                    case "s":
                        Console.WriteLine("Substraction of the 2 numbers: " + (num1 - num2));
                        flag = false;   
                        break;

                    case "m":
                        Console.WriteLine("Multiplication of the 2 numbers: " + (num1 * num2));
                        flag = false;   
                        break;

                    case "d":
                        Console.WriteLine("Division of the 2 numbers: " + (num1 / num2));
                           flag = false;
                        break;
                    default:
                        Console.WriteLine("Error: incorrect code for operator");
                        break;
                };
            } while (flag);
            Console.ReadKey();




        }
    }
}
