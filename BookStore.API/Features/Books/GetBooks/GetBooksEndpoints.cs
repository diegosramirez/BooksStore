using BookStore.API.Data;
using BookStore.API.Features.Books.GetBook;

namespace BookStore.API.Features.Books.GetBooks;

public static class GetBooksEndpoints
{
    public static void MapGetBooks(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (BookStoreContext dbContext) =>
        {
            var books = dbContext.Books.Select(book => new BookDto
            (
                book.Id,
                book.Title,
                book.Author.Name,
                book.Description
            )).ToList();

            return books;
        });
    }
}

