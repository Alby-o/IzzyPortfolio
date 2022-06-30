using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Portfolio.Client.Code;

namespace Portfolio.Client.Shared
{
    public partial class Menu : IDisposable
    {
        [Inject] public NavigationManager NavManager { get; set; } = default!;

        [Parameter] public Theme? Theme { get; set; }
        [Parameter] public EventCallback<Theme?> ThemeChanged { get; set; }

        private List<MenuItem> MenuItems => MenuProvider.MenuItems;

        private bool menuOpen;

        private MenuItem? selected;

        protected override async Task OnInitializedAsync()
        {
            NavManager.LocationChanged += NavManager_LocationChanged;
            await SetMenuOpen();
        }

        private async void NavManager_LocationChanged(object? sender, LocationChangedEventArgs e)
        {
            // Update the selected nav item & rerender
            await SetMenuOpen();
            StateHasChanged();
        }

        private async Task SetTheme(Theme? theme)
        {
            if (!menuOpen) return;

            await ThemeChanged.InvokeAsync(theme);
        }

        private async Task SetMenuOpen()
        {
            var uri = new Uri(NavManager.Uri);
            var selectedItem = MenuItems.FirstOrDefault(i => uri.LocalPath.Contains(i.Url));

            menuOpen = selectedItem == null;

            // If the menu has been closed, update the selected menu item to play the shown animation
            if (!menuOpen)
            {
                await ThemeChanged.InvokeAsync(selectedItem.Theme);
                selected = selectedItem;
            }
            else
            {
                await ThemeChanged.InvokeAsync(null);
            }
        }

        public void Dispose()
        {
            NavManager.LocationChanged -= NavManager_LocationChanged;
        }
    }
}
