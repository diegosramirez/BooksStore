using BookStore.API.Models;

namespace BookStore.API.Features.Books.GetBooks;

public record BookDto(
    Guid Id,
    string Title,
    string Author,
    string? Description);