using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Triangle : Shape
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

        public override double GetPerimeter()
        {
            return q + w + e;
        }

        public override double GetArea()
        {
            var area = Math.Sqrt((q + w + e) * (q + w - e) * (w + e - q) * (e + q - w)) / 4;
            return area;
        }
    }
}
