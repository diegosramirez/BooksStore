namespace BookStore.API.Features.Books.GetBook;

public record BookDetailsDto(
    Guid Id,
    string Title,
    string Author,
    string ISBN,
    DateOnly PublishedDate,
    string Genre,
    int PageCount,
    string? Description,
    string Publisher);
