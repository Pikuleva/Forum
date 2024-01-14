﻿// <auto-generated />
using System;
using Forum.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forum.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    [Migration("20240114114303_CreateAndSeedDb")]
    partial class CreateAndSeedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Forum.Data.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("675427d6-1f2a-4d35-97fe-098b6d48785c"),
                            Content = "Hi from my first comment in this application! It's work!",
                            Tittle = "My first post"
                        },
                        new
                        {
                            Id = new Guid("646b1f46-11f1-494d-84da-41ca1841d10a"),
                            Content = "Hi again from my first comment in this application! It's work!",
                            Tittle = "My second post"
                        },
                        new
                        {
                            Id = new Guid("274281fe-e6e2-47f4-b7ae-20615907f66a"),
                            Content = "Hi again and again from my first comment in this application! It's work!",
                            Tittle = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}