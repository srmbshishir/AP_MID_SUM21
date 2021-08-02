using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static ATP2_AssignmentEntities context;
        static ProductRepo()
        {
            context = new ATP2_AssignmentEntities();
        }

        public static List<product> GetProducts()
        {
            return context.products.ToList();
        }
        public static void AddProduct(product d)
        {
            context.products.Add(d);
            context.SaveChanges();
        }
    }
}
