using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Triangle
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

        public String GetTriangleType()
        {
            var str = "Type: ";
            if (CheckTriangle(A, B, C))
            {
                int kt = 0;
                if (A == B && B == C)
                {
                    str = str + "Equilateral Triangle";
                    kt = 1;
                }
                else
                {
                    if (A == B || B == C || C == A)
                    {
                        str = str + "Isosceles Triangle";
                        kt = 1;
                    }
                    if (A * A + B * B == C * C || B * B + C * C == A * A || C * C + A * A == B * B)
                    {
                        str = str + "Square Triangle";
                        kt = 1;
                    }
                }
                if (kt == 0)
                {
                    str = str + "Normal Triangle";
                }
                
                
            }
            else
            {
                str = str + "Not Triangle";
            }
            return str;
        }

        public static bool CheckTriangle(int A, int B, int C)
        {
            return (A + B > C && B + C > A && C + A > B);
        }

        public int GetPerimeter()
        {
            if (GetTriangleType().Equals("Not Triangle"))
            {
                return 0;
            }
            return A + B + C;
        }

        public double GetArea()
        {
            if (GetTriangleType().Equals("Not Triangle"))
            {
                return 0;
            }
            var p = GetPerimeter() / 2.0;
            var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //var area = Math.Sqrt((A + B + C) * (A + B - C) * (B + C - A) * (C + A - B)) / 4;
            return area;
        }
    }
}
    