using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics;

namespace TreadsFactorial{
    class Program
    {
        static BigInteger fact = 1;
        static void Factorial(object f)
        {
            Thread t = Thread.CurrentThread;
            BigInteger res0 = 1;
            int n0 = (int)(((object[])f)[0]);
            int n = (int)(((object[])f)[1]);
            do
            {
                res0 = res0 * n;
            } while (--n > n0);
            fact*=res0;
            ThreadLocal<string> ThreadName = new ThreadLocal<string>(() =>
            {
                return "Поток " + t.ManagedThreadId + " результат: " + res0;
            });
            Console.WriteLine(ThreadName.Value);
        }

        static void Main()
        {
            int n_one = 10, n = 10, n0_one = 1, n0 = 1;
            BigInteger res_one=1;
            var ja = Environment.ProcessorCount;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            do
            {
                res_one = res_one * n_one;
            } while (--n_one > n0_one);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts.Hours, ts.Minutes, ts.Seconds,
                                                ts.Milliseconds);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Время однопоточного = " + + stopWatch.ElapsedMilliseconds + '('+elapsedTime+')');
            Console.WriteLine("Факториал = " + res_one);
            Console.WriteLine("_____________________________");
            Thread[] thrd = new Thread[ja];
            int[] arr = new int[ja+1]; 
            int c = n / ja; //количество отрезков на которые делить данные
            //Console.WriteLine(ja);
            for(int j = 0; j < arr.Length; j++)
            {
                arr[j] = n0;
                n0 += c;
            }
            arr[ja] = n;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine(" ");
            stopWatch.Start();
            for (int i = 0; i < thrd.Length; i++)
            {
                thrd[i] = new Thread(Factorial);
                thrd[i].Start(new object[]{arr[i], arr[i+1]});
                //thrd[i].Join();
            }
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts1.Hours, ts1.Minutes, ts1.Seconds,
                                                ts1.Milliseconds);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Время многопоточного = " + stopWatch.ElapsedMilliseconds + '('+elapsedTime1+')');
            Console.WriteLine("_____________________________");
            Console.WriteLine("Факториал равен ");
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}