using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission06_sdcable.Models
{
    public class MovieContext : DbContext
    {
        //Context
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<MovieModel> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData
            (

                new MovieModel
                {
                    MovieId = 1,
                    Category = "Fantasy",
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Year = 2001,
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieModel
                {
                    MovieId = 2,
                    Category = "Sci-Fi",
                    Title = "Star Wars: Episode IV -- A New Hope",
                    Year = 1977,
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieModel
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "The Lego Batman Movie",
                    Year = 2017,
                    Director = "Chris McKay",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
             );
        }



    }
}
