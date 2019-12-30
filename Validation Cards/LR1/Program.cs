using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR1
{
    public enum cardtype { INVALID, AMEX, VISA, MASTER };
    class Program
    {

        static void Main(string[] args)
        {
            int i, numberMessage;
            do
            {
                var cultures = Language.GetAvailableCultures();
                var languages = Language.GetAvailableLanguages(cultures);
                var index = IOC.LanguageMenu(languages);
                Language.SetCurrent(cultures[index]);
                numberMessage = 0;
                string message = IOC.Menu(numberMessage);
                IOC.writeMessage(message);
                

                i = IOC.Answer();

                switch (i)
                {
                    case 1:
                        string path;
                        path = IOC.CheckFileName();
                        try
                        {
                            File.Exists(path);
                            IOF.Out(path);

                            IOC.Write(Properties.Resource.Resource.Good);
                        }
                        catch
                        {
                            IOC.Write(Properties.Resource.Resource.Error);
                        }
                        IOF.Input(path);
                        break;
                    case 2:
                        Console.WriteLine();
                        IOC.ConsolOut();
                        break;
                    case 3:
                        IOC.Write(Properties.Resource.Resource.Leave);
                        break;
                    default:
                        IOC.Write(Properties.Resource.Resource.Ups);
                        break;
                }
                IOC.Write(Properties.Resource.Resource.KeyPress);
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 3);
        }
    }
}