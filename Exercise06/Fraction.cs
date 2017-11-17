using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Fraction
    {
        public int A { set; get; }
        public int B { set; get; }

        public Fraction(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
        
        public void Minimal()
        {
            var gcd = GreatestCommonDivisor(A, B);
            A = A / gcd;
            B = B / gcd;
        }

        public override string ToString()
        {
            return A + "/" + B;
        }

        public static Fraction operator +(Fraction q, Fraction w)
        {
            var e = new Fraction(q.A * w.B + q.B * w.A, q.B * w.B);
            e.Minimal();
            return e;
        }

        public static Fraction operator -(Fraction q, Fraction w)
        {
            var e = new Fraction(q.A * w.B - q.B * w.A, q.B * w.B);
            e.Minimal();
            return e;
        }

        public static Fraction operator *(Fraction q, Fraction w)
        {
            var e = new Fraction(q.A * w.A, q.B * w.B);
            e.Minimal();
            return e;
        }

        public static Fraction operator /(Fraction q, Fraction w)
        {
            var e = new Fraction(q.A * w.B, q.B * w.A);
            e.Minimal();
            return e;
        }

        public static bool operator !=(Fraction q, Fraction w)
        {
            q.Minimal();
            w.Minimal();
            return (q.A != w.A || q.B != w.B);
        }

        public static bool operator ==(Fraction q, Fraction w)
        {
            return !(q!=w);
        }

        public static bool operator >=(Fraction q, Fraction w)
        {
            return (q.A * w.B >= q.B * w.A);
        }

        public static bool operator >(Fraction q, Fraction w)
        {
            return (q.A * w.B > q.B * w.A);
        }

        public static bool operator <=(Fraction q, Fraction w)
        {
            return (q.A * w.B <= q.B * w.A);
        }

        public static bool operator <(Fraction q, Fraction w)
        {
            return (q.A * w.B < q.B * w.A);
        }

        public static Fraction operator !(Fraction q)
        {
            return new Fraction(q.B, q.A);
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
