using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Portfolio.Client.Code;
using Portfolio.Shared;
using Portfolio.Shared.Entities;

namespace Portfolio.Client.Shared
{
    public partial class MainLayout : IDisposable
    {
        private static List<MenuItem> MenuItems => MenuProvider.MenuItems;
        private static SitePortfolio Portfolio => PortfolioProvider.Portfolio;

        private Theme? selectedTheme = null;
        private Theme? menuHoverTheme = null;

        private Theme? Theme => selectedTheme ?? menuHoverTheme;

        private MenuItem? selected = null;

        private bool menuOpen;

        [Inject] public NavigationManager NavManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            NavManager.LocationChanged += NavManager_LocationChanged;
            SetMenuOpen();
        }

        private void NavManager_LocationChanged(object? sender, LocationChangedEventArgs e)
        {
            // Update the selected nav item & rerender
            SetMenuOpen();
            StateHasChanged();
        }


        private void SetMenuOpen()
        {
            var uri = new Uri(NavManager.Uri);
            var selectedItem = MenuItems.FirstOrDefault(i => uri.LocalPath.Contains(i.Url));

            menuOpen = selectedItem == null;

            // If the menu has been closed, update the selected menu item. 
            if (!menuOpen)
            {
                selectedTheme = selectedItem?.Theme;
                selected = selectedItem;
            }
            else
            {
                // When the menu is opened, selected is not set to null as it will play its dissapear animation
                selectedTheme = null;
            }
        }

        public void Dispose()
        {
            NavManager.LocationChanged -= NavManager_LocationChanged;
        }
    }
}
