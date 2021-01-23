using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostCreateBase : ComponentBase
    {
        public PostDto Post { get; set; }

        protected override void OnInitialized()
        {
            Post = new PostDto();
        }
    }
}

