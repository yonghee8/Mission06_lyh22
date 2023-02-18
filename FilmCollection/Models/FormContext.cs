using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base(options)
        {
            //Blank for now
        }
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    FilmId = 1,
                    CategoryId = 1,
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    FilmId = 2,
                    CategoryId = 3,
                    Title = "About Time",
                    Year = 2013,
                    Director = "Richard Curtis",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    FilmId = 3,
                    CategoryId = 1,
                    Title = "Spirited Away",
                    Year = 2001,
                    Director = "Hayao Miyazaki",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

            );
        }

    }
}