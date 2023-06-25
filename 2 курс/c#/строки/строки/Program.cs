чеusing System;

namespace строки
{    
    class Stroka
    {
        int k = 0,m,w;
        string str;
        char h;
        public Stroka(string str, char h)
        {
            this.str = str;
            this.h = h;
            this.w = w;
        }
        public double povtor(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (str[i] == h) k++;
            }
            return k;
        }
        public string del(string str, int w)
        {
            string a = "", b = "";
            a = str.Substring(w+1);
            int f = 0;
            string n = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                n += str[i];
            }
            f = str.Length - (w+1);
            b = n.Substring(f);
            string d = b + a;
            return d;
        }
        public double glas(string str)
        {
            char[] b = { 'а', 'е', 'и', 'о', 'ы', 'у', 'э','я','ю', 'А', 'Е', 'И', 'О', 'У', 'Э', 'Я', 'Ю' };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (str[i] == b[j]) m++;
                }
            }
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str, a;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            char s = ' ';
            Console.WriteLine("Введите букву поиска: ");
            char h = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите цифру разделения: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Stroka r = new Stroka(str, h);
            try
            {
                s = Convert.ToChar(h);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка, ввод некорректен!");
                Console.ReadKey();
                return;
            }
            int t = 0;
            try
            {
                t = Convert.ToInt32(w);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введённый разделитель имеет неверный формат!");
                Console.ReadKey();
                return;
            }
            if ((t >= str.Length) || (t <= 0))
            {
                Console.WriteLine("Введённый разделитель имеет неверный формат!");
                Console.ReadKey();
                return;
            } 
            Console.WriteLine("Количество повторений выбранного символа: " + r.povtor(str));
            Console.WriteLine("Реверсированные подстроки: " + r.del(str, w));
            Console.WriteLine("Количество гласных букв: " + r.glas(str));
        }
    }
}
