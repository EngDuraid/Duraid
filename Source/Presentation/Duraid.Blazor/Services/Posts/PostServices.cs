using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services.Posts
{
    public class PostServices : GenericServices<PostDTO>, IPostServices
    {
        public PostServices(HttpClient httpClient) : base(httpClient)
        {

        }
    }
}
