using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static ATP2_AssignmentEntities context;
        static CategoryRepo()
        {
            context = new ATP2_AssignmentEntities();
        }

        public static List<category> GetCategories()
        {
            return context.categories.ToList();
        }
    }
}
