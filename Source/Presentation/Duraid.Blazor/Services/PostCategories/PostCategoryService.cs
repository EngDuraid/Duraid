using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services.PostCategories
{
    public class PostCategoryService:GenericServices<PostCategoryDTO>
    {
        public PostCategoryService(HttpClient http):base(http)
        {
        }
    }
}
