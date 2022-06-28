using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class WorkExperience
    {
        public virtual string? Position { get; set; }
        public virtual string? CompanyName { get; set; }
        public virtual string? CompanyUrl { get; set; }
        public virtual string? Location { get; set; }
        public virtual DateOnly StartDate { get; set; }

        /// <summary>
        /// A null EndDate represents a current position held
        /// </summary>
        public virtual DateOnly? EndDate { get; set; }
        public virtual IList<Technology> TechStack { get; set; } = new List<Technology>();
        public virtual IList<Project> Projects { get; set; } = new List<Project>();
        public virtual IList<string> Responsibilities { get; set; } = new List<string>();
    }
}
