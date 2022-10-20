namespace Portfolio.Client.Code
{
    public static class MenuProvider
    {
        public static readonly List<MenuItem> MenuItems = new()
        {
            new MenuItem() {
                Url = "/work", 
                Name = "Work",
            },
            new MenuItem() {
                Url = "/education", 
                Name = "Education",
            },
            new MenuItem() {
                Url = "/awards",
                Name = "Awards",
            },
        };
    }
}
