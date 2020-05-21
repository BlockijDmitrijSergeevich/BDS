using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class Product
    {
        public Product()
        {

        }
        public string name { get; set; }
        public int gramms { get; set; }
        public double protein { get; set; }
        public double fats { get; set; }
        public double carbs { get; set; }
        public double calories { get; set; }
    }
}
