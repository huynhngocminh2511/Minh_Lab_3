using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Circle : Shape
    {
        public int Radius { set; get; }

        public Circle(int Radius)
        {
            this.Radius = Radius;
        }

        public override double GetPerimeter() => 2 * Radius * Math.PI;

        public override double GetArea() => Radius * Radius * Math.PI;
    }
}
