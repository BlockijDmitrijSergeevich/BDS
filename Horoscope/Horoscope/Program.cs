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
            try
            {
                Print print = new Print(new ConsolePrinter());
                Input.Input input = new Input.Input(new ConsoleInput());

                print.PrintMenu();
                int i = int.Parse(Console.ReadLine());
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
                                print.PrintAnswer(Properties.Menu.PrintEx1DatePrediction);
                                tempPredict = input.ReadLine();
                                Calendar calendarPredict = new Calendar(tempPredict);
                                tempCalendarResPred = calendarPredict.ValidDate();
                                print.PrintAnswer(Properties.Menu.PrintEx1Period);
                                print.PrintEx1PeriodChoise();
                                int tempI = int.Parse(input.ReadLine());
                                if (tempI == 1)
                                {
                                    Prediction prediction = new Prediction(tempCalendarRes, tempCalendarResPred);
                                    string resPrediction = prediction.SearchPredict();
                                    print.PrintAnswer(Properties.Menu.PrintEx1PeriodToday);
                                    print.PrintAnswer(resPrediction);
                                }
                                else if (tempI == 2)
                                {
                                    Prediction prediction = new Prediction(tempCalendarRes, tempCalendarResPred);
                                    string resPrediction = prediction.SearchPredict();
                                    print.PrintAnswer(Properties.Menu.PrintEx1PeriodWeek);
                                    print.PrintAnswer(resPrediction);
                                }
                                else if (tempI == 3)
                                {
                                    Prediction prediction = new Prediction(tempCalendarRes, tempCalendarResPred);
                                    string resPrediction = prediction.SearchPredict();
                                    print.PrintAnswer(Properties.Menu.PrintEx1PeriodYear);
                                    print.PrintAnswer(resPrediction);
                                }
                                else
                                    break;
                                break;
                            }
                        case 2:
                            {
                                string tempForecastData;
                                bool tempCalendarRes;

                                print.PrintAnswer(Properties.Menu.PrintEx2);
                                print.PrintAnswer(Properties.Menu.PrintEx2ForecastData);
                                tempForecastData = input.ReadLine();
                                Calendar calendar = new Calendar(tempForecastData);
                                tempCalendarRes = calendar.ValidDate();
                                PredictWeather predictWeather = new PredictWeather(tempCalendarRes, tempForecastData);
                                string resWeather = predictWeather.SearchWeather();
                                print.PrintAnswer(resWeather);

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
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
