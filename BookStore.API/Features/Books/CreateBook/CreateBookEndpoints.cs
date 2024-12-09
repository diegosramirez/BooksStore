using BookStore.API.Data;
using BookStore.API.Models;

namespace BookStore.API.Features.Books.CreateBook;

public static class CreateBookEndpoints
{
    public static void MapCreateBook(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", (CreateBookDto bookDto, BookStoreContext dbContext) =>
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Author = bookDto.Author,
                GenreId = bookDto.GenreId,
                ISBN = bookDto.ISBN,
                PublishedDate = bookDto.PublishedDate,
                PageCount = bookDto.PageCount,
                Description = bookDto.Description,
                Publisher = bookDto.Publisher,
            };

            dbContext.Books.Add(book);

            dbContext.SaveChanges();

            return Results.CreatedAtRoute("GetBook", new { id = book.Id }, bookDto);
        });
    }
}

