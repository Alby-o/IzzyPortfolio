using Portfolio.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared
{
    public static class TechnologyProvider
    {
        public static readonly Technology DotNet = new Technology()
        {
            Name = ".NET",
            Description = "The full dotnet experience, using C# to deliver applications for the web and mobile phones using .NET MAUI.",
            ImageName = "dotnet.png"
        };

        public static readonly Technology Android = new()
        {
            Name = "Android",
            Description = "Android was used in conjunction to Flutter, Cordova and .NET MAUI to create and deploy mobile apps to the Google Play Store.",
            ImageName = "dotnet.png"
        };

        public static readonly Technology Aurelia = new()
        {
            Name = "Aurelia",
            Description = "Aurelia is a font-end javascript framework (and also my favourite javascript framework) that was used to develop Hourly Time.",
            ImageName = "aurelia.png"
        };

        public static readonly Technology Azure = new()
        {
            Name = "Azure",
            Description = "Azure Devops was used for CI/CD for just about every project worked on.",
            ImageName = "azure.png"
        };

        public static readonly Technology Blazor = new()
        {
            Name = "Blazor",
            Description = "Blazor is Microsoft's solution to the next step in web evolution: Web Assembly. This website is built using Blazor!",
            ImageName = "blazor.png"
        };

        public static readonly Technology Cordova = new()
        {
            Name = "Cordova",
            Description = "Cordova was used to build Android and iOS apps for Hourly Time. The Aurelia web app was bundled with Cordova to reuse the existing code base.",
            ImageName = "cordova.png"
        };

        public static readonly Technology Flutter = new()
        {
            Name = "Flutter",
            Description = "Flutter was used to build an Android and iOS app for checking in children at early childcare centers.",
            ImageName = "flutter.png"
        };

        public static readonly Technology iOS = new()
        {
            Name = "iOS",
            Description = "Hourly's mobile app is developed and deployed to the Apple App Store.",
            ImageName = "ios.png"
        };

        public static readonly Technology Less = new()
        {
            Name = "Less",
            Description = "Less is my css preprocessor of choice, and it was used to style this website here!",
            ImageName = "less.png",
        };

        public static readonly Technology React = new()
        {
            Name = "React",
            Description = "React was used to develop internal tools while interning at Empower.",
            ImageName = "react.png",
        };

        public static readonly Technology Typescript = new()
        {
            Name = "Typescript",
            Description = "A world without types is a pain, which is why I love Typescript! For any javascript work, typescript is my go-to.",
            ImageName = "typescript.png",
        };
    }
}
