using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Until Forever",
                        ReleaseDate = DateTime.Parse("2016-2-12"),
                        Genre = "Romantic",
                        Rating = "PG",
                        Price = 7.99M,
                        Image_ID = "until_forever.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 8.99M,
                        Image_ID = "17_miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "States of Grace",
                        ReleaseDate = DateTime.Parse("2005-2-23"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 9.99M,
                        Image_ID = "states_of_grace.jpg"
                    },

                    new Movie
                    {
                        Title = "Still Mine",
                        ReleaseDate = DateTime.Parse("2012-09-10"),
                        Genre = "Romantic",
                        Rating = "PG-13",
                        Price = 3.99M,
                        Image_ID = "still_mine.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}