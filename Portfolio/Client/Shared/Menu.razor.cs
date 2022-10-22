using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Portfolio.Client.Code;
using Portfolio.Shared.Entities;

namespace Portfolio.Client.Shared
{
    public partial class Menu
    {
        [Parameter] public bool Open { get; set; }
        [Parameter] public IList<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        [Parameter] public IList<Work> Works { get; set; } = new List<Work>();
    }
}
