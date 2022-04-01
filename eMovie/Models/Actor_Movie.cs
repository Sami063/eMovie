namespace eMovie.Models
{
    public class Actor_Movie
    {
        public int  MovieId { get; set; } // forigin key for the movie
        public Movie Movie { get; set; } //MovieId =  Gonna have movie Id

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        // Go to the actor and add a relationship 

    }
}
 