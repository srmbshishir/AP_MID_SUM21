using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL.mapperconfig
{
    public class automappersettings : Profile
    {
        public automappersettings()
        {
            CreateMap<CategoryModel, category>();
        }
    }
}
