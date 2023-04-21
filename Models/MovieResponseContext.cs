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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Seeding the Database
            mb.Entity<Category>().HasData(
                    new Category { CategoryId=1, CategoryName="Action/Adventure"},
                    new Category { CategoryId=2, CategoryName="Comedy"},
                    new Category { CategoryId = 3, CategoryName = "Drama" },
                    new Category { CategoryId = 4, CategoryName = "Family" }
                );
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    CategoryId = 2,
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
                    CategoryId = 1,
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
                    CategoryId = 1,
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
