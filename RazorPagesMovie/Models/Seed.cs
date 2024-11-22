using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null Razor Pages Movies Context");
                }

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange
                    (
                        new Movie
                        {
                            Title = "When Harry met Sally",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating = "D"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 8.9M,
                            Rating = "R"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Price = 3.99M,
                            Rating = "PC"
                        },
                         new Movie
                         {
                             Title = "Rio Bravo",
                             ReleaseDate = DateTime.Parse("1959-4-15"),
                             Genre = "Western",
                             Price = 3.99M,
                             Rating = "R"
                         }

                    );
                context.SaveChanges();
            }

        }
    }
}
