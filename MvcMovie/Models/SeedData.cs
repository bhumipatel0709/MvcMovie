using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 8.79M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.89M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 6.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 5.99M
                },

                new Movie
                {
                    Title = "Mission Impossible",
                    ReleaseDate = DateTime.Parse("1998-3-24"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 12.099M
                }, new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romantic Drama",
                    Rating = "R",
                    Price = 9.99M
                }, new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-19"),
                    Genre = "Sci-Fi Thriller",
                    Rating = "R",
                    Price = 10.24M
                }, new Movie
                {
                    Title = "Mean Girls",
                    ReleaseDate = DateTime.Parse("2004-4-30"),
                    Genre = "Teen-Comedy",
                    Rating = "R",
                    Price = 12.89M
                }, new Movie
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-12-9"),
                    Genre = "Romantic",
                    Rating = "R",
                    Price = 11.59M
                }
            );
            context.SaveChanges();
        }
    }
}