using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            var tri = new Triangle(3, 4, 5);
            Console.WriteLine("Perimeter: " + tri.GetPerimeter());
            Console.WriteLine("Area: " + tri.GetArea());
            var rec = new Rect(2, 4);
            Console.WriteLine("Perimeter: " + rec.GetPerimeter());
            Console.WriteLine("Area: " + rec.GetArea());
            var cir = new Circle(3);
            Console.WriteLine("Perimeter: " + cir.GetPerimeter());
            Console.WriteLine("Area: " + cir.GetArea());
            Console.ReadKey();
        }
    }
}
