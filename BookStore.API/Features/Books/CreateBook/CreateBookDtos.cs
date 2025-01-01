namespace BookStore.API.Features.Books.CreateBook;

public record CreateBookDto(
    string Title,
    Guid AuthorId,
    string ISBN,
    DateOnly PublishedDate,
    Guid GenreId,
    int PageCount,
    string Publisher,
    string? Description
);