using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class IOF
    {
        public static void Input(string path)
        {
            if(!File.Exists(path))
            {
                throw new Exception();
            }
            
        }
        public static string Out(string path)
        {           
            StreamReader sr = new StreamReader(path, Encoding.Default);
            StreamWriter sw = new StreamWriter("CardsCopy.txt", false, Encoding.Default);
            int str = 5, j = 0;
            string[] cardNumber = new string[str];
            cardtype a = cardtype.INVALID;

            while ((cardNumber[j] = sr.ReadLine()) != null)
            {
                sw.WriteLine(cardNumber[j] + " " + Validation.Cardtype(cardNumber[j], a));
            }
            sr.Close();
            sw.Close();
            return path;
        }

    }
}
