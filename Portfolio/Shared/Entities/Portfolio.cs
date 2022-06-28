using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class Portfolio
    {
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? GitHubUrl { get; set; }
        public virtual string? LinkedInUrl { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual IList<WorkExperience> WorkHistory { get; set; } = new List<WorkExperience>();
        public virtual IList<Education> EducationHistory { get; set; } = new List<Education>();
    }
}
