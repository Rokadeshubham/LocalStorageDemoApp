

using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DemoApp.Components
{
    public partial class SupportingPage : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }

        string currentUrl { get; set; }

        protected override void OnInitialized()
        {
            currentUrl = NavigationManager.Uri;
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await localStorage.SetItemAsync("URL", currentUrl);
        }
    }
}