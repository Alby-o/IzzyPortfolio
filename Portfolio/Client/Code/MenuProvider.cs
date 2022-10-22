namespace Portfolio.Client.Code
{
    public static class MenuProvider
    {
        public static readonly List<MenuItem> MenuItems = new()
        {
            new MenuItem() {
                Url = "/about", 
                Name = "About",
            },
            new MenuItem() {
                Url = "https://www.instagram.com/izzybodell/", 
                Name = "Instagram",
                IsExternalLink = true
            },
        };
    }
}
