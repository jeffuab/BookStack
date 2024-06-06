using BookStack.Application.Common.Interfaces;
using BookStack.Application.Common.Models;
using BookStack.Application.Common.Security;

namespace BookStack.Application.Books.Queries.GetBooks;

[Authorize]
public record GetBooksQuery : IRequest<BooksVm>;


public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, BooksVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetBooksQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BooksVm> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        return new BooksVm
        {
            Books = await _context.Books
                .ProjectTo<BookDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.Title)
                .ToListAsync(cancellationToken)
        };
    }
}
