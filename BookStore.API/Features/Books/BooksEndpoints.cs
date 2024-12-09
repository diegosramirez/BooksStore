using BookStore.API.Features.Books.CreateBook;
using BookStore.API.Features.Books.DeleteBook;
using BookStore.API.Features.Books.GetBook;
using BookStore.API.Features.Books.GetBooks;

namespace BookStore.API.Features.Books;

public static class BooksEndpoints
{
    public static void MapBooks(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/books");

        group.MapGetBooks();
        group.MapGetBook();
        group.MapDeleteBook();
        group.MapCreateBook();
    }
}

