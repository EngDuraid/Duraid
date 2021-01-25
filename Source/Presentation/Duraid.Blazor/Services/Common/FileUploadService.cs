using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Hosting;

namespace Duraid.Blazor.Services.Common
{
    public class FileUploadService : IFileUploadService
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<ImageDto> UploadAsync(IBrowserFile file)
        {
            try
            {
                string imagePath = string.Empty;

                return await CodingImageNameAsync(file);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected internal async Task<ImageDto> CodingImageNameAsync(IBrowserFile file)
        {
            if (file is null)
                throw new NullReferenceException("No file selected");

            if (file.Size > 512000)
                throw new IndexOutOfRangeException("The size of the image must be less than 512 KB.");

            string extension = Path.GetExtension(file.Name).ToLower();

            if (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".gif")
            {

                try
                {


                    var image = CreateImageDto(file, extension);
                    await UploadImageAsync(file, image);
                    return image;
                }
                catch (IOException ex)
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                throw new FormatException("file type not supported!");
            }

        }

        private static async Task UploadImageAsync(IBrowserFile file, ImageDto image)
        {
            var stream = file.OpenReadStream();
            var fs = File.Create(image.ImageUri);
            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        }

        private ImageDto CreateImageDto(IBrowserFile file, string extension)
        {
            const string imageDirectory = "Temp";
            var imageName = EncryptImageName(file, extension);

            var imageUrl = $"/{imageDirectory}/{imageName}";
            var imageUri = $"{_environment.WebRootPath}\\{imageDirectory}\\{imageName}";
            var image = new ImageDto
            {
                ImageName = imageName, ImageDirectory = imageDirectory, ImageUrl = imageUrl, ImageUri = imageUri
            };
            return image;
        }

        private static string EncryptImageName(IBrowserFile file, string extension)
        {
            var name = $"{Guid.NewGuid().ToString().ToUpper()}.{extension}";
            return name;
        }
    }
}
