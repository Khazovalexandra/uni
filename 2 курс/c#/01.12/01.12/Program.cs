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
        bool preor;
        public string name1, zvanie1, soobsh1;
        private Random rnd;
        string[] name = { "Иванов И.И.", "Петров А.А.", "Самедов Н.Ю.", "Хазов С.Д.", "Кобяков А.Н.", "Поляков М.А.", "Камышев Д.С." };
        public string[] zvanie = { "генерал", "майор", "прапорщик", "рядовой", "старшина", "сержант", "капитан" };
        string[] soobsh = { "построится", "собрание", "выход на пробежку", "отбой", "проверка", "задание от генерала", "пройти в пункт связи", "уборка помещения", "уборка территории", "осмотр" };
        public string pr { get; set; }
        public string ss { get; set; }
        public int zn1 { get; set; }
        public Voen(int k)
        {
            this.k = k;
            int zn = new Random().Next(0, name.Length);
            zn1 = new Random().Next(0, zvanie.Length);
            int zn2 = new Random().Next(0, soobsh.Length);
            name1 = name[zn];
            zvanie1 = zvanie[zn1];
            soobsh1 = soobsh[zn2];
            if (rnd.Next(4) == 1)
            {
                pr = "*";
            }
        }
        public string print()
        {
            return (zvanie1 + " " + name1 + " " + soobsh1 + " " + pr);
        }
    }
    static class Punkt
    {
        private static string S;
        private static int n = 0;
        private static string[] Zvanie = { "генерал", "майор", "прапорщик", "рядовой", "старшина", "сержант", "капитан" };
        private static int[] K = new int[Zvanie.Length];
        public static void Write(Voen chel)
        {
            if (S != null)
            {
                if (chel.pr == "*")
                {
                    S = chel.ss;
                    chel.ss = "";
                }
                else
                {
                    if (chel.zn1 > n)
                    {
                        S = chel.ss;
                        chel.ss = "";
                    }
                    else if (chel.zn1 < n)
                    {
                        chel.ss = S;
                        S = "";
                    }
                }
            }
            else
            {
                S = chel.ss;
                chel.ss = "";
            }
            n = chel.zn1;
        }
        public static void Kolv(Voen chel)
        {

            for (int i = 0; i < Zvanie.Length; i++)
            {
                if (chel.zvanie1 == Zvanie[i])
                {
                    K[i] += 1;
                }
            }
        }
        public static int[] Print()
        {
            return K;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество военных: ");
            int k = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (k > 0)
                {
                    Voen r = new Voen(k);
                    Console.WriteLine();
                    int[] s = Punkt.Print();
                    for (int i = 0; i < s.Length; i++)
                    {
                        Console.WriteLine(r.zvanie[i] + s[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Неверное кол-во");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Неверный формат");
            }
            Console.ReadKey();
        }
    }
}
