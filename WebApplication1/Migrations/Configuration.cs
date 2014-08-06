namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "American Psycho",
                    ReleaseDate = DateTime.Parse("2000-01-01"),
                    Genre = "Thriller",
                    Rating = 10,
                    Price = 10M
                },

                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-3-13"),
                    Genre = "Science-Fiction",
                    Rating = 10,
                    Price = 10M
                });
        }
    }
}
