﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prodotti.Data;

#nullable disable

namespace Prodotti.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241017231457_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clothing"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A high-performance laptop for professionals.",
                            ImageUrl = "/images/laptop.jpg",
                            Name = "Laptop",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A sleek smartphone with excellent camera features.",
                            ImageUrl = "/images/smartphone.jpg",
                            Name = "Smartphone",
                            Price = 800m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Comprehensive guide to learn C# programming.",
                            ImageUrl = "/images/book-csharp.jpg",
                            Name = "Book - Programming in C#",
                            Price = 40m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A lightweight tablet ideal for entertainment and productivity.",
                            ImageUrl = "/images/tablet.jpg",
                            Name = "Tablet",
                            Price = 600m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Noise-canceling wireless headphones with long battery life.",
                            ImageUrl = "/images/headphones.jpg",
                            Name = "Wireless Headphones",
                            Price = 200m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Remote-controlled toy car for kids.",
                            ImageUrl = "/images/toy-car.jpg",
                            Name = "Toy Car",
                            Price = 50m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "A wristband tracker to monitor your daily activity and health.",
                            ImageUrl = "/images/fitness-tracker.jpg",
                            Name = "Fitness Tracker",
                            Price = 120m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "An in-depth book for mastering Python programming.",
                            ImageUrl = "/images/book-python.jpg",
                            Name = "Book - Learn Python",
                            Price = 45m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "A stylish smartwatch with fitness and notification features.",
                            ImageUrl = "/images/smartwatch.jpg",
                            Name = "Smartwatch",
                            Price = 300m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Learn how to build modern websites using HTML and CSS.",
                            ImageUrl = "/images/book-webdev.jpg",
                            Name = "Book - Web Development with HTML and CSS",
                            Price = 35m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "A next-gen gaming console for immersive experiences.",
                            ImageUrl = "/images/gaming-console.jpg",
                            Name = "Gaming Console",
                            Price = 500m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "A collectible action figure from your favorite movie.",
                            ImageUrl = "/images/action-figure.jpg",
                            Name = "Action Figure",
                            Price = 75m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 1,
                            Description = "Portable speaker with powerful sound quality.",
                            ImageUrl = "/images/bluetooth-speaker.jpg",
                            Name = "Bluetooth Speaker",
                            Price = 150m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Interactive robot toy with multiple functions.",
                            ImageUrl = "/images/toy-robot.jpg",
                            Name = "Toy Robot",
                            Price = 90m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 1,
                            Description = "An e-reader device for reading e-books on the go.",
                            ImageUrl = "/images/e-reader.jpg",
                            Name = "E-Reader",
                            Price = 130m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "A 1000-piece puzzle for adults and kids.",
                            ImageUrl = "/images/puzzle-game.jpg",
                            Name = "Puzzle Game",
                            Price = 25m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 1,
                            Description = "High-precision mouse designed for gaming.",
                            ImageUrl = "/images/gaming-mouse.jpg",
                            Name = "Gaming Mouse",
                            Price = 70m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 2,
                            Description = "A beginner's guide to understanding data science.",
                            ImageUrl = "/images/book-datascience.jpg",
                            Name = "Book - Data Science Essentials",
                            Price = 50m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 1,
                            Description = "A lightweight drone with camera capabilities.",
                            ImageUrl = "/images/drone.jpg",
                            Name = "Drone",
                            Price = 400m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "Build your own world with this LEGO set.",
                            ImageUrl = "/images/lego-set.jpg",
                            Name = "LEGO Set",
                            Price = 100m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
