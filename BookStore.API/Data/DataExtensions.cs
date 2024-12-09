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
    }
}
