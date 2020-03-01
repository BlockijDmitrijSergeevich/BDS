using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Calendar
    {
        public string Data { get; set; }
        public Calendar(string data)
        {
            this.Data = data;
        }
        public bool ValidDate()
        {           
            if (Data.Length > 0)
            {
                try
                {
                    DateTime.Parse(Data);
                    if ((int.Parse(Data.Split(' ')[1]) == 2 && int.Parse(Data.Split(' ')[2]) == 29)&&((int.Parse(Data.Split(' ')[2]) % 4 == 0 && ((int.Parse(Data.Split(' ')[2]) % 100 != 0 || (int.Parse(Data.Split(' ')[2]) % 400 == 0))))))
                    {
                        //високосный/дата введена правильно
                        return true;
                    }
                    else
                    {
                        //не високосный/дата введена правильно
                        return true;
                    }
                }
                catch (Exception)
                {
                    //дата введена не правельно
                    return false;
                }

            }
            else
            {
                //дата отрицательна
                return false;
            }
        }        
    }
}
