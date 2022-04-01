using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfileURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Relationships
        // Go To Movie 
        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
