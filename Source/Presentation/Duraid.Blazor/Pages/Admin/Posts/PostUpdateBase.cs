using Duraid.Blazor.Services.PostCategories;
using Duraid.Blazor.Services.Posts;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostUpdateBase:ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        public PostDto Post { get; set; }

        [Inject]
        IPostServices Services { get; set; }


        [Inject]
        IPostCategoryService PostCategoryService { get; set; }

        public IEnumerable<PostCategoryDto> PostCategories { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Guid.TryParse(Id, out Guid id);

                if (id == Guid.Empty)
                    return;
                
                Post = await Services.Get(id);
                if(Post?.PostId != Guid.Empty)
                {
                    PostCategories = await PostCategoryService.GetPostCategoriesByPostIdAsync(Post.PostId);
                }
                PostCategories ??= new List<PostCategoryDto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
