using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Infrastructure.Mapping.Profiles
{
    class PostCategoryProfile:Profile
    {
        public PostCategoryProfile()
        {
            CreateMap<PostCategory, PostCategoryDTO>().ForMember(des => des.CategoryName, op => op.MapFrom(src => src.Category.CategoryName));
            CreateMap<PostCategoryDTO, PostCategory>();
        }
    }
}
