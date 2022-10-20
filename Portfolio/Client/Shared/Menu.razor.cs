using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Portfolio.Client.Code;

namespace Portfolio.Client.Shared
{
    public partial class Menu
    {
        [Parameter] public bool Open { get; set; }
        [Parameter] public List<MenuItem> MenuItems { get; set; } = new();
    }
}
