using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRSA
{
    public class Gamal
    {
        public Gamal() { }
        public void ValidInputData()
        {
            int openKeyP, openKeyG, key, seanceKeyK, secretKeyX;
            Console.WriteLine("Введите номер символа для зашифровки (с): ");
            int mess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секретный ключ (X)");
            secretKeyX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый открытый ключ (P): ");
            openKeyP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый открытый ключ (G): ");
            openKeyG = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сеансовый ключ (k): ");
            seanceKeyK = Convert.ToInt32(Console.ReadLine());
            Crypt(openKeyG, openKeyP, seanceKeyK, secretKeyX, mess);

        }
        private void Crypt(int openKeyG, int openKeyP, int seanceKeyK, int secretKeyX, int mess)
        {
            double res, K, h, oSk;
            h = Math.Pow(openKeyG, secretKeyX) % openKeyP;
            K = Math.Pow(h, seanceKeyK) % openKeyP;
            res = (mess * K) % openKeyP;
            oSk = Math.Pow(openKeyG, seanceKeyK) % openKeyP;
            Console.WriteLine(res);
            Decrypte(openKeyG, openKeyP, secretKeyX, oSk, res);
        }
        private void Decrypte(int openKeyG, int openKeyP, int secretKeyX, double oSk, double mess)
        {
            double K,K1, res;
            K = Math.Pow(oSk, secretKeyX) % openKeyP;
            K1 = (1 / K) % openKeyP;
            res = mess * K1;
            Console.WriteLine(res);
        }
    }
}
