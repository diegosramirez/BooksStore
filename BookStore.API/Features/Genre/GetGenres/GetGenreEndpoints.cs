using BookStore.API.Data;

namespace BookStore.API.Features.Genre.GetGenres;

public static class GetGenreEndpoints
{
    public static void MapGetGenres(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (BookStoreContext bookStoreContext) =>
        {
            var genres = bookStoreContext.Genres.Select(genre => new GenreDto(genre.Name)).ToList();

            return Results.Ok(genres);
        });
    }
}