using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Fraction
    {
        public int a { set; get; }
        public int b { set; get; }

        public Fraction(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public void Minimal()
        {
            var gcd = GreatestCommonDivisor(a, b);
            a = a / gcd;
            b = b / gcd;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Fraction operator +(Fraction q, Fraction w)
        {
            var e = new Fraction(q.a * w.b + q.b * w.a, q.b * w.b);
            e.Minimal();
            return e;
        }

        public static Fraction operator -(Fraction q, Fraction w)
        {
            var e = new Fraction(q.a * w.b - q.b * w.a, q.b * w.b);
            e.Minimal();
            return e;
        }

        public static Fraction operator *(Fraction q, Fraction w)
        {
            var e = new Fraction(q.a * w.a, q.b * w.b);
            e.Minimal();
            return e;
        }

        public static Fraction operator /(Fraction q, Fraction w)
        {
            var e = new Fraction(q.a * w.b, q.b * w.a);
            e.Minimal();
            return e;
        }

        public static bool operator !=(Fraction q, Fraction w)
        {
            q.Minimal();
            w.Minimal();
            return (q.a != w.a || q.b != w.b);
        }

        public static bool operator ==(Fraction q, Fraction w)
        {
            return !(q!=w);
        }

        public static bool operator >=(Fraction q, Fraction w)
        {
            return (q.a * w.b >= q.b * w.a);
        }

        public static bool operator >(Fraction q, Fraction w)
        {
            return (q.a * w.b > q.b * w.a);
        }

        public static bool operator <=(Fraction q, Fraction w)
        {
            return (q.a * w.b <= q.b * w.a);
        }

        public static bool operator <(Fraction q, Fraction w)
        {
            return (q.a * w.b < q.b * w.a);
        }

        public static Fraction operator !(Fraction q)
        {
            return new Fraction(q.b, q.a);
        }

        public int GreatestCommonDivisor(int q, int w)
        {
            while (q * w != 0) 
            {
                if (q > w)
                {
                    q = q % w;
                } else
                {
                    w = w % q;
                }
            }
            return q + w;
        }
    }
}
