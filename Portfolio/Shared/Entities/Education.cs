using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Shared.Entities
{
    public class Education
    {
        public virtual string? Institution { get; set; }
        public virtual string? Degree { get; set; }
        public virtual double GPA { get; set; }
        public virtual DateOnly GraduationDate { get; set; }
        public virtual IList<string> Responsibilities { get; set; } = new List<string>();

    }
}
