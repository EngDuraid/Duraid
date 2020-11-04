using Duraid.Blazor.Services.Posts;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostsBase:ComponentBase
    {
        public IEnumerable<PostDTO> Posts { get; set; }

        [Inject]
        public IPostServices Services { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await GetPostsAsync();
        }

        async Task GetPostsAsync()
        {
            Posts =  await Services.Get();
        }
    }
}
