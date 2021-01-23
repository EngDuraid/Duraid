using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;


namespace Duraid.Infrastructure.Mapping.Profiles
{
    class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
