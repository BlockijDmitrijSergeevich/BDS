using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRSA
{
    public class Rabin
    {
        public Rabin() { }
        public  void ValidInputData()
        {
            int p, q, n, b;
            Console.WriteLine("Введите номер символа для зашифровки (c): ");
            int mess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите q: ");
            q = Convert.ToInt32(Console.ReadLine());

            n = p * q;
            do
            {
                Console.WriteLine("Введите второй ключ (b): ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < 0 && b >= n);

            double resMess = Crypt(mess, b, n);
            Console.WriteLine("Зашифрованое сообщение: "+resMess);
        }
        private  double Crypt(int mess, int b, int n)
        {
            double res;
            res = mess * (mess + b) % n;
            return res;
        }
        private  void Decrypt()
        {

        }
    }
}
