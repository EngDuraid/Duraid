using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.PostCategories;
using Duraid.Blazor.Services.Posts;
using Duraid.Blazor.Shared.Helper;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Posts
{
    public class PostBase : ComponentBase
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

        [Inject]
        IPostCategoryService PostCategoryService { get; set; }

        public IEnumerable<CategoryDTO> CategoriesList { get; set; }
        public List<CategoryDTO> Categories { get; set; }
        public IEnumerable<PostCategoryDTO> PostCategories { get; set; }
        async Task GetCategoriesAsync()
        {
            CategoriesList = await CategoryServices.Get();
            CategoriesArray = CategoriesList.Select(c => c.CategoryName).ToArray();
        }
        public string[] CategoriesArray { get; set; }
        public RichEditor RichEditor { get; set; }

        public string ErrorMessage { get; set; }

        internal void AddPostCategory()
        {
            if (SelectedCategoryId == Guid.Empty)
                return;

            var category = CategoriesList.FirstOrDefault(category => category.CategoryId == SelectedCategoryId);

            if (category is null)
                return;

            bool c = Categories?.Any(c => c.CategoryId == category.CategoryId) ?? false;

            if (c)
                return;

            Categories.Add(category);
            //StateHasChanged();
        }

        void Initialize()
        {
            PostCategories ??= new List<PostCategoryDTO>();

            Categories = new List<CategoryDTO>();

            Post = new PostDTO();
        }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Initialize();
                await GetCategoriesAsync();
                if (!(Id is null))
                {
                    Guid.TryParse(Id, out Guid result);
                    Title = "Update";
                    Post = await Services.Get(result);
                    await GetPostCategoriesAsync();
                }
                else
                {
                    Title = "Create";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                NavigationManager.NavigateTo("/Error");
            }
        }
        async Task GetPostCategoriesAsync()
        {
            if (Post.PostId == Guid.Empty)
                throw new Exception("Internal communication error!");
            PostCategories = await PostCategoryService.GetPostCategoriesByPostIdAsync(Post.PostId);
            foreach (var postCategory in PostCategories)
            {
                var category = new CategoryDTO { CategoryId = postCategory.CategoryId, CategoryName = postCategory.CategoryName };
                Categories.Add(category);
            }
        }

        void PostCategoriesIsValid()
        {

            if (Categories?.Count < 1)
                throw new Exception("The post must have one category at least!");
        }
        protected async Task SaveAsync()
        {
            try
            {
                PostCategoriesIsValid();
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
                        await SynchronisePostCategoriesAsync();

                        NavigationManager.NavigateTo("admin/posts");
                    }
                }
                else
                {
                    var id = Guid.NewGuid();
                    Post.PostId = id;
                    var created = await Services.Create(Post);
                    await SynchronisePostCategoriesAsync();
                    NavigationManager.NavigateTo("admin/posts");
                }
            }
            catch (Exception ex)
            {
                await ShowErrorMessageAsync(ex.Message);
                // NavigationManager.NavigateTo("/Error");
            }
        }
        async Task<int> SynchronisePostCategoriesAsync()
        {
            int changed = 0;
            changed += await InsertCategoriesToPostAsync();
            changed += await DeleteOldCategoriesAsync();
            return changed;
        }
        async Task<int> InsertCategoriesToPostAsync()
        {
            int count = 0;
            foreach (var category in Categories)
            {
                if (!PostCategories.Any(c => c.CategoryId == category.CategoryId))
                {
                    if (!(await InsertPostCategoryAsync(CreatePostCategoryDTO(category.CategoryId)) is null))
                        count++;
                }
            }
            return count;
        }

        async Task<int> DeleteOldCategoriesAsync()
        {
            int count = 0;
            foreach (var postCategory in PostCategories)
            {
                if (!Categories.Any(c => c.CategoryId == postCategory.CategoryId))
                {
                    if (await DeletePostCategoryAsync(postCategory.PostCategoryId))
                        count++;
                }
            }
            return count;
        }
        async Task<bool> DeletePostCategoryAsync(Guid postCategoryId)
        {
            return await PostCategoryService.Delete(postCategoryId);
        }

        async Task<PostCategoryDTO> InsertPostCategoryAsync(PostCategoryDTO dTO)
        {
            return await PostCategoryService.Create(dTO);
        }
        PostCategoryDTO CreatePostCategoryDTO(Guid categoryId)
        {
            return new PostCategoryDTO
            {
                PostId = Post.PostId,
                CategoryId = categoryId,
                PostCategoryId = Guid.NewGuid()
            };
        }

        public void RemoveCategory(CategoryDTO category)
        {
            Categories.Remove(category);
        }
        public bool ErrorMessageIsVisible { get; set; }

        async Task ShowErrorMessageAsync(string message)
        {
            ErrorMessage = message;
            ErrorMessageIsVisible = true;
            await Task.Delay(2000);
            ErrorMessageIsVisible = false;
            ErrorMessage = string.Empty;
        }

    }
}
