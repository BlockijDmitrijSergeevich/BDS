using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope.Input;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print(new ConsolePrinter());
            Input.Input input = new Input.Input(new ConsoleInput());
            try
            {

                print.PrintMenu();
                int i = int.Parse(input.ReadLine());
                do
                {
                    switch (i)
                    {
                        case 1:
                            {

                                string tempData, tempPredict;
                                bool tempCalendarRes, tempCalendarResPred;
                                
                                print.PrintEx1();
                                tempData = input.ReadLine();
                                Calendar calendar = new Calendar(tempData);
                                tempCalendarRes = calendar.ValidDate();
                                print.PrintAnswer(Properties.Menu.PrintDatePrediction);
                                tempPredict = input.ReadLine();
                                Calendar calendarPredict = new Calendar(tempPredict);
                                tempCalendarResPred = calendarPredict.ValidDate();
                                print.PrintAnswer(Properties.Menu.PrintPeriod);
                                print.PrintPeriodChoise();
                                int tempI = int.Parse(input.ReadLine());
                                if (tempI == 1)
                                {
                                    if (tempCalendarRes && tempCalendarResPred)
                                    {
                                        Prediction prediction = new Prediction();
                                        string resPrediction = prediction.SearchPredict();
                                        print.PrintAnswer(Properties.Menu.PrintPeriodToday);
                                        print.PrintAnswer(resPrediction);
                                    }
                                    else
                                    {
                                        print.PrintAnswer(Properties.Menu.PrintError);
                                        break;
                                    }
                                }
                                else if (tempI == 2)
                                {
                                    if (tempCalendarRes && tempCalendarResPred)
                                    {
                                        Prediction prediction = new Prediction();
                                        string resPrediction = prediction.SearchPredict();
                                        print.PrintAnswer(Properties.Menu.PrintPeriodWeek);
                                        print.PrintAnswer(resPrediction);
                                    }
                                    else
                                    {
                                        print.PrintAnswer(Properties.Menu.PrintError);
                                        break;
                                    }
                                }
                                else if (tempI == 3)
                                {
                                    if (tempCalendarRes && tempCalendarResPred)
                                    {
                                        Prediction prediction = new Prediction();
                                        string resPrediction = prediction.SearchPredict();
                                        print.PrintAnswer(Properties.Menu.PrintPeriodMonth);
                                        print.PrintAnswer(resPrediction);
                                    }
                                    else
                                    {
                                        print.PrintAnswer(Properties.Menu.PrintError);
                                        break;
                                    }
                                }
                                else
                                {
                                    print.PrintAnswer(Properties.Menu.PrintError);
                                    break;
                                }
                                break;
                            }
                        case 2:
                            {
                                string tempForecastData;
                                bool tempCalendarRes;

                                print.PrintAnswer(Properties.Menu.PrintEx2);
                                print.PrintChoisePeriodDate();
                                int tempJ = int.Parse(input.ReadLine());
                                switch (tempJ)
                                {
                                    case 1:
                                        {
                                            print.PrintAnswer(Properties.Menu.PrintForecastData);
                                            tempForecastData = input.ReadLine();
                                            Calendar calendar = new Calendar(tempForecastData);
                                            tempCalendarRes = calendar.ValidDate();
                                            if (tempCalendarRes)
                                            {
                                                PredictWeather predictWeather = new PredictWeather(tempCalendarRes, tempForecastData);
                                                string resWeather = predictWeather.SearchWeather();
                                                print.PrintAnswer(resWeather);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            print.PrintPeriodChoise2();

                                            int tempI = int.Parse(input.ReadLine());
                                            if (tempI == 1)
                                            {
                                                print.PrintAnswer(Properties.Menu.PrintPeriodToday);
                                                print.PrintAnswer(Properties.Menu.PrintPeriodWeek);
                                                List<string> resWeatherWeek = new List<string>() { };
                                                PredictWeather predictWeek = new PredictWeather(1);
                                                resWeatherWeek = predictWeek.GenerWeather();
                                                DateTime dateTime = DateTime.Now;
                                                foreach (var p in resWeatherWeek)
                                                {
                                                    print.PrintAnswer(dateTime + " " + p);
                                                }
                                            }
                                            else if (tempI == 2)
                                            {
                                                print.PrintAnswer(Properties.Menu.PrintPeriodWeek);
                                                List<string> resWeatherWeek = new List<string>() { };
                                                PredictWeather predictWeek = new PredictWeather(7);
                                                resWeatherWeek = predictWeek.GenerWeather();
                                                DateTime dateTime = DateTime.Now;
                                                foreach (var p in resWeatherWeek)
                                                {
                                                    print.PrintAnswer(dateTime + " " + p);
                                                }
                                            }
                                            else if (tempI == 3)
                                            {
                                                print.PrintAnswer(Properties.Menu.PrintPeriodMonth);
                                                List<string> resWeatherWeek = new List<string>() { };
                                                PredictWeather predictWeek = new PredictWeather(30);
                                                resWeatherWeek = predictWeek.GenerWeather();
                                                DateTime dateTime = DateTime.Now;
                                                foreach (var p in resWeatherWeek)
                                                {
                                                    print.PrintAnswer(dateTime + " " + p);
                                                }
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }                                
                               
                                break;
                            }
                        case 3:
                            {
                                print.PrintAnswer(Properties.Menu.PrintEx3);
                                break;
                            }
                        case 0:
                            {
                                print.PrintAnswer(Properties.Menu.PrintLeave);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    input.ReadLine();
                    print.Clear();
                }
                while (i != 0);
            }
            catch (Exception ex)
            {
                print.PrintEx(ex);
            }
        }
    }
}
