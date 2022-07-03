using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Portfolio.Client.Code;
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

            if (Work == null)
            {
                var slug = Portfolio.WorkHistory.FirstOrDefault()?.Slug;
                NavManager.NavigateTo($"/work/{slug}");
            }
        }

        private static string GetWorkUrl(WorkExperience work)
        {
            return $"work/{work?.Slug}";
        }

        private string StartDate
        {
            get
            {
                if (Work == null) return "";

                return Work.StartDate.ToMonthYearString();
            }
        }

        private string EndDate
        {
            get
            {
                if (Work?.EndDate == null) return "Present";

                return Work.EndDate.Value.ToMonthYearString();
            }
        }
    }
}
