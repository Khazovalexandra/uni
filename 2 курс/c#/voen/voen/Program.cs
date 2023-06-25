using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12
{
    class Voen
    {
        int k;
        public string name1, zvanie1, soobsh1;
        static Random rnd = new Random();
        int rnd1 = rnd.Next(0, 3);
        string[] name = { "Иванов И.И.", "Петров А.А.", "Самедов Н.Ю.", "Хазов С.Д.", "Кобяков А.Н.", "Поляков М.А.", "Камышев Д.С." };
        public string[] zvanie = { "генерал", "майор", "прапорщик", "рядовой", "старшина", "сержант", "капитан" };
        public string[] soobsh = { "построится", "собрание", "выход на пробежку", "отбой", "проверка", "задание от генерала", "пройти в пункт связи", "уборка помещения", "уборка территории", "осмотр" };
        public string pr { get; set; }
        public string ss { get; set; }
        public int zn1 { get; set; }
        public Voen(int k)
        {
            this.k = k;
            zn1 = rnd.Next(0, zvanie.Length);
            name1 = name[rnd.Next(0, name.Length)];
            zvanie1 = zvanie[zn1];
            soobsh1 = soobsh[rnd.Next(0, soobsh.Length)];
            if (rnd1 == 1)
            {
                pr = "*";
            }
        }
        public string print()
        {
            return (zvanie1 + " " + name1 + " " + soobsh1 + " " + pr);
        }
        public string print2()
        {
            return (zvanie1 + " " + name1 + " " + soobsh1);
        }
    }
    static class Punkt
    {
        static string S = "";
        static string pr, pricaz;
        static int e = 0, zn1 = 0;
        static string[] result = new string[2];
        public static string[] Write(Voen c)
        {
            pr = c.pr;
            pricaz = c.soobsh1;
            zn1 = c.zn1;
            
            int s = Convert.ToInt32(zn1);
            if (pr == "*") 
            { 
                e = s; 
                S = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = S; 
            }
            else if (S == "") 
            { 
                e = s; 
                S = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = S; 
            }
            else if (e < s) 
            { 
                e = s; 
                S = pricaz; 
                result[1] = "отдал приказ"; 
                result[0] = S; 
            }
            else if (e > s) 
            { 
                e = s; 
                result[1] = S; 
                S = ""; 
                result[0] = S; 
            }
            else if (e == s) 
            { 
                result[1] = pricaz; 
                result[0] = S; 
            }
            return result;
        }
        static int[] result1 = new int[10];
        public static int[] schet(Voen c)
        {
            zn1 = c.zn1;
            int s = Convert.ToInt32(zn1);
            result1[s] = result1[s] + 1;
            return result1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите количество военных: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Voen r = new Voen(k);
                string[] a = {};
                int q =0, y = 0;
                Random rnd = new Random();
                string[] vs = Punkt.Write(r);
                
                if (k > 0)
                {
                    Console.WriteLine("Военные до посещения пункта связи: ");
                    for (int j = 0; j <= k; j++)
                    {
                        Console.WriteLine(r.print());
                    }
                    Console.WriteLine("Военных после посещения пункта связи: ");
                    for(int i = 0; i<=k; i++)
                    {
                        string[] f = Punkt.Write(r);
                        if (r.pr == "*") Console.WriteLine(r.print2());
                        else Console.WriteLine(r.print());
                        Console.WriteLine("В пункте есть приказ: " + Punkt.Write(r));
                        a[i] = r.zvanie1;
                    }
                    for(int w = 0; w <= k; w++)
                    {
                        int g = Convert.ToInt32(Punkt.schet(r));
                        if (g != 0)
                        {
                            Console.WriteLine(Punkt.schet(r));
                            Console.WriteLine(" человек звания (" + r.zvanie1 + " ) прошло через пункт");
                        }
                    }
                    Console.WriteLine("история приказов:");
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Неверное кол-во");
                }
        }
    }
}

