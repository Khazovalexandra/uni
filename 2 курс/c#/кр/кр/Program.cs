using System;

namespace кр
{
    class Class20
    {
        public byte pu;
        protected double ps;
        protected byte pz;
        private string po;
        string o = "";
        public Class20(bool h, bool v, string c)
        {
            if ((h == true) && (v == true))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    ps = ps + 1;
                }
            }
            else ps = 0;
            return;
        }
        protected byte sv 
        {
            get
            {
                return pz;
            }
        }
        protected bool sh
        {
            get
            {
                return false;
            }
        }
        protected string sq
        {
            set 
            {
                this.po = po;
                this.o = o;
            }
        }
        public int si
        {
            set 
            {
                this.ps = ps;
                this.pz = pz;
            }
        }
        protected int mm(byte z)
        {
            if (ps == 0) pz = 0;
            else pz = Convert.ToByte(ps);
            return pz;
        }
        private bool mq(byte x)
        {
            mm(pz);
            if (pz == 0) return false;
            else return true;
        }
        public int mi(string o)
        {
            mm(pz);
            po = o;
            pu = Convert.ToByte(o.Length);
            if (pz == 0) return 0;
            else return pu;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool h, v;
            string c, o;
            Console.WriteLine("Введите значения переменных(true или false): ");
            h = Convert.ToBoolean(Console.ReadLine());
            v = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите предложение: ");
            c = Convert.ToString(Console.ReadLine());
            o = c;
            Class20 r = new Class20(h, v, c);
            Console.WriteLine("Ответ mi: " + r.mi(o));
            Console.ReadKey();
        }
    }
}
