using BookStack.Application.Common.Interfaces;
using BookStack.Domain.Entities;

namespace BookStack.Application.Books.Commands.CreateBook;

public record CreateBookCommand : IRequest<int>
{
    public string? Title { get; init; }
    public string? Author { get; init; }
    public string? Genre { get; init; }
    public string? PublishDate { get; init; }
    public int PageCount { get; init; }
}

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
    }
}

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateBookCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var entity = new Book();

        entity.Title = request.Title;
        entity.Author = request.Author;
        entity.Genre = request.Genre;
        entity.PublishDate = request.PublishDate;
        entity.PageCount = request.PageCount;

        _context.Books.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
