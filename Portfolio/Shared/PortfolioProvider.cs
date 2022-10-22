using Portfolio.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared
{
    public static class PortfolioProvider
    {
        public static readonly SitePortfolio Portfolio = new()
        {
            Name = "Izzy Bodell",
            Nickname = "Izzy",
            Email = "izzybodell@gmail.com",
            PhoneNumber = "",
            Works = new List<Work>()
            {
                new Work()
                {
                    Name = "A Fairy Story",
                    Description = "",
                    Date = new DateOnly(2022, 1, 1),
                    Image = "A Fairy Story.jpg"
                },
                new Work()
                {
                    Name = "Juno and Calio",
                    Description = "",
                    Date = new DateOnly(2022, 1, 1)
                },
                new Work()
                {
                    Name = "Evolta Batteries",
                    Description = "",
                    Date = new DateOnly(2022, 1, 1)
                },
                new Work()
                {
                    Name = "Various Illustrations",
                    Description = "",
                    Date = new DateOnly(2022, 1, 1)
                },
                new Work()
                {
                    Name = "The Lady from Weedon",
                    Description = "",
                    Date = new DateOnly(2021, 1, 1),
                    Image = "Weedon.jpg"
                },
                new Work()
                {
                    Name = "Crag Mag",
                    Description = "",
                    Date = new DateOnly(2021, 1, 1)
                },
                new Work()
                {
                    Name = "Geobeast",
                    Description = "",
                    Date = new DateOnly(2019, 1, 1)
                }
            }
        };
    }
}
