namespace BookStore.API.Features.Books.CreateBook;

public record CreateBookDto(
    string Title,
    string Author,
    string ISBN,
    DateOnly PublishedDate,
    Guid GenreId,
    int PageCount,
    string Publisher,
    string? Description
);