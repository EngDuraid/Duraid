using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Duraid.Common.DTO;

namespace Duraid.Blazor.Services.Images
{
    internal class ImageServices:GenericServices<ImageDto>,IImageServices
    {
        public ImageServices(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
