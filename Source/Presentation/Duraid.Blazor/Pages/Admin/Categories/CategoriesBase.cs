using Duraid.Blazor.Services;
using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Shared.Helper;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Pages.Admin.Categories
{
    public class CategoriesBase : ComponentBase
    {
        private HubConnection hubConnection;
        
        public ICollection<CategoryDTO> Categories { get; set; }
        [Inject]
        public ICategoryServices Service { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Confirm DeleteConfirmation { get; set; }

        public Guid Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await UpdateCategoriesAsync();

            await StartListen();
        }

        private async Task UpdateCategoriesAsync()
        {
            Categories = (ICollection<CategoryDTO>)await Service.Get();
        }

        protected async Task StartListen()
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(NavigationManager.ToAbsoluteUri("https://localhost:44341/connector"))
                .Build();

            hubConnection.On<ICollection<CategoryDTO>>("GetMessage", (categories) =>
            {
                Categories = categories;
                StateHasChanged();
            });
            await hubConnection.StartAsync();
        }


        protected void Delete(Guid id)
        {
            DeleteConfirmation.Show();
            Id = id;
        }

        protected async Task ConfirmDeleteAsync(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                if (Id == Guid.Empty)
                    return;

                await Service.Delete(Id);
                await UpdateCategoriesAsync();
            }
        }

        protected internal void Edit(Guid id)
        {
            NavigationManager.NavigateTo($"/admin/categories/update/{id}");
        }
    }
}
