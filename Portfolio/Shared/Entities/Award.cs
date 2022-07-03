namespace Portfolio.Shared.Entities
{
    public class Award
    {
        public virtual string? Name { get; set; }
        public virtual string? Event { get; set; }
        public virtual DateOnly? Date { get; set; }
        public virtual string? ExternalUrl { get; set; }
        public virtual string? YoutubeUrl { get; set; }
        public virtual string? Description { get; set; }

    }
}