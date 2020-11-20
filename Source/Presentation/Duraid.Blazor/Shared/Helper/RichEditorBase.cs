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

        [Parameter]
        public string QuillContent { get; set; }

        public async Task GetHTMLAsync()
        {
            QuillHTMLContent = await QuillHtml.GetHTML();
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender)
                return;
            bool loading = true;
            while (loading)
            {
                try
                {
                    await QuillHtml.LoadHTMLContent(QuillContent);
                    loading = false;
                }
                catch
                {
                    await Task.Delay(10);
                    loading = true;
                }

            }
        }
    }

}
