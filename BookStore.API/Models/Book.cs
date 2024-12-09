namespace BookStore.API.Models;

public class Book
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string ISBN { get; set; }
    public DateOnly PublishedDate { get; set; }
    public Guid GenreId { get; set; }
    public Genre? Genre { get; set; }
    public int PageCount { get; set; }
    public string? Description { get; set; }
    public required string Publisher { get; set; }
}
