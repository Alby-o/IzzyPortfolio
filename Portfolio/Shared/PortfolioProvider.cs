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
            Name = "Alexander Blyth",
            Nickname = "Alby",
            Email = "alexanderblyth5@gmail.com",
            PhoneNumber = "0488 526 998",
            GitHubUrl = "https://www.github.com/alby-o",
            LinkedInUrl = "https://www.linkedin.com/in/alby-blyth/",
            Awards = new List<Award>
            {
                new Award
                {
                    Name = "People's Choice Award",
                    Event = "GovHack",
                    Date = new DateOnly(2018, 9, 1),
                    ExternalUrl = "https://www.data.qld.gov.au/article/news-and-events/earlier-open-data-events/govhack-2018/DiscoVR",
                    YoutubeUrl = "https://www.youtube.com/watch?v=Y5OG_eutXII",
                    Description = "DiscoVR gives users a preview of new adventure locations around Australia before living the experience in the real world. Winning the 2018 GovHack People’s Choice award, the app immerses the user in a virtual reality environment, bringing the location and the surrounding conditions to life through a visual and aural experience, not with numbers and graphs, but with clouds, wind, rain and sunshine."
                },
                new Award
                {
                    Name = "Design Award Winner",
                    Event = "UQCS Hackathon",
                    Date = new DateOnly(2019, 8, 1),
                    Description = "Created a 2D platforming game called Moonrisers in Unity. The game utilises Unity's block physics system to race to the moon, while trying to escape the deathly goo below them. The first to the spaceship has the choice to help their friends or leave them for dead."
                }
            },
            EducationHistory = new List<Education>
            {
                new Education
                {
                    GPA = 6.6,
                    Degree = "Bachelor of Engineering",
                    Institution = "The University of Queensland",
                    GraduationDate = new DateOnly(2021, 7, 1),
                    Achievements = new List<string>
                    {
                        "Graduated with First Class Honours.",
                        "Featured in the 2019 Innovation Showcase for Excellence in Design.",
                        "Awarded dean’s commendations for academic excellence on six occassions.",
                        "Received the ENGG1200 Engineering Design Award 2016 for innovation and excellence in a first-year engineering project."
                    }
                }
            },
            WorkHistory = new List<WorkExperience>
            {
                new WorkExperience
                {
                    CompanyName = "3CS Software",
                    CompanyUrl = "https://3cssoftware.com.au/",
                    Slug = "3CS",
                    Location = "Brisbane",
                    StartDate = new DateOnly(2017, 12, 1),
                    Position = "Full Stack Developer",
                    Responsibilities = new List<string>
                    {
                        "Worked with client's needs and requirements to develop effective and beautiful products.",
                        "Developed applications in varied fields including eyecare, insurance premium funding, childcare and business management.",
                        "Developed internal tools using source generation techniques to allow 3CS developers to quickly develop a full stack web application."
                    },
                    TechStack = new List<Technology>() {
                        TechnologyProvider.DotNet,
                        TechnologyProvider.Azure,
                        TechnologyProvider.Blazor,
                        TechnologyProvider.Aurelia,
                        TechnologyProvider.Flutter,
                        TechnologyProvider.Cordova,
                        TechnologyProvider.Android,
                        TechnologyProvider.iOS,
                        TechnologyProvider.Typescript,
                        TechnologyProvider.Less,
                    },
                    Projects = new List<Project>()
                    {
                        new Project()
                        {
                            Name = "Hourly",
                            ExternalUrl = "https://hourlytime.com",
                            Image = "hourly.png",
                            LogoImage = "hourly-logo.svg",
                            Description = "Hourly is a time tracking application used by small to mid-sized businesses. I worked within a small team to develop Hourly using Aurelia and Typescript! I also lead the development on the Hourly mobile apps, using Cordova."
                        },
                        new Project() {
                            Name = "iQumulate Public Website",
                            ExternalUrl = "https://iqumulate.com",
                            Image = "iq.jpg",
                            LogoImage = "iq-logo.svg",
                            Description = "I was the lead developer working on the iQumulate public website. The website was developed using a dotnet MVC solution."
                        },
                        new Project()
                        {
                            Name = "My Kids Vision",
                            ExternalUrl = "https://www.mykidsvision.org/en-us",
                            Image = "mkv.png",
                            LogoImage = "mkv-logo.png",
                            Description = "I'm currently the lead developer on the My Kids Vision website rebranding. My Kids Vision is a public informational website for parents of children with Myopia (short sightedness)."
                        }
                    }
                },
                new WorkExperience
                {
                    CompanyName = "Empower",
                    CompanyUrl = "https://empower.me",
                    Slug = "Empower",
                    Position = "Font-End Developer",
                    Location = "San Francisco",
                    StartDate = new DateOnly(2020, 1, 1),
                    EndDate = new DateOnly(2020, 2, 1),
                    TechStack = new List<Technology> { TechnologyProvider.React },
                    Responsibilities = new List<string>
                    {
                        "Worked on Empower’s internal tools using React.",
                        "Collaborated with a team of 30 employees in Empower’s San Francisco office.",
                        "Provided consultation on SEO, best practices and optimisation.",
                    },
                    Projects = new List<Project>()
                    {
                        new Project()
                        {
                            Name = "Empower Public Website",
                            ExternalUrl = "https://empower.me/",
                            Image = "empower.png",
                            LogoImage = "empower-logo.svg",
                            Description = "I helped develop the empower public website alongside Empower's internal management tools."
                        }
                    }
                },
                new WorkExperience
                {
                    CompanyName = "The University of Queensland",
                    Location = "Brisbane",
                    Slug = "UQ",
                    Position = "Teaching Assistant",
                    StartDate = new DateOnly(2018, 2, 1),
                    EndDate = new DateOnly(2020, 6, 1),
                    CompanyUrl = "https://uq.edu.au/",
                    Responsibilities = new List<string>
                    {
                        "Conducted practicals and tutorials in Software Engineering classes - motivating and guiding students to achieve excellence.",
                        "Taught introduction to web design, teaching students human-centred techniques to design and develop websites in HTML, CSS and JavaScript.",
                        "Taught programming in the large, teaching students to employ techniques in Java to help support good practice, follow documentation and learn object-oriented programming.",
                        "Taught design studio two, where students worked in large classes to make a game using professional tools and processes such as git, SonarQube, JaCoCo, Jenkins, and Kanban.",
                    },
                },
            }
        };
    }
}
