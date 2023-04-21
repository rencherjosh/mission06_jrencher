using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_jrencher.Models
{
    public class MovieResponseContext : DbContext
    {
        //Constructor and Setting up DBContext Class
        public MovieResponseContext (DbContextOptions<MovieResponseContext> options) : base (options)
        {
            //Leave Blank for Now
        }

        //Build database of movie responces
        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Seeding the Database
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    Category = "Action",
                    Title = "Antman and the Wasp",
                    Year = 2016,
                    Director = "Thanos",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "N/A",
                    Notes = "Funny"
                },
                new MovieResponse
                {
                    Category = "Action",
                    Title = "Spiderman: No Way Home",
                    Year = 2022,
                    Director = "Wanda",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Nathan",
                    Notes = "Best Movie Ever"
                },
                new MovieResponse
                {
                    Category = "Action",
                    Title = "Endgame",
                    Year = 2016,
                    Director = "Thanos",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "So So Good"
                }
                );
        }

    }
}
