using MagicVilla_APi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_APi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Villa> villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
             new Villa
                {
                   Id = 1,
                    OwnerName = "Emily Johnson",
                    Description = "Luxury beachfront villa with stunning ocean views",
                    area = 500.25,
                    numOFrooms = 6,
                    city = "Miami",
                    StreetName = "Ocean Drive",
                    villaNum = 5678,
                    price = 2500000.0,
                    imageUrl = "https://example.com/villa1-image.jpg"
                },

           new Villa
            {
               Id = 2,
                OwnerName = "Michael Anderson",
                Description = "Modern villa with a rooftop terrace and panoramic city views",
                area = 280.50,
                numOFrooms = 4,
                city = "New York",
                StreetName = "Park Avenue",
                villaNum = 2468,
                price = 1800000.0,
                imageUrl = "https://example.com/villa2-image.jpg"
            },

            new Villa
            {   Id = 3,
                OwnerName = "Sophia Lee",
                Description = "Elegant villa surrounded by lush green gardens",
                area = 400.75,
                numOFrooms = 7,
                city = "London",
                StreetName = "Kensington High Street",
                villaNum = 1357,
                price = 2200000.0,
                imageUrl = "https://example.com/villa3-image.jpg"
            },

             new Villa
            {
                Id=4,
                OwnerName = "Benjamin Martinez",
                Description = "Mediterranean-style villa with a private courtyard and fountain",
                area = 320.00,
                numOFrooms = 5,
                city = "Barcelona",
                StreetName = "Passeig de Gràcia",
                villaNum = 9876,
                price = 1950000.0,
                imageUrl = "https://example.com/villa4-image.jpg"
            },

        new Villa
            {
                Id=5,
                OwnerName = "Olivia Wilson",
                Description = "Rustic countryside villa with panoramic mountain views",
                area = 600.80,
                numOFrooms = 8,
                city = "Geneva",
                StreetName = "Rue du Rhône",
                villaNum = 3691,
                price = 3400000.0,
                imageUrl = "https://example.com/villa5-image.jpg"
            },

           new Villa
            {   Id = 6,
                OwnerName = "Daniel Thompson",
                Description = "Contemporary villa with a private infinity pool overlooking the ocean",
                area = 450.30,
                numOFrooms = 6,
                city = "Sydney",
                StreetName = "Bondi Road",
                villaNum = 8023,
                price = 2700000.0,
                imageUrl = "https://example.com/villa6-image.jpg"
            } );
        }
    }
}
