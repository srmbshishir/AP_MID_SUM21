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
    public class CategoryController : ApiController
    {
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllCategorys()
        {
            return CategoryService.GetCategoryList();
        }
    }
}
