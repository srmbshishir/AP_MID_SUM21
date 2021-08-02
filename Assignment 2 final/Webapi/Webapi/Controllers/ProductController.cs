using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace Webapi.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        [HttpGet]
        public List<ProductModel> GetAllCategorys()
        {
            return ProductService.GetProductList();
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel prdct)
        {
            ProductService.AddProduct(prdct);
        }
    }
}
