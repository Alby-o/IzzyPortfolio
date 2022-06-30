namespace Portfolio.Client.Code
{
    public static class MenuProvider
    {
        public static readonly List<MenuItem> MenuItems = new()
        {
            new MenuItem() {
                Url = "/work", 
                Name = "Work",
                Theme = Theme.Work,
            },
            new MenuItem() {
                Url = "/education", 
                Name = "Education",
                Theme = Theme.Education,
            },
            new MenuItem() {
                Url = "/achievements",
                Name = "Achievements",
                Theme = Theme.Achievements,
            },
        };
    }
}
