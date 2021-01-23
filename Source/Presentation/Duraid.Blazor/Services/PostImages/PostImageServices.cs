using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Duraid.Common.DTO;

namespace Duraid.Blazor.Services.PostImages
{
    internal class PostImageServices :GenericServices<PostImageDto>,IPostImageServices
    {
        public PostImageServices(HttpClient httpClient):base(httpClient)
        {
            
        }
    }

    public interface IPostImageServices:IGenericServices<PostImageDto>
    {
        
    }

}
