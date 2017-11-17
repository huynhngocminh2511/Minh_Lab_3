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
            if (Triangle.CheckTriangle(2, 3, 4))
            {
                var tri = new Triangle(2, 3, 4);
                Console.WriteLine(tri.GetTriangleType());
                Console.WriteLine("Perimeter: " + tri.GetPerimeter());
                Console.WriteLine("Area: " + tri.GetArea());
            }
            if (Triangle.CheckTriangle(2, 2, 3))
            {
                var tri = new Triangle(2, 2, 3);
                Console.WriteLine(tri.GetTriangleType());
                Console.WriteLine("Perimeter: " + tri.GetPerimeter());
                Console.WriteLine("Area: " + tri.GetArea());
            }
            if (Triangle.CheckTriangle(3, 3, 3))
            {
                var tri = new Triangle(3, 3, 3);
                Console.WriteLine(tri.GetTriangleType());
                Console.WriteLine("Perimeter: " + tri.GetPerimeter());
                Console.WriteLine("Area: " + tri.GetArea());
            }
            if (Triangle.CheckTriangle(3, 4, 5))
            {
                var tri = new Triangle(3, 4, 5);
                Console.WriteLine(tri.GetTriangleType());
                Console.WriteLine("Perimeter: " + tri.GetPerimeter());
                Console.WriteLine("Area: " + tri.GetArea());
            }
            Console.ReadKey();
        }
    }
}
