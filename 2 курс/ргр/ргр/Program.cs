using System;

namespace Work
{
    class log2
    {
        private bool x1, x2, x3;
        public log2(bool x1, bool x2, bool x3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
        }
        public bool y1()
        {
                return !(x1 && x2);
        }
        public bool y2()
        {
                return x2 && x3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнила студентка 2 курса группы ИС-29");
            Console.WriteLine("Хазова Александра Сергеевна");
            Console.WriteLine("Вариант 20");
            Console.WriteLine("Текст задания:");
            Console.WriteLine("Напишите класс log2, описывающий логическую схему");
            Console.WriteLine("с тремя входами и двумя выходами");
            Console.WriteLine("    х1_______1|----|");
            Console.WriteLine("    x2________|&   |o___Y1");
            Console.WriteLine("         |    |____|");
            Console.WriteLine("         |");                    //логическа схема
            Console.WriteLine("         |___2|----|");
            Console.WriteLine("    x3________|&   |____Y2");
            Console.WriteLine("              |____|");
            Console.WriteLine("Входные сигналы: ");
            try
            { 
                bool x1 = Convert.ToBoolean(Console.ReadLine());
                bool x2 = Convert.ToBoolean(Console.ReadLine());    //вводим только true или false
                bool x3 = Convert.ToBoolean(Console.ReadLine());
                log2 r = new log2(x1, x2, x3);                      //вызываем класс log2
                Console.WriteLine("Выходные сигналы: ");
                Console.WriteLine("у1 = " + r.y1());      //выводим значения выходов
                Console.WriteLine("у2 = " + r.y2());
            }
            catch
            {
                Console.WriteLine("Введено неверно");
            }
            Console.ReadKey();
        }
    }
}

