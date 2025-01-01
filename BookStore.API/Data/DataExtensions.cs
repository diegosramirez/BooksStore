using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data;

public static class DataExtensions
{
    public static void InitializeDb(this WebApplication app)
    {
        app.MigrateDb();
        app.SeedDb();
    }

    private static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        BookStoreContext dbContext = scope.ServiceProvider
                                          .GetRequiredService<BookStoreContext>();
        dbContext.Database.Migrate();
    }

    private static void SeedDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        BookStoreContext dbContext = scope.ServiceProvider
                                          .GetRequiredService<BookStoreContext>();

        // Seed Genres
        if (!dbContext.Genres.Any())
        {
            dbContext.Genres.AddRange(
                new Genre { Name = "Fiction" },
                new Genre { Name = "Dystopian" },
                new Genre { Name = "Romance" },
                new Genre { Name = "Tragedy" },
                new Genre { Name = "Adventure" },
                new Genre { Name = "Fantasy" },
                new Genre { Name = "Historical" },
                new Genre { Name = "Psychological Fiction" },
                new Genre { Name = "Epic" },
                new Genre { Name = "Epic Poetry" },
                new Genre { Name = "Modernist" },
                new Genre { Name = "Historical Fiction" },
                new Genre { Name = "Post-apocalyptic Fiction" }
            );

            dbContext.SaveChanges();
        }

        // Seed Authors
        if (!dbContext.Authors.Any())
        {
            dbContext.Authors.AddRange(
                new Author { Name = "Harper Lee" },
                new Author { Name = "George Orwell" },
                new Author { Name = "Jane Austen" },
                new Author { Name = "F. Scott Fitzgerald" },
                new Author { Name = "Herman Melville" },
                new Author { Name = "J.D. Salinger" },
                new Author { Name = "J.R.R. Tolkien" },
                new Author { Name = "Leo Tolstoy" },
                new Author { Name = "Fyodor Dostoevsky" },
                new Author { Name = "Homer" },
                new Author { Name = "Charlotte Brontë" },
                new Author { Name = "Dante Alighieri" },
                new Author { Name = "Aldous Huxley" },
                new Author { Name = "Paulo Coelho" },
                new Author { Name = "John Steinbeck" },
                new Author { Name = "James Joyce" },
                new Author { Name = "Cormac McCarthy" },
                new Author { Name = "Ernest Hemingway" }
            );

            dbContext.SaveChanges();
        }

        // Seed Books
        if (!dbContext.Books.Any())
        {
            var genres = dbContext.Genres.ToList();
            var authors = dbContext.Authors.ToList();

            dbContext.Books.AddRange(
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    AuthorId = authors.First(a => a.Name == "Harper Lee").Id,
                    ISBN = "9780061120084",
                    PublishedDate = new DateOnly(1960, 7, 11),
                    GenreId = genres.First(g => g.Name == "Fiction").Id,
                    PageCount = 281,
                    Description = "A novel about the serious issues of race and rape in 1930s Alabama.",
                    Publisher = "J.B. Lippincott & Co."
                },
                new Book
                {
                    Title = "1984",
                    AuthorId = authors.First(a => a.Name == "George Orwell").Id,
                    ISBN = "9780451524935",
                    PublishedDate = new DateOnly(1949, 6, 8),
                    GenreId = genres.First(g => g.Name == "Dystopian").Id,
                    PageCount = 328,
                    Description = "A dystopian novel set in a totalitarian society ruled by Big Brother.",
                    Publisher = "Secker & Warburg"
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    AuthorId = authors.First(a => a.Name == "Jane Austen").Id,
                    ISBN = "9781503290563",
                    PublishedDate = new DateOnly(1813, 1, 28),
                    GenreId = genres.First(g => g.Name == "Romance").Id,
                    PageCount = 279,
                    Description = "A romantic novel about manners, marriage, and morality in 19th-century England.",
                    Publisher = "T. Egerton"
                },
                new Book
                {
                    Title = "The Great Gatsby",
                    AuthorId = authors.First(a => a.Name == "F. Scott Fitzgerald").Id,
                    ISBN = "9780743273565",
                    PublishedDate = new DateOnly(1925, 4, 10),
                    GenreId = genres.First(g => g.Name == "Tragedy").Id,
                    PageCount = 180,
                    Description = "A novel about the decline of the American Dream in the 1920s.",
                    Publisher = "Charles Scribner's Sons"
                },
                new Book
                {
                    Title = "The Hobbit",
                    AuthorId = authors.First(a => a.Name == "J.R.R. Tolkien").Id,
                    ISBN = "9780547928227",
                    PublishedDate = new DateOnly(1937, 9, 21),
                    GenreId = genres.First(g => g.Name == "Fantasy").Id,
                    PageCount = 310,
                    Description = "The adventure of Bilbo Baggins to reclaim the treasure guarded by Smaug.",
                    Publisher = "George Allen & Unwin"
                }
            );

            dbContext.SaveChanges();
        }
    }
}
