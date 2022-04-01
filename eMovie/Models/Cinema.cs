using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eMovie.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string CinemaLogo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Relationship - a cinema can have a list of movie 
        // One to *
        public List<Movie> Movies { get; set; }
    }
}
