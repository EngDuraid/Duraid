using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostCreateBase : ComponentBase
    {
        public PostDTO Post { get; set; }

        protected override void OnInitialized()
        {
            Post = new PostDTO();
        }
    }
}

