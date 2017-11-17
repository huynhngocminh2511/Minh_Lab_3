using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rect(2, 4);
            Console.WriteLine("Perimeter: " + rec.GetPerimeter());
            Console.WriteLine("Area: " + rec.GetArea());
            Console.ReadKey();
        }
    }
}
