using Horoscope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Print
    {
        public string Text { get; set; }
        public IPrint Printer { get; set; }

        public Print(IPrint printer)
        {
            this.Printer = printer;
        }
        public void PrintAnswer(string text)
        {
            Printer.PrintAnswer(text);
        }
        public void PrintMenu()
        {
            Printer.PrintMenu(Text);
        }
        public void PrintEx1()
        {
            Printer.PrintEx1(Text);
        }
        public void PrintEx1PeriodChoise()
        {
            Printer.PrintEx1PeriodChoise(Text);
        }
    }
}
