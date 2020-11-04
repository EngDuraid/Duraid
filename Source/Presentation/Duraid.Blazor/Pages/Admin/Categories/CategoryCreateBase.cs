using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Categories
{
    public class CategoryCreateBase:ComponentBase
    {
        public CategoryDTO Category { get; set; }

        protected override void OnInitialized()
        {
            Category = new CategoryDTO();
        }
    }
}
