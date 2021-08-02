using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using BLL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetProductList()
        {
            var products = ProductRepo.GetProducts();
            var data = AutoMapper.Mapper.Map<List<product>, List<ProductModel>>(products);

            return data;
        }
        public static void AddProduct(ProductModel prdct)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, product>(prdct);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            ProductRepo.AddProduct(data);
        }
    }
}
