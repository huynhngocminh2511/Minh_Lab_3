using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Triangle
    {
        public int q { set; get; }
        public int w { set; get; }
        public int e { set; get; }
        public Triangle(int q, int w, int e)
        {
            this.q = q;
            this.w = w;
            this.e = e;
        }
        public String GetTriangleType()
        {
            var str = "Type: ";
            if (q + w > e && w + e > q && e + q > w)
            {
                int kt = 0;
                if (q == w && w == e)
                {
                    str = str + "Equilateral Triangle";
                    kt = 1;
                }
                else
                {
                    if (q == w || w == e || e == q)
                    {
                        str = str + "Isosceles Triangle";
                        kt = 1;
                    }
                    if (q * q + w * w == e * e || w * w + e * e == q * q || e * e + q * q == w * w)
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
        public int GetPerimeter()
        {
            if (GetTriangleType().Equals("Not Triangle"))
            {
                return 0;
            }
            var perimeter = q + w + e;
            return perimeter;
        }
        public double GetArea()
        {
            if (GetTriangleType().Equals("Not Triangle"))
            {
                return 0;
            }
            var area = Math.Sqrt((q + w + e) * (q + w - e) * (w + e - q) * (e + q - w)) / 4;
            return area;
        }
    }
}
