using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            int errorCounter = 0;
            while (loading && errorCounter < 5)
            {
                try
                {
                    if (QuillContent is null)
                        return;
                    await QuillHtml.LoadHTMLContent(QuillContent);
                    loading = false;
                }
                catch(Exception ex)
                {
                    await Task.Delay(10);
                    loading = true;
                    errorCounter++;
                }

            }
        }
    }

}
