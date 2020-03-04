using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class PredictWeather
    {
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
        public string SearchWeather()
        {
            
            if (TempCalendarRes)
            {
                int valueRnd = rng.Next(1, 20);
                string mesPredict = Properties.PredictionWeather.ResourceManager.GetString("weather" + valueRnd);
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
