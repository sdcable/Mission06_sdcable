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
        public DbSet<CategoriesModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoriesModel>().HasData(
                new CategoriesModel
                {
                    CategoryId = 1,
                    Category = "Fantasy"
                },

                new CategoriesModel
                {
                    CategoryId = 2,
                    Category = "Action/Adventure"
                },

                new CategoriesModel
                {
                    CategoryId = 3,
                    Category = "Comedy"
                },

                new CategoriesModel
                {
                    CategoryId =4,
                    Category = "Drama"
                },

                new CategoriesModel
                {
                    CategoryId = 5,
                    Category = "Family"
                },
                new CategoriesModel
                {
                    CategoryId = 6,
                    Category = "Horror/Suspense"
                },
                new CategoriesModel
                {
                    CategoryId = 7,
                    Category = "Miscellaneous"
                },
                new CategoriesModel
                {
                    CategoryId = 8,
                    Category = "Television"
                },
                new CategoriesModel
                {
                    CategoryId = 9,
                    Category = "VHS"
                }
                );



            mb.Entity<MovieModel>().HasData
            (
                new MovieModel
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 5,
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
