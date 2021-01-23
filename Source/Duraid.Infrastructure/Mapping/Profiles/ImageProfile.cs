using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;

namespace Duraid.Infrastructure.Mapping.Profiles
{
    class ImageProfile:Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageDto, Image>();
            CreateMap<Image, ImageDto>();
        }
    }
}
