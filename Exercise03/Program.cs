using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var tri = new Triangle(2, 3, 4);
            Console.WriteLine(tri.GetTriangleType());
            Console.WriteLine("Perimeter: " + tri.GetPerimeter());
            Console.WriteLine("Area: " + tri.GetArea());
            tri = new Triangle(2, 2, 3);
            Console.WriteLine(tri.GetTriangleType());
            Console.WriteLine("Perimeter: " + tri.GetPerimeter());
            Console.WriteLine("Area: " + tri.GetArea());
            tri = new Triangle(3, 3, 3);
            Console.WriteLine(tri.GetTriangleType());
            Console.WriteLine("Perimeter: " + tri.GetPerimeter());
            Console.WriteLine("Area: " + tri.GetArea());
            tri = new Triangle(3, 4, 5);
            Console.WriteLine(tri.GetTriangleType());
            Console.WriteLine("Perimeter: " + tri.GetPerimeter());
            Console.WriteLine("Area: " + tri.GetArea());
            Console.ReadKey();
        }
    }
}
