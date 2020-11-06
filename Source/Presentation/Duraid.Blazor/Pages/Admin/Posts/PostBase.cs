using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.Posts;
using Duraid.Blazor.Shared.Helper;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostBase:ComponentBase
    {
        [Inject]
        public IPostServices Services { get; set; }

        [Parameter]
        public PostDTO Post { get; set; }

        [Parameter]
        public string Id { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        public string Title { get; set; }

        public Guid SelectedCategoryId { get; set; }

        [Inject]
        ICategoryServices CategoryServices { get; set; }

        public IEnumerable<CategoryDTO> Categories { get; set; }
        public List<CategoryDTO> PostCategories { get; set; }
        async Task GetCategoriesAsync()
        {
            Categories = await CategoryServices.Get();
            CategoriesList = Categories.Select(c => c.CategoryName).ToArray();
        }
        public string[] CategoriesList { get; set; }
        public RichEditor RichEditor { get; set; }


        internal void AddPostCategory()
        {
            if (SelectedCategoryId == Guid.Empty)
                return;
            var category = Categories.FirstOrDefault(category => category.CategoryId == SelectedCategoryId);
            if (category is null)
                return;
            if (PostCategories.Any(c => c.CategoryId == category.CategoryId))
                return;
            PostCategories.Add(category);
            //StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await GetCategoriesAsync();
                if (!(Id is null))
                {
                    Guid.TryParse(Id, out Guid result);
                    Post = await Services.Get(result);
                    Title = "Update";
                }
                else
                {
                    Title = "Create";
                    Post = new PostDTO();
                    PostCategories = new List<CategoryDTO>();
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
                await RichEditor.GetHTMLAsync();
                if (string.IsNullOrWhiteSpace(RichEditor.QuillHTMLContent))
                {
                    return;
                }
                Post.PostContent = RichEditor.QuillHTMLContent;

                if (!(string.IsNullOrWhiteSpace(Id)))
                {
                    Guid.TryParse(Id, out Guid result);

                    if (!(await Services.Update(result, Post) is null))
                    {
                        NavigationManager.NavigateTo("admin/posts");
                    }
                }
                else
                {
                    var id = Guid.NewGuid();
                    Post.PostId = id;
                    var created =await Services.Create(Post);
                    NavigationManager.NavigateTo("admin/posts");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // NavigationManager.NavigateTo("/Error");
            }
        }

        public void RemoveCategory(CategoryDTO category)
        {
            PostCategories.Remove(category);
        }

        
    }
}
