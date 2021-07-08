using Microsoft.EntityFrameworkCore;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<MovieActors>().HasKey(m => new { m.MovieId, m.PersonId });
            builder.Entity<MovieGenres>().HasKey(m => new { m.MovieId, m.GenresId });

            base.OnModelCreating(builder);
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<MovieActors> MovieActors { get; set; }

        public DbSet<MovieGenres> MovieGenres { get; set; }
    }
}
