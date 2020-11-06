using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, key, e, gcd, n;

            Console.WriteLine("Введите текст для зашифровки:");
            string message = Console.ReadLine();
            byte[] mess = Encoding.ASCII.GetBytes(message);
            do
            {
                int i = 0;
                Console.WriteLine("Введите простое число p:");
                p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите простое число q:");
                q = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            while (Convert.ToInt32(mess[0]) % p != 0 && Convert.ToInt32(mess[0]) % q != 0 && p * q > Convert.ToInt32(mess[0]));
            do
            {
                Console.WriteLine("Введите натуральное число e:");
                e = Convert.ToInt32(Console.ReadLine());
                gcd = GCD(e, (p - 1) * (q - 1));
            } while (e < 0 && e > p * q && gcd != 1);
            n = p * q;
            double resCrypt = Crypt(n, 's', mess);
            Console.WriteLine("Зашифрованый текст " + resCrypt);
            Decrypt(n, 's', resCrypt);
        }
        public static double Crypt(int n, int key, byte[] mess)
        {
            int e = 0;
            double m = 0;
            for (int i = 0; i < mess.Length; i++)
            {
                m = Math.Pow(mess[i], e) % n;
                return m;
            }
            return m;
        }
        public static void Decrypt(int n, int key,  double mess)
        {
            double res = Math.Pow(mess, key) % n;
            Console.WriteLine("Расшифрованый текст " + res);
        }
        public static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                var min = Min(a, b);
                var max = Max(a, b);
                return GCD(max - min, min);
            }
        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        static int Max(int x, int y)
        {
            return x > y ? x : y;
        }

    }
}
