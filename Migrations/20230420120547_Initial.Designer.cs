﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission06_jrencher.Models;

namespace mission06_jrencher.Migrations
{
    [DbContext(typeof(MovieResponseContext))]
    [Migration("20230420120547_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission06_jrencher.Models.MovieResponse", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

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

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Title");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Title = "Antman and the Wasp",
                            Category = "Action",
                            Director = "Thanos",
                            Edited = true,
                            LentTo = "N/A",
                            Notes = "Funny",
                            Rating = "PG-13",
                            Year = 2016
                        },
                        new
                        {
                            Title = "Spiderman: No Way Home",
                            Category = "Action",
                            Director = "Wanda",
                            Edited = false,
                            LentTo = "Nathan",
                            Notes = "Best Movie Ever",
                            Rating = "PG-13",
                            Year = 2022
                        },
                        new
                        {
                            Title = "Endgame",
                            Category = "Action",
                            Director = "Thanos",
                            Edited = false,
                            LentTo = "N/A",
                            Notes = "So So Good",
                            Rating = "PG-13",
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
