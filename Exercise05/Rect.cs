using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Rect : Shape
    {
        public int Width { set; get; }
        public int Height { set; get; }

        public Rect(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
