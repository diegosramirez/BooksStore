using BookStore.API.Data;

namespace BookStore.API.Features.Books.GetBook;

public static class GetBookEndpoints
{
    public static void MapGetBook(this IEndpointRouteBuilder app)
    {
        app.MapGet("/{id}", (Guid id, BookStoreData bookStoreData) =>
        {
            BookDetailsDto? book = bookStoreData.GetBookById(id);

            if (book is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(book);
        });
    }
}
