// <auto-generated />
using FilmCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmCollection.Migrations
{
    [DbContext(typeof(FormContext))]
    partial class FormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("FilmCollection.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            Category = "Sci-fi/Adventure",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            FilmId = 2,
                            Category = "Romance/Fantasy",
                            Director = "Richard Curtis",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "R",
                            Title = "About Time",
                            Year = 2013
                        },
                        new
                        {
                            FilmId = 3,
                            Category = "Fantasy/Adventure",
                            Director = "Hayao Miyazaki",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Spirited Away",
                            Year = 2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
