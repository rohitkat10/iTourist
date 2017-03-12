using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace itourist.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime RelasedDate { get; set; }
        public string Genre { get; set; }

    }
    public class MovieDBConext:DbContext
    {
        public DbSet<Movie> Movies { get; set; } 
    }
}