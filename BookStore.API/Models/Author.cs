namespace BookStore.API.Models;

public class Author
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}