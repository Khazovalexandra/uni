using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уравнение
{
    class Yrav
    {
        double a, b, c;
        public Yrav(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double D(double a, double b, double c)
        {
            double d;
            d = (b * b - 4 * a * c);
            return d;
        }
        public double first(double a, double b, double c)
        {
            double d;
            double x1 = 0;
            d = this.D(a, b, c);
            if (a != 0)
            {
                if (d > 0)
                {
                    x1 = ((-b) + (Math.Sqrt(d))) / (2 * a);
                }
                if (d == 0)
                {
                    x1 = (-b) / 2 * a;
                }
            }
            else x1 = (-c) / b;
            return x1;
        }
        public double second(double a, double b, double c)
        {
            double d;
            d = this.D(a, b, c);
            double x2 = 0;
            if (d > 0)
            {
                x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);
            }
            return x2;
        }
    }
}
