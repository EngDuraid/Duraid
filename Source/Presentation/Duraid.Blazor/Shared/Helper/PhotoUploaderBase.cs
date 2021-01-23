using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Duraid.Blazor.Services.Common;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components.Forms;

namespace Duraid.Blazor.Shared.Helper
{
    public class PhotoUploaderBase : ComponentBase
    {
        
        [Inject]
        private IFileUploadService uploadservice { get; set; }

        protected internal string Message = "No file(s) selected";
        IReadOnlyList<IBrowserFile> selectedFiles = new List<IBrowserFile>();
        public IList<ImageDto> Photos { get; set; } = new List<ImageDto>();

        protected internal void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            Message = $"{selectedFiles.Count} file(s) selected";
            StateHasChanged();
        }
        
        [Parameter]
        public EventCallback<ImageDto> PhotoDeleted { get; set; }
        
        [Parameter]
        public EventCallback<ImageDto> PhotoInserted { get; set; }
        
        protected internal async Task RemoveFromPhotosAsync(ImageDto image)
        {
            Photos?.Remove(image);
            await PhotoDeleted.InvokeAsync(image);
        }

        protected internal async Task OnSubmitAsync()
        {
            var count = 0;
            foreach (var file in selectedFiles)
            {
                try
                {
                    var image = await uploadservice.UploadAsync(file);
                    Photos.Add(image);
                    count++;
                    await PhotoInserted.InvokeAsync(image);
                }
                catch (NotSupportedException ex)
                {
                    Message = ex.Message;
                }
                catch (IndexOutOfRangeException e)
                {
                    Message = e.Message;
                }
                catch (FormatException e)
                {
                    Message = e.Message;
                }
                catch (Exception)
                {
                    Message = "Upload failed";
                    StateHasChanged();
                    return;
                }
            }
            Message = $"{count} file(s) uploaded on server";
            StateHasChanged();
        }
    }
}
