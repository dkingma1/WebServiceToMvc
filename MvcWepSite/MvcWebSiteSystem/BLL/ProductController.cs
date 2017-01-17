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
    public class ProductController
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
                Product addeditem = context.Products.Add(newitem);
                context.SaveChanges();
                return addeditem.ProductID;
            }
        }

        public void Product_Update(Product newitem)
        {
            using (var context = new NorthwindContext())
            {
                context.Entry(newitem).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Product_Delete(Product item)
        {
            Product_Delete(item.ProductID);
        }

        public void Product_Delete(int productid)
        {
            using (var context = new NorthwindContext())
            {
                Product existing = context.Products.Find(productid);
                context.Products.Remove(existing);
                context.SaveChanges();

            }
        }

        public List<Product> Products_GetByCategories(int categoryid)
        {
            using (var context = new NorthwindContext())
            {

                IEnumerable<Product> results = context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID",
                    new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }


    }
}
