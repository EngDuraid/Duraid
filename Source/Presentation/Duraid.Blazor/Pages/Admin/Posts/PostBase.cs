using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.Common;
using Duraid.Blazor.Services.PostCategories;
using Duraid.Blazor.Services.Posts;
using Duraid.Blazor.Shared.Helper;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Duraid.Blazor.Pages.Admin.PostCategories;
using Duraid.Blazor.Pages.Admin.PostImages;
using Duraid.Blazor.Services.Images;
using Microsoft.AspNetCore.Hosting;

namespace Duraid.Blazor.Pages.Admin.Posts
{

    public class PostBase : ComponentBase
    {

        #region Flields
        protected internal PostCategoryComponent PostCategoryComponent;
        protected internal PostImageComponent PostImageComponent;

        #endregion

        #region Properties


        public string Title { get; set; }



        protected internal RichEditor RichEditor;
        public bool ErrorMessageIsVisible { get; set; }

        public string ErrorMessage { get; set; }
        #endregion

        #region Parameters

        [Parameter]
        public PostDto Post { get; set; }

        [Parameter]
        public string Id { get; set; }

        #endregion

        #region Services
        
       

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        public IPostServices PostServices { get; set; }
        #endregion

        #region Actions
        #region Validation Actions

        

        #endregion

        #region Data Actions

       

        

        async Task<int> SynchronisePostCategoriesAsync()
        {
            int changed = 0;
            changed += await PostCategoryComponent.InsertCategoriesToPostAsync();
            changed += await PostCategoryComponent.DeleteOldCategoriesAsync();
            return changed;
        }

        #endregion

        #region Functional Actions

       

        private void Initialize()
        {
           
            Post = new PostDto();
            
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Initialize();
               // await GetCategoriesAsync();
                if (!(Id is null))
                {
                    Guid.TryParse(Id, out Guid result);
                    Title = "Update";
                    Post = await PostServices.Get(result);
                 //   await GetPostCategoriesAsync();
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
        private async Task ShowErrorMessageAsync(string message)
        {
            ErrorMessage = message;
            ErrorMessageIsVisible = true;
            await Task.Delay(2000);
            ErrorMessageIsVisible = false;
            ErrorMessage = string.Empty;
        }
        #endregion



        protected async Task SaveAsync()
        {
            try
            {
                PostCategoryComponent.PostCategoriesIsValid();
                await RichEditor.GetHTMLAsync();
                if (string.IsNullOrWhiteSpace(RichEditor.QuillHTMLContent))
                {
                    return;
                }
                Post.PostContent = RichEditor.QuillHTMLContent;

                if (!(string.IsNullOrWhiteSpace(Id)))
                {
                    Guid.TryParse(Id, out Guid result);

                    if (!(await PostServices.Update(result, Post) is null))
                    {
                        await SynchronisePostCategoriesAsync();

                        NavigationManager.NavigateTo("admin/posts");
                    }
                }
                else
                {
                    var id = Guid.NewGuid();
                    Post.PostId = id;
                    var created = await PostServices.Create(Post);
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

        #endregion
    }

    
    internal class Test
    {
        private readonly IImageServices _imageServices;
        
        public Test(IImageServices imageServices)
        {
            _imageServices = imageServices;
        }

        public async Task<ImageDto> InsertImage(ImageDto image)
        {
            return await _imageServices.Create(image);
        }

        public async Task<bool> DeleteImage(Guid imageId)
        {
            return await _imageServices.Delete(imageId);
        }
    }

    interface IImageHelper
    {
        void CopyImageFromTempToDestinationFolder(ImageDto image, string savedLocationFolder = "Uploads");
    }
    class ImageHelper : IImageHelper
    {
        private readonly IImageServices _imageServices;
        private readonly IWebHostEnvironment _navigationManager;
        public ImageHelper(IImageServices imageServices, IWebHostEnvironment navigationManager)
        {
            _imageServices = imageServices;
            _navigationManager = navigationManager;
        }


        public void CopyImageFromTempToDestinationFolder(ImageDto image, string savedLocationFolder = "Uploads")
        {
            try
            {
                var rootPath = _navigationManager.WebRootPath;
                var path = Path.Combine(rootPath, savedLocationFolder);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.Copy(Path.Combine(rootPath, "Temp", image.ImageName), Path.Combine(rootPath, savedLocationFolder, image.ImageName), true);
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public void CopyImageFromTempToDestinationFolder(ImageDto image, string savedLocationFolder, string innerFolder)
        {
            CopyImageFromTempToDestinationFolder(image, Path.Combine(savedLocationFolder, innerFolder));
        }
    }
}

