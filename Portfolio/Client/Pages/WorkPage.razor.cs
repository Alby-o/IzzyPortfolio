using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Portfolio.Shared.Entities;

namespace Portfolio.Client.Pages
{
    public partial class WorkPage
    {
        [Inject] public NavigationManager NavManager { get; set; } = default!;

        [CascadingParameter] public SitePortfolio Portfolio { get; set; } = default!;

        [Parameter] public string? Company { get; set; }

        private WorkExperience? Work { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Company != null)
            {
                // This could be more efficient, but seeing as we'll never have more than 3 companies
                // any optimisation isn't really worth it
                Work = Portfolio.WorkHistory.FirstOrDefault(w => w.Slug == Company);
            }
        }

        private static string GetWorkUrl(WorkExperience work)
        {
            return $"work/{work?.Slug}";
        }
    }
}
