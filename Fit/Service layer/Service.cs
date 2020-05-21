using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_layer;

namespace Service_layer
{
    public class Service : IService
    {
        public double DailyColoriesRate(User user)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(string name)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryByProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
