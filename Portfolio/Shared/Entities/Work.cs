using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class Work
    {
        public virtual string Name { get; set; } = default!;
        public virtual string Description { get; set; } = default!;
        public virtual DateOnly Date { get; set; }
        public string? Image { get; set; }
        public string? File { get; set; }
        public IList<ImageSet> ImageSets { get; set; } = new List<ImageSet>();
    }
}
