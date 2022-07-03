namespace Portfolio.Shared.Entities
{
    public class Project
    {
        public virtual string? Name { get; set; }
        public virtual string? Image { get; set; }
        public virtual string? LogoImage { get; set; }
        public virtual string? ExternalUrl { get; set; }
        public virtual string? Description { get; set; }

    }
}