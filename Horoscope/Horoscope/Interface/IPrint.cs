using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope.Interface
{
    interface IPrint
    {
        void PrintAnswer(string text);
        void PrintMenu(string text);
        void PrintEx1(string text);
        void PrintPeriodChoise(string text);
        void PrintPeriodChoise2(string text);
        void PrintChoisePeriodDate(string text);
        void PrintEx(Exception ex);
        void Clear();
    }
}
