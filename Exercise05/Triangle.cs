using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Triangle : Shape
    {
        public int A { set; get; }
        public int B { set; get; }
        public int C { set; get; }

        public Triangle(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public static bool CheckTriangle(int A, int B, int C)
        {
            return (A + B > C && B + C > A && C + A > B);
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override double GetArea()
        {
            var p = GetPerimeter() / 2.0;
            var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //var area = Math.Sqrt((A + B + C) * (A + B - C) * (B + C - A) * (C + A - B)) / 4;
            return area;
        }
    }
}
