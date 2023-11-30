using System;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using System.Diagnostics;

namespace PI
{
    class Program
    {
        static CountdownEvent countdownEvent;
        static double pi = 0;
        static void ThreadFunc(object iThread) //для Task void->object
        {
            object locker = new object();
            double x = 0, Fx = 0, s = 0;
            int left = (int)(((object[])iThread)[0]);
            int right = (int)(((object[])iThread)[1]);
            int interval_ = (int)(((object[])iThread)[2]);
            Console.WriteLine("левая=" + left + " правая=" + right + " интервал=" + interval_);
            double interval = 1 / (double)interval_;
            for (double i = left; i <= right; i++)
            {
                x = interval * (i - 0.5);
                Fx = 4 / (1 + x * x);
                s = s + Fx;
            }
            Console.WriteLine("ls=" + s + " поток:" + Thread.CurrentThread.ManagedThreadId);
            lock (locker)
            {
                pi += s;
            }
            countdownEvent.Signal();
            //return s;
        }
        static double one_potok(object writer)
        {
            double res = 0, x = 0, Fx = 0, s = 0;
            double wr = (double) writer;
            double interval = 1 / wr;
            for (double i = 1; i <= wr; i++)
            {
                x = interval * (i - 0.5);
                Fx = 4 / (1 + x * x);
                s = s + Fx;
            }
            res = interval * s;
            return res;
        }
        static void Main(string[] args)
        {
            int x = Environment.ProcessorCount; //количество ядер
            Console.Write("Введите число прямоугольников для нахождения числа п: ");
            int writer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Точное число п = " + Math.PI);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Parallel.ForEach<double>(new List<double>() {Convert.ToDouble(writer)}, one_potok);
            Task<double> tsk = Task<double>.Factory.StartNew(one_potok, Convert.ToDouble(writer));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("_____________________________");
            Console.WriteLine("Число п = " + tsk.Result);
            Console.WriteLine("Время однопоточного = " + + stopWatch.ElapsedMilliseconds + '('+ts+')');
            Console.WriteLine("_____________________________");
            tsk.Dispose();
            int step = writer / x;
            object[] arr = new object[3];
            countdownEvent = new CountdownEvent(x);
            for (int i = 0; i < x; i++)
            {
                if (i == x - 1)
                {
                    arr[0] = (step * i) + 1;
                    arr[1] = writer;
                }
                else
                {
                    arr[0] = (step * i) + 1;
                    arr[1] = step * (i + 1);
                }
                arr[2] = writer;
                stopWatch.Restart();
                Parallel.ForEach<object>(new List<object>() { arr }, ThreadFunc);
                //ThreadPool.QueueUserWorkItem(ThreadFunc, Copy(arr));   
            }
                //Task[] tsks1 = new Task[x];
                /*for (int j = 0; j<tsks1.Length; j++) 
                {
                    tsks1[j] = Task.Factory.StartNew(ThreadFunc, Copy(arr));
                    //Console.WriteLine("ls=" + tsks1[j].Result + " поток:" + Thread.CurrentThread.ManagedThreadId);
                }*/
                //Task<object> tsk1 = Task<object>.Factory.StartNew();
            countdownEvent.Wait();
            double interval = 1.0 / Convert.ToDouble(writer);
            pi = pi * interval;
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            Console.WriteLine("_____________________________");
            Console.WriteLine("Время многопоточного = " + stopWatch.ElapsedMilliseconds + '('+ts1+')');
            Console.WriteLine("Число п = " + pi);
            Console.ReadKey();
        }
    }
}