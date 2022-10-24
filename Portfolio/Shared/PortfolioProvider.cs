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
                    Description = "The overall honours project that has been developed is a four-piece diorama that portrays the Grimm Brothers version of Cinderella. The diorama requires viewers to uncover the mystery lying within which will lead them to the story of Cinderella. \nThe layout for the diorama is as seen on the right. The four sections will be set out side by side on a long table covered with a black tablecloth. A light either side of the table will eliminate the diorama to direct the focus of the viewer’s eye.",
                    Date = new DateOnly(2022, 1, 1),
                    Image = "A Fairy Story.jpg",
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("A Fairy Story.jpg", "A Fairy Story"),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_9059.jpg", "House inside"),
                            new Image("IMG_9071.jpg", "House outside"),
                        }),
                        new ImageSet("IMG_9224.jpg", "Graveyard"),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_9132.jpg", "House inside"),
                            new Image("IMG_9302.jpg", "House outside"),
                        }),
                        new ImageSet("IMG_9084.jpg", "House cutout"),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_9208.jpg", "Fireplace"),
                            new Image("IMG_9307.jpg", "Paintings"),
                        }),
                        new ImageSet("IMG_9325.jpg", "Tiles being painted"),
                        new ImageSet("Final Setup.png", "Drawing of diorama"),
                    }
                },
                new Work()
                {
                    Name = "Juno and Calio",
                    Description = "Juno and Calio is a collaborative animation project between myself and five others. Below are my illustrative and animation contributions to the project. \nThe story of Juno and Calio follows two characters a cat and a dog who find each other in a world where dogs partner up with other dogs and cats partner up with other cats. Throughout the story the two overcome the judgements of the world they live in and follow their own path together. The changes in emotions the characters face are not only displayed through their expressions and environment but through the colours that emit from their chests. The cool desaturated colours represent sad emotions and the warmer colours represent happier emotions like love.",
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
                    Description = "Based off a TV advertisement the Evolta Batteries animatic was a collaborative project. Shown below are a number of illustrations I created as a sort of style guide that would inform the other teams members about the intended illustration style, colour palette and overall environment. \nThe animatic was based off my interpretation of the script as described in the storyboard. For the final animatic I was in charge of illustrating the characters, some foreground assets and rendering the final storyboard.",
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
                    Description = "A number of illustration from the last few years.",
                    Date = new DateOnly(2022, 1, 1),
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Various Illustrations.png", "Girl in nature"),
                        new ImageSet(new List<Image>
                        {
                            new Image()
                            {
                                Name = "Untitled_Artwork 31 copy.png",
                                Alt = "Climber haning on cliff edge",
                                Rounded = false,
                            },
                            new Image()
                            {
                                Name = "Untitled_Artwork 38.png",
                                Alt = "QUT Cliffhangers",
                                Rounded = false,
                            }
                        }),
                        new ImageSet("Untitled_Artwork 35.png", "Tattooed woman"),
                        new ImageSet(new List<Image>
                        {
                            new Image("Untitled_Artwork 36.png", "Two friends"),
                            new Image("Untitled_Artwork 37.png", "Two friends"),
                        }),
                    }
                },
                new Work()
                {
                    Name = "The Lady from Weedon",
                    Description = "Throughout this project a number of illustrations were developed that tell a reimagined story of the 100th limerick from Edward Lear’s book, Nonsense Omnibus. Lear’s original story lacked the spook elements present in this version, but were an addition to give the audience a new context. \nThe location of the story, Weedon Bec Parish, was transformed for the purpose of this visualisation by giving it a secretive, unsettling past. A past that will never be entirely revealed.",
                    Date = new DateOnly(2021, 1, 1),
                    Image = "Weedon.jpg",
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Weedon.jpg", "Train carriage"),
                        new ImageSet("IMG_0706.JPG", "Train carriage hallway"),
                        new ImageSet("IMG_0696.JPG", "Train in rain"),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_0528.JPG", "Woman waking up"),
                            new Image("Untitled_Artwork 24.jpg", "Woman mistaken"),
                        }),
                        new ImageSet("IMG_0764 copy.jpg", "Storyboard", false),
                        new ImageSet("IMG_0762.jpg", "Storyboard in Black and White", false),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_0527.JPG", "Weedon Station"),
                            new Image("IMG_0545.JPG", "Train"),
                        }),
                        new ImageSet("Untitled_Artwork 8 copy.jpg", "Faces"),
                        new ImageSet(new List<Image>
                        {
                            new Image("IMG_0552.PNG", "Train sketch"),
                            new Image("Untitled_Artwork 13.jpg", "Station sketch"),
                        }),
                        new ImageSet("IMG_0682.JPG", "Woman sketches"),
                    }
                },
                new Work()
                {
                    Name = "Crag Mag",
                    Description = "The objective of this project was to develop a zine based on the experiences of members of the QUT Cliffhangers Rockclimbing Club throughout the year of 2021. The club is a great community who love to climb, socialise, and help each other out along the way. \nThe zine offers a glimpse into the individual experiences and hilarious recounts of some of the club’s best moments. Along with beautiful photography taken by its members showcasing just how many incredible mountains and landscapes are on offer when participating in such a sport.",
                    Date = new DateOnly(2021, 1, 1),
                    Image = "Crag Mag.jpg",
                    File = "CRAG MAG.pdf",
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Crag Mag.jpg", "Crag mag collage"),
                        new ImageSet("Contents Page.jpg", "Contents Page"),
                        new ImageSet("Brooyar Bath Section.jpg", "Brooyar Bath"),
                        new ImageSet(new List<Image>
                        {
                            new Image("Brooyar Bath Section2(1).jpg", "Brooyar Bath Section 1"),
                            new Image("Brooyar Bath Section2.jpg", "Brooyar Bath Section 2"),
                        }),
                        new ImageSet("Sophie and Mitch Do A Multi Section.jpg", "Sophie and Mitch Do A Multipitch"),
                        new ImageSet("Urbenville Section.jpg", "Urbanville"),
                        new ImageSet(new List<Image>
                        {
                            new Image("Urbenville Section2.jpg", "Urbanville Section 1"),
                            new Image("Urbenville Section3.jpg", "Urbanville Section 2"),
                        }),
                        new ImageSet("Outdoor Illustration Section 2.jpg", "Outdoor Illustration 1"),
                        new ImageSet("Outdoor Illustration Section.jpg", "Outdoor Illustration 2"),
                    }
                },
                new Work()
                {
                    Name = "Geobeast",
                    Description = "A typeface with imagery created for a university project.",
                    Date = new DateOnly(2019, 1, 1),
                    ImageSets = new List<ImageSet>()
                    {
                        new ImageSet("Geobeast.png", "Geobeast"),
                        new ImageSet(new List<Image>
                        {
                            new Image("Typeface Flowers.png", "Typeface flowers"),
                            new Image("Face Red.png", "Red face"),
                        }),
                        new ImageSet(new List<Image>
                        {
                            new Image("Typeface Red.png", "Typeface red"),
                            new Image("Face Flowers.png", "Face flowers"),
                        })
                    }
                }
            }
        };
    }
}
