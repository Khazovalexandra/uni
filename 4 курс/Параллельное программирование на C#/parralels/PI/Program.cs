using System;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using System.Diagnostics;

namespace PI
{
    class Program
    {
        //static ThreadLocal<double> localSum = new ThreadLocal<double>(() => 1, true);
        static CountdownEvent countdownEvent;
        static double pi = 0;
        static Array Copy(Array arr)
        {
            object[] copy = new object[arr.Length];
            arr.CopyTo(copy, 0);
            return copy;
        }

        static void ThreadFunc(object iThread)
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
        }
        static double one_potok(double writer)
        {
            double res = 0, x = 0, Fx = 0, s = 0;
            double interval = 1 / writer;
            for (double i = 1; i <= writer; i++)
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
            //Thread[] t = new Thread[x];
            Console.Write("Введите число прямоугольников для нахождения числа п: ");
            int writer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Точное число п = " + Math.PI);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double res_one = one_potok(writer);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts.Hours, ts.Minutes, ts.Seconds,
                                                ts.Milliseconds / 10);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Время однопоточного = " + + stopWatch.ElapsedMilliseconds + '('+elapsedTime+')');
            Console.WriteLine("Число п = " + res_one);
            Console.WriteLine("_____________________________");

            int step = writer / x;
            object[] arr = new object[3];
            stopWatch.Restart();
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
                //Console.WriteLine("левая=" + arr[0] + " правая=" + arr[1] + " интервал=" + arr[2]);
                ThreadPool.QueueUserWorkItem(ThreadFunc, Copy(arr));
            }
            countdownEvent.Wait();
            
            double interval = 1.0 / Convert.ToDouble(writer);
            pi = pi * interval;
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts1.Hours, ts1.Minutes, ts1.Seconds,
                                                ts1.Milliseconds);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Время многопоточного = " + stopWatch.ElapsedMilliseconds + '('+elapsedTime1+')');
            Console.WriteLine("Число п = " + pi);
            Console.ReadKey();
        }
    }
}