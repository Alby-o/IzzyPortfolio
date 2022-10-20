using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Portfolio.Client.Code;
using Portfolio.Shared;
using Portfolio.Shared.Entities;

namespace Portfolio.Client.Shared
{
    public partial class MainLayout
    {
        private static List<MenuItem> MenuItems => MenuProvider.MenuItems;
        private static SitePortfolio Portfolio => PortfolioProvider.Portfolio;
    }
}
