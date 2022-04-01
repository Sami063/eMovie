using eMovie.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eMovie.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options ) : base(options)
        {

        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(m => new
            {
                m.ActorId,
                m.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(m => m.Actor_Movie).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(m => m.Actor_Movie).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);

        }

        // -------------------------
        
        public Movie find(int id)
        {
            return Movies.Single(m => m.Id.Equals(id));
        }

        // Creating tables
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; } 
    }
}
 