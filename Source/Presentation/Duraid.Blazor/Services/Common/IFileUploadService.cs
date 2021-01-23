using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.Common.DTO;

namespace Duraid.Blazor.Services.Common
{
    public interface IFileUploadService
    {
        public Task<ImageDto> UploadAsync(IBrowserFile file);
    }
}
