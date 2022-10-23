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
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2022, 1, 1),
                    Image = "A Fairy Story.jpg",
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("A Fairy Story.jpg", "A Fairy Story")
                    }
                },
                new Work()
                {
                    Name = "Juno and Calio",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2022, 1, 1),
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Juno and Calio.png", "Juno and Calio"),
                        new ImageSet("Town Street w Background Characters.png", "Town Street w Background Characters"),
                        new ImageSet(new List<Image>
                        {
                            new Image()
                            {
                                Name = "Map Transparent.png",
                                Alt = "Map",
                                Rounded = false,
                            },
                            new Image()
                            {
                                Name = "Dancing Cat.gif",
                                Alt = "Dancing cat",
                                Rounded = true,
                            }
                        })
                    }
                },
                new Work()
                {
                    Name = "Evolta Batteries",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2022, 1, 1),
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Evolta Batteries.png", "Man next to fire with speaker and battery"),
                        new ImageSet("IMG_0992.jpg", "Close up of battery"),
                        new ImageSet("Untitled_Artwork 3.jpg", "Aliens standing next to speaker"),
                        new ImageSet(new List<Image>
                        {
                            new Image()
                            {
                                Name = "IMG_0894.PNG",
                                Alt = "Storyboard",
                                Rounded = false,
                            },
                            new Image()
                            {
                                Name = "IMG_0895.PNG",
                                Alt = "Storyboard",
                                Rounded = false,
                            }
                        }),
                        new ImageSet()
                        {
                            VideoName ="Animatic_SFX_V2.mp4",
                            VideoPoster = "poster.jpg"
                        }
                    }
                },
                new Work()
                {
                    Name = "Various Illustrations",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2022, 1, 1)
                },
                new Work()
                {
                    Name = "The Lady from Weedon",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2021, 1, 1),
                    Image = "Weedon.jpg"
                },
                new Work()
                {
                    Name = "Crag Mag",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2021, 1, 1),
                    Image = "Crag Mag.jpg"
                },
                new Work()
                {
                    Name = "Geobeast",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.",
                    Date = new DateOnly(2019, 1, 1)
                }
            }
        };
    }
}
