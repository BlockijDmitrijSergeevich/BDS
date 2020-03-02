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
        public void PrintError(string text)
        {
            Console.WriteLine("Ошибка ввода");
        }
        public void PrintMenu(string text)
        {
            Console.WriteLine(" 1 - Предсказания по дате рождения на дату\n 2 - Прогноз погоды на сегодня, неделю, месяц по дату\n 3 - Вывод статистики по биллинг услугам\n 0 - Выход");
        }
        //Ex1//
        public void PrintEx1(string text)
        {
            Console.WriteLine("Предсказания по дате рождения на дату.\nВведите дату рождения(год, месяц, число): ");
        }
        public void PrintEx1DatePrediction(string text)
        {
            Console.WriteLine("Введите дату предсказания(год, месяц, число): ");
        }
        public void PrintEx1PeriodBefor(string text)
        {
            Console.WriteLine("Введите период(год, месяц, число)\nС: ");
        }
        public void PrintEx1PeriodAfter(string text)
        {
            Console.WriteLine("До: ");
        }
        //Ex2//
        public void PrintEx2(string text)
        {
            Console.WriteLine("Прогноз погоды на сегодня, неделю, месяц по дату");
        }
        public void PrintEx2ForecastData(string text)
        {
            Console.WriteLine("Введите дату прогноза(год, месяц, число)");
        }
        //Ex3//
        public void PrintEx3(string text)
        {
            Console.WriteLine("Вывод статистики по биллинг услугам");
        }

        public void PrintLeave(string text)
        {
            Console.WriteLine("Выход");
        }
    }
}
