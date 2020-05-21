using Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Data_layer
{
    public class DB
    {
        XDocument xDocument = XDocument.Load("DataBase.xml");
        public List<Category> categories = new List<Category>();
        private Category category;
        private Product product;

        private static DB instanceObject;
        private DB()
        {
            ReadXml();
        }
        public static DB GetInstanceObject()
        {
            if (instanceObject == null)
            {
                instanceObject = new DB();
            }
            return instanceObject;
        }
        public void ReadXml()
        {
            foreach(XElement xElement in xDocument.Elements("Db").Elements("Category"))
            {
                category = new Category();
                category.name = xElement.Attribute("name").Value;
                category.description = xElement.Attribute("description").Value;
                categories.Add(category);
            }
            int i = 0;
            string name = null;
            foreach (XElement xElement in xDocument.Elements("Db").Elements("Category").Elements("Product"))
            {
                if (name != xElement.Parent.Attribute("name").Value)
                {
                    if (name != null)
                    {
                        i++;
                    }
                    name = xElement.Parent.Attribute("name").Value;
                }
                product = new Product();
                product.name = xElement.Attribute("name").Value;
                product.gramms = Convert.ToInt32(xElement.Element("gramms").Value);
                product.protein = Convert.ToDouble(xElement.Element("protein").Value);
                product.fats = Convert.ToDouble(xElement.Element("fats").Value);
                product.carbs = Convert.ToDouble(xElement.Element("carbs").Value);
                product.calories = Convert.ToDouble(xElement.Element("calories").Value);
                categories[i].products.Add(product);
            }
        }
    }
}
