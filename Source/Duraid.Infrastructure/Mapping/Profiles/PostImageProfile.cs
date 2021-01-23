using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;

namespace Duraid.Infrastructure.Mapping.Profiles
{
    internal class PostImageProfile:Profile
    {
        public PostImageProfile()
        {
            CreateMap<PostImageDto, PostImage>();
            CreateMap<PostImage, PostImageDto>();
        }
        
    }
}
