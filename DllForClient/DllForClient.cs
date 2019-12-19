using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllForClient
{
    public static class DllForClient
    {
        public static double SquareTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
        public static double SquareCircle(double r)
        {
           return Math.PI * Math.Pow(r, 2);
        }

        public static double AnySquare()
        {
            Console.Write("Input count side(If your figure haven`t sides input 0): ");
            double countSide = Convert.ToDouble(Console.ReadLine());
            double s ,a, b, c, d;
            if (countSide == 3)
            {
                Console.Write("Input first side a:\t");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inout second side b:\t");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input third side c:\t");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Your figure is Triangle");
                double p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else if (countSide == 4)
            {
                Console.Write("Input first side a:\t");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inout second side b:\t");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input third side c:\t");
                c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input fourth side d:\t");
                d = Convert.ToDouble(Console.ReadLine());


                if (a == b && b == c && c == d)
                {
                    Console.WriteLine("Your figure is Square");
                    s = a * b;
                    return s;
                }
                else if (a == b && c == d)
                {
                    Console.WriteLine("Your figure is Rectangle");
                    s = a * b;
                    return s;
                }
                else return 0;

            }
            else if (countSide == 0)
            {
                Console.WriteLine("Your figure is Circle");
                Console.Write("Input radius r:\t");
                double r = Convert.ToDouble(Console.ReadLine());
                s =  Math.PI * Math.Pow(r, 2);
                return s;
            }
            else
                return 0;
        }
    }
}
