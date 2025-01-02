using BookStore.API.Features.Author.CreateAuthor;

namespace BookStore.API.Features.Author;

public static class AuthorEndpoints
{
    public static void MapAuhors(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/authors");

        group.MapCreateAuthor();
    }
}
