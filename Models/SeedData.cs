using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Green Book ",
                        ReleaseDate = DateTime.Parse("2018-9-11"),
                        Genre = "Drama",
                        Price = 29.99M
                    },

                    new Movie
                    {
                        Title = "Bohemian Rhapsody",
                        ReleaseDate = DateTime.Parse("2018-10-23"),
                        Genre = "Biography",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "Black Panther",
                        ReleaseDate = DateTime.Parse("2018-1-29"),
                        Genre = "Action",
                        Price = 16.99M
                    },

                    new Movie
                    {
                        Title = "The Favourite",
                        ReleaseDate = DateTime.Parse("2018-8-30"),
                        Genre = "Biography",
                        Price = 27.99M
                    },

                    new Movie
                    {
                        Title = "BlacKkKlansman",
                        ReleaseDate = DateTime.Parse("2018-5-14"),
                        Genre = "Biography",
                        Price = 14.99M
                    },

                    new Movie
                    {
                        Title = "A Star Is Born",
                        ReleaseDate = DateTime.Parse("2018-8-31"),
                        Genre = "Music",
                        Price = 17.99M
                    },

                    new Movie
                    {
                        Title = "Roma",
                        ReleaseDate = DateTime.Parse("2018-8-30"),
                        Genre = "Drama",
                        Price = 24.99M
                    },

                     new Movie
                     {
                         Title = "Vice",
                         ReleaseDate = DateTime.Parse("2018-12-25"),
                         Genre = "Biography",
                         Price = 12.99M
                     }

                );
                context.SaveChanges();
            }
        }
    }
}