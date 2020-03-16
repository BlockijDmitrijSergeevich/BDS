using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope.Interface;

namespace Horoscope
{        
    public class ConsolePrinter : IPrint
    {
        public void PrintAnswer(string text)
        {
            Console.WriteLine(text);
        }
        public void PrintEx(Exception ex)
        {
            Console.WriteLine(ex);
        }
        public void PrintMenu(string text)
        {
            Console.WriteLine("1 - Предсказания по дате рождения на дату\n2 - Прогноз погоды на сегодня, неделю, месяц по дату\n3 - Вывод статистики по биллинг услугам\n0 - Выход");
        }
        //Ex1//
        public void PrintEx1(string text)
        {
            Console.WriteLine("Предсказания по дате рождения на дату.\nВведите дату рождения(год, месяц, число): ");
        }
        public void PrintChoisePeriodDate(string text)
        {
            Console.WriteLine("1 - Ввести дату\n2 - Выбрать период");
        }
        public void PrintPeriodChoise(string text)
        {
            Console.WriteLine("1 - На сегодня\n2 - На неделю\n3 - На месяц\n");
        }
        public void PrintPeriodChoise2(string text)
        {
            Console.WriteLine("1 - На сегодня\n2 - На неделю\n3 - На месяц\n");
        }
        public void Clear()
        {
            Console.Clear();
        }

    }
}
