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
    public class PostCategoryService : GenericServices<PostCategoryDTO>, IPostCategoryService
    {
        readonly HttpClient _http;
        public PostCategoryService(HttpClient http) : base(http)
        {
            this._http = http;
        }

        public async Task<IEnumerable<PostCategoryDTO>> GetPostCategoriesByPostIdAsync(Guid id)
        {
            try

            {
                return await _http.GetJsonAsync<IEnumerable<PostCategoryDTO>>($"api/postCategories/p/{id}");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
