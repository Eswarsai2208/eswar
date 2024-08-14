using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CC9.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=MoviesDB")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}