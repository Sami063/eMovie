using eMovie.Data;
using System.Collections.Generic;
using System.Linq;

namespace eMovie.Models
{
    public class MovieModal
    {
        private readonly MovieDbContext _db;
        public MovieModal(MovieDbContext context)
        {
            _db = context;
        }

        private List<Movie> Movies;
        public List<Movie> findAll()
        {
            Movies = _db.Movies.ToList();
            return Movies;
        }

        public Movie find(int id)
        {
            return Movies.Single(m => m.Id.Equals(id));
        }
    }
}
