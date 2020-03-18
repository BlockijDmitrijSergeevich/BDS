using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class PredictWeather
    {
        readonly IOF iOF = new IOF(Properties.File.PredictWeather);
        Print print = new Print(new ConsolePrinter());
        public bool TempCalendarRes { get; set; }
        public string Date { get; set; }
        Random rng { get; set;}        
        public PredictWeather(bool tempCalendarRes, string date)
        {
            this.TempCalendarRes = tempCalendarRes;
            this.Date = date;
            rng = new Random(GenerKey());
        }
        DateTime DateNow { get; set; }
        public int CountDays { get; set; }
        public List<string> Res { get; set; }
        public PredictWeather(int countDays)
        {
            this.CountDays = countDays;
            this.Res = GenerWeather();
        }
        public List<string> GenerWeather()
        {
            List<string> vs = new List<string>() { };
            DateNow = DateTime.Now;
            for (int i = 1; i <= CountDays; i++)
            {
                DateNow = DateNow.AddDays(1);
                Random rng = new Random(DateNow.Day);
                int valueRnd = rng.Next(1, 20);                
                string[] weather = iOF.IOPredict();
                vs.Add(weather[valueRnd - 1]);
            }
            return vs;
        }
        public string SearchWeather()
        {
            
            if (TempCalendarRes)
            {
                int valueRnd = rng.Next(1, 20);
                string[] weather = iOF.IOPredict();
                string mesPredict = weather[valueRnd - 1];
                return mesPredict;
            }
            else
            {
                print.PrintAnswer(Properties.Menu.PrintError);
                return null;
            }
        }
        private int GenerKey()
        {
            if (TempCalendarRes)
            {
                int x = (int.Parse(Date.Split(' ')[0]) + int.Parse(Date.Split(' ')[1]) + int.Parse(Date.Split(' ')[2])) / 3;
                return x;
            }
            else
            {
                print.PrintAnswer(Properties.Menu.PrintError);
                return 0;
            }
        }
    }
}
