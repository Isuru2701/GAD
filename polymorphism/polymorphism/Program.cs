using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Human
    {
        public void eat()
        {
            Console.WriteLine("Person ate no meal today");
        }
        public bool eat(string meal1)
        {
            Console.WriteLine("Person ate 1 meal today");
            return true;
        }
        public void eat(string meal1, string meal2)
        {
            Console.WriteLine("Person ate 2 meals today");
        }
        public void eat(string meal1, string meal2, string meal3)
        {
            Console.WriteLine("Person ate 3 meals today");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            char[] array = { 'C', 'H', 'A', 'R' };
            Console.WriteLine(array);

            Human human = new Human();
            Console.WriteLine(human);
            human.eat();
            Console.Read();
        }
    }

}


