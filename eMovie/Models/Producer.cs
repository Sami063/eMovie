using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eMovie.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfileURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Relationship - a producer can have multiple movie
        public List<Movie> Movies { get; set; }
    }
}

