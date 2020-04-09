using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLowFast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер: ");
            double[] a = Fill();
            Console.WriteLine("Введите сложность(K): ");
            int k = ConsoleInt();

            var time = DateTime.Now;
            FastWork(a, k);
            var dTime = DateTime.Now - time;
            Console.WriteLine(dTime);

            time = DateTime.Now;
            SlowWork(a, k);
            dTime = DateTime.Now - time;
            Console.WriteLine(dTime);

            Console.ReadKey();
        }
        static void Work(double[] a, double[] b, int k, int minIndex, int maxIndex)
        {
            for (int i = minIndex; i < maxIndex; i++)
            {
                for (int j = 0; j < k; j++)
                    b[i] += Math.Pow(a[i], 1.7);
            }

        }
        static void SlowWork(double[] a, int k)
        {
            double[] b = new double[a.Length];
            Work(a, b, k, 0, a.Length);
        }
        static void FastWork(double[] a, int k)
        {
            double[] b = new double[a.Length];
            Thread thread1, thread2;
            thread1 = new Thread(() => { Work(a, b, k, 0, a.Length / 3); });
            thread2 = new Thread(() => { Work(a, b, k, a.Length / 3, a.Length * 2 / 3); });
            thread1.Start();
            thread2.Start();
            Work(a, b, k, a.Length * 2 / 3, a.Length);
            thread1.Join();
            thread2.Join();

        }
        static int ConsoleInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value)) ;
            return value;
        }
        static double[] Fill()
        {
            int size = ConsoleInt();
            double[] a = new double[size];
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < size; i++)
            {
                a[i] = random.NextDouble();
            }
            return a;
        }
    }
}
