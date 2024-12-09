using BookStore.API.Data;
using BookStore.API.Models;

namespace BookStore.API.Features.Books.CreateBook;

public static class CreateBookEndpoints
{
    public static void MapCreateBook(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", (Book book, BookStoreData bookStoreData) =>
        {
            var newBook = bookStoreData.CreateBook(book);

            return Results.CreatedAtRoute("GetBook", new { id = newBook.Id }, book);
        });
    }
}

