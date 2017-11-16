using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var fra = new Fraction(4, 6);
            Console.WriteLine(fra.ToString());
            fra.Minimal();
            Console.WriteLine("Minimal: " + fra.ToString());
            var fra1 = new Fraction(2, 3);
            var fra2 = new Fraction(2, 4);
            fra = fra1 + fra2;
            Console.WriteLine("2/3 + 2/4: " + fra.ToString());
            fra = fra1 - fra2;
            Console.WriteLine("2/3 - 2/4: " + fra.ToString());
            fra = fra1 * fra2;
            Console.WriteLine("2/3 * 2/4: " + fra.ToString());
            fra = fra1 / fra2;
            Console.WriteLine("2/3 / 2/4: " + fra.ToString());
            fra = !fra2;
            Console.WriteLine("!2/4: " + fra.ToString());
            fra1 = new Fraction(2, 3);
            fra2 = new Fraction(2, 4);
            Console.WriteLine("2/3 compare 2/4");
            if (fra1 >= fra2) 
            {
                Console.WriteLine(">=");
            }
            if (fra1 > fra2)
            {
                Console.WriteLine(">");
            }
            if (fra1 <= fra2)
            {
                Console.WriteLine("<=");
            }
            if (fra1 < fra2)
            {
                Console.WriteLine("<");
            }
            fra1 = new Fraction(2, 3);
            fra2 = new Fraction(2, 3);
            Console.WriteLine("2/3 compare 2/3");
            if (fra1 >= fra2)
            {
                Console.WriteLine(">=");
            }
            if (fra1 > fra2)
            {
                Console.WriteLine(">");
            }
            if (fra1 <= fra2)
            {
                Console.WriteLine("<=");
            }
            if (fra1 < fra2)
            {
                Console.WriteLine("<");
            }
            fra1 = new Fraction(2, 4);
            fra2 = new Fraction(2, 3);
            Console.WriteLine("2/4 compare 2/3");
            if (fra1 >= fra2)
            {
                Console.WriteLine(">=");
            }
            if (fra1 > fra2)
            {
                Console.WriteLine(">");
            }
            if (fra1 <= fra2)
            {
                Console.WriteLine("<=");
            }
            if (fra1 < fra2)
            {
                Console.WriteLine("<");
            }
            Console.ReadKey();
        }
    }
}
