using System;

namespace массив
{
    class Massiv
    {
        int x = 0, y = 0, vs;
        double[,] a;
        public double[,] c = new double[1, 100];
        double[,] l, m, o;
        public double[,] b = new double[1, 100];
        public Massiv(double[,] a, int x, int y, int vs)
        {
            this.vs = vs;
            this.a = a;
            this.x = x;
            this.y = y;
        }
        public string vvod(double[,] a)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Random rnd = new Random();
                    a[i, j] = rnd.Next(0, 11);
                }
            }
            Console.Write("{");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
            }
            return ("");
        }
        public double[,] v1(double[,] a, int vs)
        { 
            vs -= 1;
            for (int i = 0; i < x; i++)
            {
                b[0, i] = a[i, vs];
            }
            return b;
        }
        public double[,] v2()
        {
            double k, s = 0;
            for (int i = 0; i < y; i++)
            {
                k = 0;
                for (int j = 0; j < x; j++)
                {
                    s = a[i, j] * b[0, j];
                    k = k + s;
                }
                c[0, i] = k;
            }
            return c;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int x = 0, y = 0, vs = 0;
                try
                {
                    Console.WriteLine("Введите количесиво столбцов массива: ");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Некоректно"); 
                }
                try
                {
                    Console.WriteLine("Введите количесиво строчек массива: ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некоректно");
                }
                
                try
                {
                    Console.WriteLine("Выбранный столбец массива: ");
                    vs = Convert.ToInt32(Console.ReadLine());    
                }
                catch
                {
                    Console.WriteLine("В массиве нет накого столбца");
                }
                double[,] a = new double[x, y];
                Massiv r = new Massiv(a, x, y, vs);
                Console.WriteLine("Введеный массив: ");
                Console.WriteLine(r.vvod(a) + "}");
                Console.WriteLine("Полученный вектор: ");
                Console.Write("{");
                var v = r.v1(a, vs);
                var t = r.v2();
                for (int i = 0; i < x; i++)
                {            
                     Console.WriteLine(v[0,i]);
                }
                Console.WriteLine("}");
                Console.WriteLine("Массив перемноженный на вектор: ");
                Console.Write("{");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(t[0, i]);
                }
                Console.WriteLine("}");
                Console.ReadKey();
            }
        }
}
