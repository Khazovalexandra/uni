using System;

namespace перевод_из_10_в_2_и_наоборот
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            string x = Console.ReadLine();
            int t = Convert.ToInt32(x);
            string y = "";
            double q = 0;
            double i = 0;
            int x1 = Convert.ToInt32(x);
            if ((x1%10==0) || (x1%10==1))
            {
                int n = Convert.ToInt32(x, 2);
                Console.WriteLine("Из 2й в 10ю: " + n);
                while (x1 > 0)
                {
                    double c = Math.Pow(2, i);
                    q += c*(x1 % 10);
                    i += 1;
                    x1 /= 10;
                }
                Console.WriteLine("Десятичное число: " + q);
            }
            else 
            { 
                string s = Convert.ToString(t, 2);
                Console.WriteLine("Из 10й в двоичную: " + s);
                while (x1 > 0)
                {
                    q = x1 % 2;
                    x1 /= 2;
                    y += q;
                }
                string reverse = string.Empty;
                for (int k = y.Length - 1; k > -1; k--)
                    reverse += y[k];
                Console.WriteLine("Двоичное число: " + reverse);
            }
            Console.ReadKey();
        } 
    } 
 }
