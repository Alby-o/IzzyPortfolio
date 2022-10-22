namespace Portfolio.Client.Code
{
    public class MenuItem
    {
        public virtual string? Name { get; set; }
        public virtual string? Url { get; set; } 
        public virtual bool IsExternalLink { get; set; }
    }
}
