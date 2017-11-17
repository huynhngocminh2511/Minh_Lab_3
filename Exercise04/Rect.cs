using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Rect
    {
        public int Width { set; get; }
        public int Height { set; get; }

        public Rect(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public int GetPerimeter()
        {
            return (Width + Height) * 2;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }
}
