using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class ImageDto
    {
        public ImageDto()
        {
            ImageId=Guid.NewGuid();
        }
        public Guid ImageId { get; set; }
        public string ImageDescription { get; set; }
        public string ImageUrl { get; set; }
        public  string ImageUri { get; set; }
        public string ImageName { get; set; }
        public string ImageDirectory { get; set; }
    }
}
