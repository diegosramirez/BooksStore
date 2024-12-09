using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Features.Books.GetBook;

public static class GetBookEndpoints
{
    public static void MapGetBook(this IEndpointRouteBuilder app)
    {
        app.MapGet("/{id}", (Guid id, BookStoreContext dbContext) =>
        {
            Book? book = dbContext.Books
                .Include(book => book.Genre)
                .SingleOrDefault(book => book.Id == id);

            if (book is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(new BookDetailsDto(
                book.Id,
                book.Title,
                book.Author,
                book.ISBN,
                book.PublishedDate,
                book.Genre!.Name,
                book.PageCount,
                book.Description,
                book.Publisher)
            );
        })
            .WithName("GetBook");
    }
}
