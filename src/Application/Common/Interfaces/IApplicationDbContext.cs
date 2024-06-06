using BookStack.Domain.Entities;

namespace BookStack.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Book> Books { get; }
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
