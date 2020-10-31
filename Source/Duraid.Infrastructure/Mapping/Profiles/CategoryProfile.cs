using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Infrastructure.Mapping.Profiles
{
    class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CategoryDTO>();
        }
    }
}
