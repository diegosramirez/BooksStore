using BookStore.API.Data;
using BookStore.API.Models;

namespace BookStore.API.Features.Books.CreateBook;

public static class CreateBookEndpoints
{
    public static void MapCreateBook(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", (CreateBookDto bookDto, BookStoreContext dbContext) =>
        {
            var author = dbContext.Authors.FirstOrDefault(author => author.Id == bookDto.AuthorId);

            if (author is null)
            {
                return Results.NotFound("Author not found!");
            }

            var genre = dbContext.Genres.FirstOrDefault(genre => genre.Id == bookDto.GenreId);

            if (genre is null)
            {
                return Results.NotFound("Genre not found!");
            }

            var book = new Book
            {
                Title = bookDto.Title,
                Author = author,
                Genre = genre,
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

