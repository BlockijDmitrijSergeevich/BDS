using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class Category
    {
        public Category()
        {

        }
        public List<Product> products = new List<Product>();
        public string name { get; set; }
        public string description { get; set; }
    }
}
