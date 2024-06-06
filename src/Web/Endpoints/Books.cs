
using BookStack.Application.Books.Commands.CreateBook;

public class Books : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapPost(CreateBook);
    }

    public Task<int> CreateBook(ISender sender, CreateBookCommand command)
    {
        return sender.Send(command);
    }
}