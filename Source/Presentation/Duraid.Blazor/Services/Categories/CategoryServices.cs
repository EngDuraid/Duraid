using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services.Categories
{
    public class CategoryServices : GenericServices<CategoryDto>, ICategoryServices
    {
        public CategoryServices(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
