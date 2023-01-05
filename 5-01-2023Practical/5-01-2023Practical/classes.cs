using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Rectangle
    {
        private double length, height, width, volume = 0;
        public void SetData(double l, double h, double w)
        {
            length = l;
            height = h;
            width = w;

        }

        public void CalVolume()
        {
            volume = length * width * height;
        }

        public void DisplayData()
        {
            Console.WriteLine("Volume = " + volume);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetData(10, 20, 30);
            rectangle.CalVolume();
            rectangle.DisplayData();
            Console.ReadKey();
        }
    }
}
