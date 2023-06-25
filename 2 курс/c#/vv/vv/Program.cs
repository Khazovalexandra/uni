using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vv
{
    public class Voen
    {
        string im, pr, zv; bool p; int n;
        string[] name = { "Иванов И.И.", "Петров А.А.", "Самедов Н.Ю.", "Хазов С.Д.", "Кобяков А.Н.", "Поляков М.А.", "Камышев Д.С." };
        public string[] zvanie = { "рядовой", "сержант",  "старшина", "прапорщик", "капитан",  "майор", "генерал" };
        public string[] soobsh = { "построится", "собрание", "выход на пробежку", "отбой", "проверка", "задание от генерала", "пройти в пункт связи", "уборка помещения", "уборка территории", "осмотр" };
        static Random rnd = new Random();
        public Voen(bool prioritet = false)
        {
            n = rnd.Next(0, name.Length);
            zv = zvanie[n];
            im = name[rnd.Next(0, name.Length)];
            pr = soobsh[rnd.Next(0, soobsh.Length)];
            p = prioritet;
        }
        public string[] print()
        {
            string[] r = new string[5];
            r[0] = "" + n;
            r[1] = zv;
            r[2] = im;
            r[3] = pr;
            if (p == false) 
            { 
                return (r); 
            }
            else
            {
                r[4] = "" + p;
                return (r);
            }
        }
    }
    static class Punkt
    {
        static string pr1 = "0";
        static int e = 0;
        public static string[] Write(string zvanie, string pricaz, string n, string prioritet)
        {
            string[] result = new string[2];
            int s = Convert.ToInt32(n);
            if (prioritet == "true") 
            { 
                e = s; 
                pr1 = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = pr1; 
            }
            else if (pr1 == "0") 
            { 
                e = s; 
                pr1 = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = pr1; 
            }
            else if (e < s) 
            { 
                e = s; 
                pr1 = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = pr1; 
            }
            else if (e > s) 
            { 
                e = s;
                result[1] = pr1;
                pr1 = "пусто";
                result[0] = pr1;
            }
            else if (e == s) 
            { 
                result[1] = pricaz; 
                result[0] = pr1; 
            }
            return result;
        }
        public static int[] schet(string n, int[] a)
        {
            int[] result = a;
            int s = Convert.ToInt32(n);
            result[s] = result[s] + 1;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Voen> list = new List<Voen>();
            Console.WriteLine("Количество военных: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string[] d = new string[k];
            Random r = new Random();
            for (int i = 1; i < k + 1; i++)
            {
                int p = r.Next(0, 2);
                if (p == 1) 
                { 
                    Voen user = new Voen(true); list.Add(user); 
                }
                else 
                { 
                    Voen user = new Voen(); list.Add(user); 
                }
            }
            Console.WriteLine("Список военных до посещения пункта связи: ");
            int q = 0;
            foreach (Voen w in list)
            {
                q++;
                string[] f = w.print();
                for (int i = 0; i < f.Length; i++)
                {
                    Console.Write(f[i] + " ");
                }
                Console.WriteLine("Военный №" + q);
            }
            Console.WriteLine("Cписок военных после посещения пункта связи: ");
            int j = 0;
            foreach (Voen w in list)
            {
                q++;
                string[] f = w.print();
                string[] spisok = Punkt.Write(f[1], f[3], f[0], f[4]);
                for (int i = 0; i < f.Length; i++)
                {
                    if (i == 3) 
                    { 
                        Console.Write(spisok[1] + " "); 
                    }
                    else 
                    { 
                        Console.Write(f[i] + " "); 
                    }
                }
                Console.WriteLine("В пункте сейчас имеется приказ: " + spisok[0]);
                d[j] = spisok[0];
                j = j + 1;
            }
            int[] f2 = new int[10];
            string[] z = new string[10];
            foreach (Voen w in list)
            {
                q++;
                string[] f = w.print();
                f2 = Punkt.schet(f[0], f2);
                int y = Convert.ToInt32(f[0]);
                z[y] = f[1];
            }
            Console.WriteLine("Военные, прошедшие через пункт: ");
            for (int i = 0; i < f2.Length; i++)
            {
                int g = Convert.ToInt32(f2[i]);
                if (g != 0) 
                { 
                    Console.WriteLine(f2[i] + " человек звания " + z[i] + " прошло через пункт"); 
                }
            }
            Console.WriteLine("История приказов:");
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == "пусто")
                    break;
                else Console.WriteLine(d[i]);
            }
            Console.ReadKey();
        }
    }
}

