using Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_layer
{
    public interface IService
    {
        //category------------------------------------------
        Category GetCategory(string name);
        List<Category> GetCategories();
        Category GetCategoryByProduct(Product product);

        // product-------------------------------------------
        List<Product> GetProductsByCategory(string name);
        Product GetProduct(string name);

        //User---------------------------------------------------
        double DailyColoriesRate(User user);

    }
}
