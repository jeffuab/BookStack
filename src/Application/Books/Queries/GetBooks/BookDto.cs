using BookStack.Domain.Entities;

namespace BookStack.Application.Common.Models;

public class BookDto
{
    public int Id { get; init; }

    public string? Title { get; init; }

    public string? Author { get; init; }

    public string? Genre { get; init; }

    public string? PublishDate { get; init; }

    public int PageCount { get; init; }
}