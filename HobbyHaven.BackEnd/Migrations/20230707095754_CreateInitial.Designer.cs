﻿// <auto-generated />
using System;
using HobbyHaven.BackEnd.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HobbyHaven.BackEnd.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230707095754_CreateInitial")]
    partial class CreateInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("HobbyHaven.BackEnd.Database.Models.Haven", b =>
                {
                    b.Property<Guid>("HavenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HavenID");

                    b.ToTable("Havens");
                });

            modelBuilder.Entity("HobbyHaven.BackEnd.Database.Models.Hobby", b =>
                {
                    b.Property<Guid>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HobbyID");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("HobbyHaven.BackEnd.Database.Models.PersonalityTag", b =>
                {
                    b.Property<Guid>("PersonalityTagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonalityTagID");

                    b.ToTable("PersonalityTags");
                });

            modelBuilder.Entity("HobbyHaven.BackEnd.Database.Models.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Admin")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
