using eMovie.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieImage { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        // Have created a new file - "MovieCategory"
        public MovieCategory MovieCategory { get; set; } 
        public MovieLanguage MovieLanguage { get; set; }

        // Relationship - a producer can have multiple movie
        public List<Actor_Movie> Actor_Movie { get; set; } // One to many
        
        // Cinema 
        // Cinema 
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; } 

        // Producer 
        public int ProducerId { get; set; } 
        [ForeignKey("ProducerId")] 
        public Producer Producer { get; set; } 
    }
}
