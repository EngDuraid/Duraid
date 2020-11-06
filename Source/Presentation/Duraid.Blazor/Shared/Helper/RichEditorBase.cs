using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Shared.Helper
{
    public class RichEditorBase:ComponentBase
    {
        public BlazoredTextEditor QuillHtml;

        public string QuillHTMLContent { get; set; }
        public string QuillContent { get; set; }

        public async Task GetHTMLAsync()
        {
            QuillHTMLContent = await QuillHtml.GetHTML();
            StateHasChanged();
        }
    }
}
