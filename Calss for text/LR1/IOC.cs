using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class IOC
    {
        public static void WriteMessage(string val)
        {
            Console.WriteLine($"{val}");
        }
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }

        public static int Answer()
        {
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        internal static int GetInteger(string message = "")
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static string GetString(string message = "")
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        internal static int LanguageMenu(List<string> languages)
        {
            Console.WriteLine(string.Format("{0}:", Properties.Resource.SelectLanguage));
            var i = 0;
            foreach (var language in languages)
            {
                Console.WriteLine(string.Format("{0}: {1}", ++i, language));
            }
            return GetInteger(Properties.Resource.Choice) - 1;
        }

        public static string Menu(int numberMessage)
        {
            if (numberMessage == 0)
            {

                string menuMessage = "Меню:\n1 - Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них." +
                        "\n2 - Во всех вопросительных предложениях текста найти и напечатать без повторений слова заданной длины." +
                        "\n3 - Из текста удалить все слова заданной длины, начинающиеся на согласную букву." +
                        "\n4 - В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которойможет не совпадать с длиной слова." +
                        "\n5 - Если вы хотите отобразить соответствие" +
                        "\n0 - Введите для корректного завершения программы" +
                        "\n\nВаше решение: ";
                return menuMessage;
            }
            else if (numberMessage == 1)
            {
                string menuMessage = "Введите длину: ";
                return menuMessage;
            }
            else if (numberMessage == 2)
            {
                string menuMessage = "Введите длину слова: ";
                return menuMessage;
            }
            else if (numberMessage == 3)
            {
                string menuMessage = "Введите подстроку: ";
                return menuMessage;
            }
            else if (numberMessage == 4)
            {
                string menuMessage = "Введите количество предложений на странице: ";
                return menuMessage;
            }
            else if (numberMessage == 5)
            {
                string menuMessage = "Вы что-то другое нажали...";
                return menuMessage;
            }
            else if (numberMessage == 6)
            {
                string menuMessage = "Вы решили выйти";
                return menuMessage;
            }
            return null;
        }

        public static string EngMenu(int numberMessage)
        {
            
            string result = ClassLanguge.Main.EngMessageMenu(numberMessage);
            return result;
        }
        public static string RuMenu(int numberMessage)
        {
            string result = ClassLanguge.Main.RuMessageMenu(numberMessage);
            return result;
        }

    }
}
