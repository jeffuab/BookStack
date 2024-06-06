namespace BookStack.Domain.Entities
{
    public class Book : BaseAuditableEntity
    {
        public string? Title { get; set; }

        public string? Author { get; set; }

        public string? Genre { get; set; }

        public string? PublishDate { get; set; }

        public int PageCount { get; set; }
    }
}