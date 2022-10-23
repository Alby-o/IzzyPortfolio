using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class ImageSet
    {
        public IList<Image> Images { get; set; } = new List<Image>();

        // This is a bit lazy, but ¯\_(ツ)_/¯
        public string? VideoName { get; set; }
        public string? VideoPoster { get; set; }

        public ImageSet() { }

        public ImageSet(string imageName, string alt)
        {
            Images.Add(new Image
            {
                Name = imageName,
                Alt = alt
            });
        }
        public ImageSet(string imageName, string alt, bool rounded)
        {
            Images.Add(new Image
            {
                Name = imageName,
                Alt = alt,
                Rounded = rounded
            });
        }

        public ImageSet(IList<Image> images)
        {
            Images = images;
        }
    }

    public class Image
    {
        public string Name { get; set; } = default!;
        public string Alt { get; set; } = default!;
        public bool Rounded { get; set; } = true;

        public Image() { }

        public Image(string name, string alt)
        {
            Name = name;
            Alt = alt;
        }
    }
}
