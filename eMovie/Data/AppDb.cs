using eMovie.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eMovie.Data
{
    public class AppDb
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var service = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = service.ServiceProvider.GetService<MovieDbContext>();
                context.Database.EnsureCreated(); // Ensured created

                // ----------------------Cinema data-----------------------------=>

                if (!context.Cinemas.Any()) // Linq
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "IMax", 
                            CinemaLogo = "https://mir-s3-cdn-cf.behance.net/project_modules/fs/8de77720661659.562ef0a17f6b2.jpg",
                            Description = "This is IMax Cinema", 
                            
                        },

                        new Cinema()
                        {
                            Name = "Wax",
                            CinemaLogo = "http://pixelpirate.dk/pp9/wp-content/uploads/2015/05/CinemaxX_IMAX_Tunnel.jpg",
                            Description = "The best know Cinema in Denmark",

                        },

                        new Cinema()
                        {
                            Name = "Asmara Down Town",
                            CinemaLogo = "http://pixelpirate.dk/pp9/wp-content/uploads/2015/05/CinemaxX_IMAX_Tunnel.jpg",
                            Description = "The best know Cinema in Denmark",

                        },

                        new Cinema()
                        {
                            Name = "Park Bio",
                            CinemaLogo = "http://photos.cinematreasures.org/production/photos/315182/1597953913/large.jpg?1597953913",
                            Description = "This is a Park Bio Cinema",

                        }
                    });


                    context.SaveChanges(); // Last SaveChangs
                }

                // ----------------------Movie-----------------------------=>
                
                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Beginning Of Outer Space",
                            Description = "The Kármán line, an altitude of 100 km (62 mi) above sea level, is conventionally used as the start of outer space in space treaties and for aerospace records keeping",
                            Price = 99m,
                            MovieCategory = MovieCategory.Fiction,
                            CinemaId = 13,
                            ProducerId = 2,
                        }
                    });
                    context.SaveChanges();
                } 

                // -----------------------Producers-------------------------=>
                /*
                if (!context.Producers.Any())
                {
                    context.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Will Smith",
                            ProfileURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQbuF86tSHODHWHJRusio04zBWZHRNgFJdu-jyiWgkIbBC4-tuT",
                            Bio = "This is Will Smith Bio",
                            Movies = new List<Movie>()
                        }
                     });

                    context.SaveChanges(); 
                }*/

                // ----------------------Actors and Movies------------------=>

                
            }
        }
    }
}
