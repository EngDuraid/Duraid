using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.PostCategories;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;

namespace Duraid.Blazor.Pages.Admin.PostCategories
{
    public class PostCategoryComponentBase : ComponentBase
    {
        public Guid SelectedCategoryId { get; set; }
        public IEnumerable<CategoryDto> CategoriesList { get; set; }
        public IList<CategoryDto> Categories { get; set; }
        public IEnumerable<PostCategoryDto> PostCategories { get; set; }
        public string[] CategoriesArray { get; set; }


        #region Services
        [Inject]
        private ICategoryServices CategoryServices { get; set; }
        [Inject]
        private IPostCategoryService PostCategoryService { get; set; }
        #endregion

        [Parameter] public PostDto Post { get; set; }

        #region Actions

        #region DataActions
        protected internal async Task<int> DeleteOldCategoriesAsync()
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
        private async Task GetCategoriesAsync()
        {
            CategoriesList = await CategoryServices.Get();
            CategoriesArray = CategoriesList.Select(c => c.CategoryName).ToArray();
        }
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

            Categories?.Add(category);
            //StateHasChanged();
        }
        public void RemoveCategory(CategoryDto category)
        {
            Categories.Remove(category);
        }

        private async Task GetPostCategoriesAsync()
        {
            if (Post.PostId == Guid.Empty)
                throw new Exception("Internal communication error!");
            PostCategories = await PostCategoryService.GetPostCategoriesByPostIdAsync(Post.PostId);
            foreach (var postCategory in PostCategories)
            {
                var category = new CategoryDto { CategoryId = postCategory.CategoryId, CategoryName = postCategory.CategoryName };
                Categories.Add(category);
            }
        }

        protected  internal async Task<int> InsertCategoriesToPostAsync()
        {
            int count = 0;
            foreach (var category in Categories)
            {
                if (!PostCategories.Any(c => c.CategoryId == category.CategoryId))
                {
                    if (!(await InsertPostCategoryAsync(CreatePostCategoryDto(category.CategoryId)) is null))
                        count++;
                }
            }
            return count;
        }

        protected internal async Task<bool> DeletePostCategoryAsync(Guid postCategoryId)
        {
            return await PostCategoryService.Delete(postCategoryId);
        }

        private async Task<PostCategoryDto> InsertPostCategoryAsync(PostCategoryDto dto)
        {
            return await PostCategoryService.Create(dto);
        }
        #endregion

        #region Validation Actions

        protected internal void PostCategoriesIsValid()
        {

            if (Categories?.Count < 1)
                throw new Exception("The post must have one category at least!");
        }

        #endregion

        #endregion
        private PostCategoryDto CreatePostCategoryDto(Guid categoryId)
        {
            return new()
            {
                PostId = Post.PostId,
                CategoryId = categoryId,
                PostCategoryId = Guid.NewGuid()
            };
        }

        protected override void OnInitialized()
        {
           
            PostCategories ??= new List<PostCategoryDto>();
            Categories = new List<CategoryDto>();
           
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(!firstRender)
                return;
            await GetCategoriesAsync();
            if (!(Post is null))
            {
                await GetPostCategoriesAsync();
            }
                
            StateHasChanged();
           
        }

        protected  internal async Task SavePostCategoriesAsync()
        {
            await Task.Delay(10);
        }

        

    }

}
