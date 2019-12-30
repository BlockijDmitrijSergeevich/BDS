using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class Validation
    {
        public static bool ValidInvalid(string cardNumber)
        {
            int check = 0;
            int sum = 0;
            for (int i = 1; i < cardNumber.Length; i = i + 2)
            {
                check = (Convert.ToInt32(cardNumber[i]) - 48) * 2;
                if (check > 10)
                {
                    check = (check % 10) + (check / 10);
                }
                sum = sum + check;
                check = (Convert.ToInt32(cardNumber[i - 1]) - 48);
                sum = sum + check;

            }
            if ((cardNumber.Length) % 2 != 0)
            {
                sum = sum + (Convert.ToInt32(cardNumber[cardNumber.Length - 1]) - 48);
            }
            if (sum % 10 == 0)
                return true;
            return false;

        }



        public static bool IsNumber(string cardNumber)
        {
            if ((cardNumber[0] == '4') || (cardNumber[0] == '3' && (cardNumber[1] == '4' || cardNumber[1] == '7')) || (cardNumber[0] == '5' && (cardNumber[1] == '1' || cardNumber[1] == '2' || cardNumber[1] == '3' || cardNumber[1] == '4' || cardNumber[1] == '5')))
                return true;
            return false;
        }
        public static cardtype Cardtype(string cardNumber, cardtype a)
        {
            if (cardNumber[0] == '4')
            {
                a = cardtype.VISA;
                return a;
            }
            if (cardNumber[0] == '3' && (cardNumber[1] == '4' || cardNumber[1] == '7'))
            {
                a = cardtype.AMEX;
                return a;
            }
            if (cardNumber[0] == '5' && (cardNumber[1] == '1' || cardNumber[1] == '2' || cardNumber[1] == '3' || cardNumber[1] == '4' || cardNumber[1] == '5'))
            {
                a = cardtype.MASTER;
                return a;
            }
            return a;
        }

        public static bool IsValidLength(string[] cardNumber, int j)
        {
            if (cardNumber[j].Length == 13 || cardNumber[j].Length == 15 || cardNumber[j].Length == 16)
                return true;
            return false;
        }
    }
}
