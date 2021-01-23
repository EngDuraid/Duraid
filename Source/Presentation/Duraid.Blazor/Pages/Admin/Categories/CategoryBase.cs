using Duraid.Blazor.Services;
using Duraid.Blazor.Services.Categories;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Categories
{
    public class CategoryBase: ComponentBase
    {
        [Parameter]
        public CategoryDto Category { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        //[Inject]
        //public ICategoryCommanders Commanders { get; set; }

        [Inject]
        public ICategoryServices Service { get; set; }

        public string Title { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (!(Id is null))
                {
                    Guid.TryParse(Id, out Guid result);
                    Category = await Service.Get(result);
                    Title = "Update";
                }
                else
                {
                    Title = "Create";
                    Category = new CategoryDto();
                }
            }
            catch (Exception)
            {
                NavigationManager.NavigateTo("/Error");
            }
        }

        protected async Task SaveAsync()
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(Id)))
                {
                    Guid.TryParse(Id, out Guid result);

                    if (!(await Service.Update(result, Category) is null))
                    {
                        NavigationManager.NavigateTo("admin/categories");
                    }
                }
                else
                {
                    await Service.Create(Category);
                    NavigationManager.NavigateTo("admin/categories");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // NavigationManager.NavigateTo("/Error");
            }
        }

        protected async Task Delete()
        {
            try
            {
                if (Category is null)
                    return;

                if (string.IsNullOrWhiteSpace(Id))
                    return;

                Guid.TryParse(Id, out Guid result);
                await Service.Delete(result);
            }
            catch (Exception)
            {
                NavigationManager.NavigateTo("/Error");
            }

        }
    }
}
