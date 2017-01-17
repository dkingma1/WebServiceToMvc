using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using MvcWebSiteSystem.Data.Entities;
using System.Data.SqlClient;
#endregion


namespace MvcWebSiteSystem.BLL
{
    class ProductController
    {
        public List<Product> Product_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();

            }
        }

        public Product Product_Get(int productid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);

            }
        }

        public int Product_Add(Product newitem)
        {
            using (var context = new NorthwindContext())
            {
                //on the add, the process will return a copy of the new item from the database
                Product addeditem = context.Products.Add(newitem);
                //YOU MUST REQUEST THAT THE CHANGES TO THE DATABASE BE SAVED
                context.SaveChanges();
                return addeditem.ProductID;
            }
        }
    }
}
