using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRSA
{
    public class RSA
    {
        public RSA() { }
        public void ValidInputData()
        {
            int p, q, e, gcd, n;
            int mess = 19;
            do
            {
                Console.WriteLine("Введите простое число p:");
                p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите простое число q:");
                q = Convert.ToInt32(Console.ReadLine());
            }
            while (mess % p == 0 || mess % q == 0 || p * q < mess);
            do
            {
                Console.WriteLine("Введите натуральное число e:");
                e = Convert.ToInt32(Console.ReadLine());
                gcd = GCD(e, (p - 1) * (q - 1));
            } while (e < 0 && e > p * q && gcd != 1);
            n = p * q;
            double resCrypt = Crypt(n, 3, mess, e);
            Console.WriteLine("Зашифрованый текст " + resCrypt);
            Decrypt(n, 3, resCrypt);
        }
        private double Crypt(int n, int key, int mess, int e)
        {
            double m;
            m = Math.Pow(mess, e) % n;
            return m;
        }
        private void Decrypt(int n, int key, double mess)
        {
            double res = Math.Pow(mess, key) % n;
            Console.WriteLine("Расшифрованый текст " + res);
        }
        private int GCD(int a, int b)
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
        private int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        private int Max(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
