using BookStore.API.Data;

namespace BookStore.API.Features.Author.CreateAuthor;

public static class CreateAuthorEndpoints
{
    public static void MapCreateAuthor(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", (CreateAuthorDto authorDto, BookStoreContext dbContext) =>
        {
            // Check why I cannot use Author directly (without Models before)
            var author = new Models.Author
            {
                Name = authorDto.Name
            };

            dbContext.Authors.Add(author);

            dbContext.SaveChanges();

            return Results.Created();
            //return Results.CreatedAtRoute("GetAuthor", new { id = author.Id }, authorDto);
        });
    }
}

