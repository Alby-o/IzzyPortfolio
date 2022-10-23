using Portfolio.Shared;
using Portfolio.Shared.Entities;

namespace Portfolio.Client.Util;

public static class WorkHelper
{
    private static Dictionary<string, Work> worksByName = GetWorksByName();

    private static Dictionary<string, Work> GetWorksByName()
    {
        var worksByName = new Dictionary<string, Work>();
        foreach (var work in PortfolioProvider.Portfolio.Works)
        {
            worksByName.Add(work.Name, work);
        }

        return worksByName;
    }

    public static Work? GetWorkItem(string Name)
    {
        if (worksByName.TryGetValue(Name, out var work)) {
            return work;
        }

        return null;
    }

    public static string GetWorkImageUrl(Work work, string? image = null)
    {
        // Resort to default image name {name}.png if a custom image name is not provided
        var imageName = image ?? work.Image ?? $"{work.Name}.png";
        return $"/images/{work.Name}/{imageName}";
    }

    public static string? GetWorkItemUrl(Work item)
    {
        if (string.IsNullOrWhiteSpace(item?.Name))
        {
            return null;
        }

        return $"work/{item.Name}";
    }
}
