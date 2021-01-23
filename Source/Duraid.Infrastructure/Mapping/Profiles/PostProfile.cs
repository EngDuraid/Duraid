using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;

namespace Duraid.Infrastructure.Mapping.Profiles
{
    class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<PostDto, Post>();
            CreateMap<Post, PostDto>();
        }
    }
}
