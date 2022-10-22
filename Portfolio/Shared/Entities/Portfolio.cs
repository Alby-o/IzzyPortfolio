using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class SitePortfolio
    {
        public virtual string? Name { get; set; }
        public virtual string? Nickname { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual IList<Work> Works { get; set; } = new List<Work>();
    }
}
