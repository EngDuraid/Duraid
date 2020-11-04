using Duraid.Blazor.Services.Categories;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Categories
{
    public class CategoryUpdateBase : ComponentBase
    {
        public CategoryDTO  Category { get; set; }

        [Inject]
        public ICategoryServices Services { get; set; }


        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Category = new CategoryDTO();
            Guid.TryParse(Id, out Guid id);
            if (id == Guid.Empty)
                return;

            Category = await Services.Get(id);
        }
    }
}
