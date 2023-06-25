using System;

namespace справочник
{
    public class Person
    {
        public Imya imya = new Imya();
        public Adres adres = new Adres();
        public HomeAdres home = new HomeAdres();
        public struct Imya
        {
            public string name;
            public string surn;
            public string pat;
            public Imya(string dn, string ds, string bo)
            {
                name = dn;
                surn = ds;
                pat = bo;
            }
            public string Name()
            {
                return ("ФИО: " + name + surn + pat);
            }
        }
        public struct Adres
        {
            public string str;
            public string sity;
            public string street;
            public Adres(string strana, string g, string ul)
            {
                this.str = strana;
                this.sity = g;
                this.street = ul;
            }
            public string Name()
            {
                Random rnd = new Random();
                int d = rnd.Next(0, 100);
                int kv = rnd.Next(0, 100);
                return ("Рабочий адрес: " + str + ", г. " + sity + ", ул. " + street + ", офис " + d + ", кв." + kv);
            }
        }
        public string Phone()
        {
            Random ran = new Random();
            int tel1 = ran.Next(100, 999);
            int tel2 = ran.Next(100, 999);
            int tel3 = ran.Next(10, 99);
            int tel4 = ran.Next(10, 99);
            return ("Мобильный телефон: 8" + tel1 + tel2 + tel3 + tel4);
        }

