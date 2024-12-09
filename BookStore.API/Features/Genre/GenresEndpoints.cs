using BookStore.API.Features.Genre.GetGenres;

namespace BookStore.API.Features.Genre;

public static class GenresEndpoints
{
    public static void MapGenres(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/genres");

        group.MapGetGenres();
    }
}

