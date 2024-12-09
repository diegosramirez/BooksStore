using BookStore.API.Data;

namespace BookStore.API.Features.Books.DeleteBook;

public static class DeleteBookEndpoints
{
    public static void MapDeleteBook(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", (Guid id, BookStoreData bookStoreData) =>
        {
            var result = bookStoreData.DeleteBook(id);

            return result ? Results.NoContent() : Results.NotFound();
        });
    }
}