        public struct HomeAdres
        {
            public string hstr;
            public string hsity;
            public string hstreet;
            public HomeAdres(string strana, string g, string ul)
            {
                hstr = strana;
                hsity = g;
                hstreet = ul;
            }
            public string Name()
            {
                Random rnd = new Random();
                int hd = rnd.Next(0, 100);
                int hkv = rnd.Next(0, 100);
                return ("Домашний адрес: " + hstr + ", г. " + hsity + ", ул. " + hstreet + ", дом " + hd + ", кв." + hkv);
            }
        }
        
    }
    public static class Generator
    {
        static Random rnd = new Random();
        static string[] n = { "Иванов", "Петров", "Сидоров", "Липов", "Торопов", "Усов", "Хазов", "Александров", "Мухин", "Юрасов" };
        static string[] s = { "Алексей", "Петр", "Иван", "Александр", "Сергей", "Егор", "Дмитрий", "Василий", "Олег", "Кирилл" };
        static string[] o = { "Алексеевич", "Петрович", "Иванович", "Александрович", "Сергеевич", "Дмитриевич", "Васильевич", "Андреевич", "Витальевич", "Николаевич" };
        static string[] strana = { "Россия" };
        static string[] g = { "Нижний Новгород", "Москва", "Санкт-Петербург", "Волгоград", "Казань", "Уфа", "Владимир", "Иркутск", "Екатеринбург", "Суздаль" };
        static string[] ul = { "Красная", "Липовая", "Тополевая", "Цветочная", "Пушкина", "Ленина", "Гоголя", "Пожарского", "Минина", "Максима Горького" };
        public static void Name(Person person)
        {
            person.imya.name = n[rnd.Next(0, n.Length)];
        }
        public static void Surname(Person person)
        {
            person.imya.surn = s[rnd.Next(0, s.Length)];
        }
        public static void Patronymic(Person person)
        {
            person.imya.pat = o[rnd.Next(0, o.Length)];
        }
        public static void Str(Person Adres)
        {
            Adres.adres.str = strana[rnd.Next(0, strana.Length)];
        }
        public static void Sity(Person Adres)
        {
            Adres.adres.sity = g[rnd.Next(0, g.Length)];
        }
        public static void Street(Person Adres)
        {
            Adres.adres.street = ul[rnd.Next(0, ul.Length)];
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person r = new Person();
                bool check = true;
                while (check == true)
                {
                    string im, t, ad;
                    string[] persona = new string[100];
                    int k1;
                    Console.WriteLine("Выбирите цифру: ");
                    Console.WriteLine("1.Ввод данных");
                    Console.WriteLine("2.Вывод данных");
                    Console.WriteLine("3.Выход");
                    int k = Convert.ToInt32(Console.ReadLine());
                    if ((k != 1) && (k != 2) && (k != 3)) Console.WriteLine("Нет такого пункта меню");
                    if (k == 1)
                    {
                        Console.WriteLine("1.Вручную");
                        Console.WriteLine("2.Сгенерировать данные");
                        k1 = Convert.ToInt32(Console.ReadLine());
                        if (k1 == 1)
                        {
                            Console.WriteLine("Укажите количество записей: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            if (z > 0)
                            {
                                for (int i = 0; i <= z; i++)
                                {
                                    Console.WriteLine("Ввод {0} человека", (i + 1));
                                    Console.WriteLine("Введите имя(Имя, Фамилию, Отчество): ");
                                    im = Console.ReadLine();
                                    Console.WriteLine("Введите телефон: ");
                                    t = Console.ReadLine();
                                    Console.WriteLine("Введите адрес: ");
                                    ad = Console.ReadLine();
                                    persona[i] = im + t + ad;
                                }
                                Console.WriteLine("Запись прошла успешно");
                                Console.WriteLine("Возврат к меню");
                            }
                            else Console.WriteLine("Нельзя ввести это значение");
                        }
                        else if (k1 == 2)
                        {
                            Console.WriteLine("Укажите количество записей: ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            if (z > 0)
                            {
                                for (int i = 0; i <= z; i++)
                                {
                                    r.imya.Name();
                                    r.adres.Name();
                                    r.Phone();
                                    r.home.Name();
                                }
                                Console.WriteLine("Запись прошла успешно");
                                Console.WriteLine("Возврат к меню");
                            }
                            else Console.WriteLine("Нельзя ввести это значение");
                        }
                    }
                    else if (k == 2)
                    {
                        Console.WriteLine("1.Вывести всю книгу данных");
                        Console.WriteLine("2.Поиск по параметру(имя, телефон, адрес)");
                        int k2 = Convert.ToInt32(Console.ReadLine());
                        if ((k2 == 1) && (k2 == 2)) Console.WriteLine("Нет такого пункта меню");
                        if (k2 == 1)
                        {
                            Console.WriteLine("Укажите количество записей которые необходимо вывести: ");
                            int z1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Справочник: ");
                            for (int i = 0; i <= z1; i++)
                            {
                                Console.WriteLine(persona[i]);
                            }
                        }
                        else if (k2 == 2)
                        {
                            Console.WriteLine("Введите параметр для поиска: ");
                            string parametr = Console.ReadLine();
                            Console.WriteLine("Укажите количество записей которые необходимо проверить: ");
                            int z1 = Convert.ToInt32(Console.ReadLine());
                            int sum = 0;
                            for (int i = 0; i <=z1; i++)
                            {
                                check = false;
                                int size = parametr.Length;
                                string info = r.imya.Name().ToLower();
                                string info1 = r.adres.Name().ToLower();
                                string info2 = r.Phone().ToLower();
                                string info3 = r.home.Name().ToLower();
                                for (int j = 0; j < info.Length - size; j++)
                                {
                                    if (info.Substring(j, size) == parametr.ToLower())
                                    {
                                        check = true;
                                        break;
                                    }
                                }
                                for (int j1 = 0; j1 < info1.Length - size; j1++)
                                {
                                    if (info.ToLower() == parametr.ToLower())
                                    {
                                        check = true;
                                        break;
                                    }
                                }
                                for (int j2 = 0; j2 < info2.Length - size; j2++)
                                {
                                    if (info.ToLower() == parametr.ToLower())
                                    {
                                        check = true;
                                        break;
                                    }
                                }
                                for (int j4 = 0; j4 < info.Length - size; j4++)
                                {
                                    if (info.ToLower() == parametr.ToLower())
                                    {
                                        check = true;
                                        break;
                                    }
                                }
                            }
                            if (check == true)
                            {
                                sum++;
                                Console.WriteLine("Информация: " + z1 + ": ");
                                Console.WriteLine(r.imya.Name());
                                Console.WriteLine(r.adres.Name());
                                Console.WriteLine(r.Phone());
                                Console.WriteLine(r.home.Name());
                            }
                            if (sum == 0) Console.WriteLine("Нет такой информации");
                        }
                    }    
                    
                    else if (k == 3) check = false;
                    else Console.WriteLine("Такого пункта нет");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение");
            }
             Console.ReadKey();
        }
    }
}

