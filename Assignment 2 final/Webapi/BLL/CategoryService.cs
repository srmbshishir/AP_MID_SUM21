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
    public class CategoryService
    {

        public static List<CategoryModel> GetCategoryList()
        {
            var categorys = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<category>, List<CategoryModel>>(categorys);

            return data;
        }
        public static void AddDepartment(CategoryModel dept)
        {
            var d = AutoMapper.Mapper.Map<CategoryModel, category>(dept);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            CategoryRepo.AddDepartment(d);
        }
    }
}
