using BookStack.Application.Common.Models;

namespace BookStack.Application.Books.Queries.GetBooks
{
    public class BooksVm
    {
        public IReadOnlyCollection<BookDto> Books { get; init; } = Array.Empty<BookDto>();
    }
}