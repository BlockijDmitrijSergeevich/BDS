using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope.DB;
using Horoscope.Input;

namespace Horoscope
{
    class Program
    {
        public static List<string> Statement = new List<string>();
        
        static void Main(string[] args)
        {
            DBFill dB = new DBFill();

            Print print = new Print(new ConsolePrinter());
            Input.Input input = new Input.Input(new ConsoleInput());
            try
            {

                int i;
                do
                {
                    print.PrintMenu();
                    i = int.Parse(input.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                print.Clear();
                                Prediction prediction = new Prediction();
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
                                switch (tempI)
                                {
                                    case 1:
                                        {
                                            if (tempCalendarRes && tempCalendarResPred)
                                            {
                                                string resPrediction = prediction.SearchPredict();
                                                print.PrintAnswer(Properties.Menu.PrintPeriodToday);
                                                Statement.Add(resPrediction);
                                                print.PrintAnswer(resPrediction);
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
                                            if (tempCalendarRes && tempCalendarResPred)
                                            {
                                                string resPrediction = prediction.SearchPredict();
                                                print.PrintAnswer(Properties.Menu.PrintPeriodWeek);
                                                Statement.Add(resPrediction);
                                                print.PrintAnswer(resPrediction);
                                            }
                                            else
                                            {
                                                print.PrintAnswer(Properties.Menu.PrintError);
                                                break;
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (tempCalendarRes && tempCalendarResPred)
                                            {
                                                string resPrediction = prediction.SearchPredict();
                                                print.PrintAnswer(Properties.Menu.PrintPeriodMonth);
                                                Statement.Add(resPrediction);
                                                print.PrintAnswer(resPrediction);
                                            }
                                            else
                                            {
                                                print.PrintAnswer(Properties.Menu.PrintError);
                                                break;
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            print.PrintAnswer(Properties.Menu.PrintError);
                                            break;
                                        }
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
                                                Statement.Add(resWeather);
                                                print.PrintAnswer(resWeather);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            List<string> resWeatherWeek = new List<string>() { };
                                            PredictWeather predictWeek;
                                            DateTime dateTime;
                                            print.PrintPeriodChoise2();
                                            int tempI = int.Parse(input.ReadLine());
                                            switch (tempI)
                                            {
                                                case 1:
                                                    {
                                                        print.PrintAnswer(Properties.Menu.PrintPeriodToday);

                                                        predictWeek = new PredictWeather(1);
                                                        resWeatherWeek = predictWeek.GenerWeather();
                                                        dateTime = DateTime.Now;
                                                        foreach (var p in resWeatherWeek)
                                                        {
                                                            dateTime = dateTime.AddDays(1);
                                                            Statement.Add(dateTime + " " + p);
                                                            print.PrintAnswer(dateTime + " " + p);
                                                        }
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        print.PrintAnswer(Properties.Menu.PrintPeriodWeek);
                                                        predictWeek = new PredictWeather(7);
                                                        resWeatherWeek = predictWeek.GenerWeather();
                                                        dateTime = DateTime.Now;
                                                        foreach (var p in resWeatherWeek)
                                                        {
                                                            dateTime = dateTime.AddDays(1);
                                                            Statement.Add(dateTime + " " + p);
                                                            print.PrintAnswer(dateTime + " " + p);
                                                        }
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        print.PrintAnswer(Properties.Menu.PrintPeriodMonth);
                                                        predictWeek = new PredictWeather(30);
                                                        resWeatherWeek = predictWeek.GenerWeather();
                                                        dateTime = DateTime.Now;
                                                        foreach (var p in resWeatherWeek)
                                                        {
                                                            dateTime = dateTime.AddDays(1);
                                                            Statement.Add(dateTime + " " + p);
                                                            print.PrintAnswer(dateTime + " " + p);
                                                        }
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        print.PrintAnswer(Properties.Menu.PrintError);
                                                        break;
                                                    }
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            print.PrintAnswer(Properties.Menu.PrintError);
                                            break;
                                        }
                                }
                                break;
                            }
                        case 3:
                            {
                                print.PrintAnswer(Properties.Menu.PrintEx3);
                                foreach (var item in Statement)
                                {
                                    print.PrintAnswer(item);                                
                                }
                                break;
                            }
                        case 0:
                            {
                                print.PrintAnswer(Properties.Menu.PrintLeave);
                                break;
                            }
                        default:
                            {
                                print.PrintAnswer(Properties.Menu.PrintError);
                                break;
                            }

                    }
                    print.PrintAnswer("\n\t\t\tНажмите любую клавишу...");
                    input.ReadLine();
                    print.Clear();
                } while (i != 0);
            }
            catch (Exception ex)
            {
                print.PrintEx(ex);
            }

        } 
    }
}
