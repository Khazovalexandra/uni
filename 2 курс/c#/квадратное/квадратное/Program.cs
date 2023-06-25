using System;

namespace квадратное
{
    class yrav
    {
        double a, b, c;
        public yrav(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        double D(double a, double b, double c)
        {
            double d;
            d = (b * b - 4 * a * c);
            return d;
        }
        double first(double a, double b, double c)
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
        double second(double a, double b, double c)
        {
            double d;
            d = this.D(a,b,c);
            double x2 = 0;
            if (d>0)
            {
                x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);
            }
            return x2;
        }
        string print(double a, double b, double c)
        {
            return (a + "x^2 " + (b<0?"- "+b+"x":"+ "+b+"x") + (c<0?"- "+c:"+ "+c) + "=0");
        }
        bool proverka(double e)
        {
            double x1, x2;
            x1 = this.first(a,b,c);
            x2 = this.second(a,b,c);
            if ((Math.Abs(a * x1 * x1 + b * x1 + c) <= e) || (Math.Abs(a * x2 * x2 + b * x2 + c) <= e)) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            double a, b, c, e, d;
            Console.WriteLine("Введите коэффициенты уравнения: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точность уравнения: ");
            e = Convert.ToDouble(Console.ReadLine());
            yrav r = new yrav(a, b, c);
            Console.WriteLine("Уравнение: " + r.print(a, b, c));
            Console.WriteLine("Дискриминант: " + r.D(a, b, c));
            d = r.D(a, b, c);
            if (a!=0)
            {
                if (d > 0) Console.WriteLine("Корни квадратного уравнения: " + r.first(a, b, c) + " , " + r.second(a,b,c));
                else if (d == 0) Console.WriteLine("Корень квадратного урвнеия: " + r.first(a, b, c));
                else Console.WriteLine("Корней нет");
            }
            else Console.WriteLine("Корень линейного уравнения: " + r.first(a, b, c));
            Console.WriteLine("Точность: " + r.proverka(e));
            Console.ReadKey();
        }
    }
}
