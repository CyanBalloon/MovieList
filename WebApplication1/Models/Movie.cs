using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public int ReleaseYear { get; set; }

        [Display(Name="Genre")]
        public int GenreID { get; set; }

        [ForeignKey("GenreID")]
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }

        public decimal Price { get; set; }

        public int Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<MvcMovie.Models.Genre> Genres { get; set; }
    }
}