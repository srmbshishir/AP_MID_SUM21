using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.mapperconfig;
using DAL;

namespace BLL
{
    public class CategoryService
    {
        static CategoryService()
        {
            AutoMapper.Mapper.Initialize(config=>config.AddProfile<automappersettings>());
        }
        public static List<CategoryModel> GetCategoryList()
        {
            var categorys = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<category>, List<CategoryModel>>(categorys);

            return data;
        }
    }
}
