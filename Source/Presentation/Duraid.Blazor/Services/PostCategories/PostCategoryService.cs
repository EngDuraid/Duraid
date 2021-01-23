using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services.PostCategories
{
    public class PostCategoryService : GenericServices<PostCategoryDto>, IPostCategoryService
    {
        readonly HttpClient _http;
        public PostCategoryService(HttpClient http) : base(http)
        {
            this._http = http;
        }

        public async Task<IEnumerable<PostCategoryDto>> GetPostCategoriesByPostIdAsync(Guid id)
        {
            try

            {
                return await _http.GetJsonAsync<IEnumerable<PostCategoryDto>>($"api/postCategories/p/{id}");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
