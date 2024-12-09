using BookStore.API.Data;

namespace BookStore.API.Features.Books.GetBooks;

public static class GetBooksEndpoints
{
    public static void MapGetBooks(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (BookStoreData bookStoreData) =>
        {
            var books = bookStoreData.GetBooks();

            return books;
        });
    }
}

