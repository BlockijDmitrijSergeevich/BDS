using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class IOC
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }
        public static int GetInteger(string message = "")
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int LanguageMenu(List<string> languages)
        {
            Console.WriteLine(string.Format("{0}:", Properties.Resource.Resource.SelectLanguage));
            var i = 0;
            foreach (var language in languages)
            {
                Console.WriteLine(string.Format("{0}: {1}", ++i, language));
            }
            return GetInteger(Properties.Resource.Resource.Choice) - 1;
        }
        public static int Answer()
        {
            int i;
            i = int.Parse(Console.ReadLine());
            return i;
        }
        public static void writeMessage(string val)
        {
            Console.WriteLine($"{val}");             
        }
        public static string CheckFileName()
        {            
            Console.Write("Введите путь к файлу: ");
            return Console.ReadLine();            
        }

        public static string Menu(int numberMessage)
        {
            if (numberMessage == 0)
            {
                string message = "Меню:\n1) Определить валидность карт в файле \n2) Ввести карту самому \n3) Выйти из программы\n\nВаше решение: ";
                return message;
            }
            if (numberMessage == 1)
            {
                string message = "Good";
                return message;
            }
            if (numberMessage == 2)
            {
                string message = "Error";
                return message;
            }
            if (numberMessage == 3)
            {
                string message = "Вы решили выйти";
                return message;
            }
            if (numberMessage == 4)
            {
                string message = "Вы что-то другое нажали...";
                return message;
            }
            if (numberMessage == 5)
            {
                string message = "\n\n\t\t\tНажмите любую клавишу...";
                return message;
            }
            return null;
        }

        public static cardtype ConsolOut()
        {
            Console.WriteLine("Введите номер карты: ");
            cardtype a = cardtype.INVALID;
            int str = 1, j = 0;
            string[] cardNumber = new string[str];
            cardNumber[j] = Console.ReadLine();
            if (Validation.IsValidLength(cardNumber, j) && Validation.IsNumber(cardNumber[j]) && Validation.ValidInvalid(cardNumber[j]))
            {
                switch (Validation.Cardtype(cardNumber[j], a))
                {
                    case cardtype.AMEX:
                        Console.WriteLine("AMEX");
                        break;                        
                    case cardtype.VISA:
                        Console.WriteLine("VISA");
                        break;                        
                    case cardtype.MASTER:
                        Console.WriteLine("MASTER");
                        break;                        
                }
            }
            else
            {
                Console.WriteLine("INVALID");               
            }
            return 0;
        }
    }
}
