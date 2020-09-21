using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateForTest
{
    class Count
    {
        private int TbWeight { get; set; }
        private int TbGrowth { get; set; }
        private int TbAge { get; set; }
        private bool RbMale { get; set; }
        private double Res { get; set; }
        private double CalMale { get; set; }
        private double CaleWoman { get; set; }

        public Count(int tbWeight, int tbGrowth, int tbAge, bool rbMale)
        {
            this.TbWeight = tbWeight;
            this.TbGrowth = tbGrowth;
            this.TbAge = tbAge;
            this.RbMale = rbMale;
            MainCountCaloriesMale();
            MainCountCaloriesWoman();
        }
        public double LoseWeight()
        {           
            if (CheckLifestyle())
            {
                Res = CalMale - 300;
            }
            else
            {
                Res = CaleWoman - 300;
            }
            return Res;
        }
        public double GainWeight()
        {
            if (CheckLifestyle())
            {
                Res = CalMale;
            }
            else
            {
                Res = CaleWoman;
            }
            return Res;
        }
        public double MaintainWeight()
        {
            if (CheckLifestyle())
            {
                Res = CalMale;
            }
            else
            {
                Res = CaleWoman;
            }
            return Res;
        }

        private void MainCountCaloriesMale()
        {
            CalMale = (10 * TbWeight) + (6.25 * TbGrowth) - (5 * TbAge) - 161;
        }
        private void MainCountCaloriesWoman()
        {
            CaleWoman = (10 * TbWeight) + (6.25 * TbGrowth) - (5 * TbAge) + 5;
        }
        private bool CheckLifestyle()
        {
            if (RbMale)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
