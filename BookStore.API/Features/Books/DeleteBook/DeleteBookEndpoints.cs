using BookStore.API.Data;

namespace BookStore.API.Features.Books.DeleteBook;

public static class DeleteBookEndpoints
{
    public static void MapDeleteBook(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id:guid}", async (Guid id, BookStoreContext dbContext) =>
        {
            var book = await dbContext.Books.FindAsync(id);

            if (book is null)
            {
                return Results.NotFound();
            }

            dbContext.Books.Remove(book);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}
