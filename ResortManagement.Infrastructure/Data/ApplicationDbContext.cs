using Microsoft.EntityFrameworkCore;
using ResortManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Amenity> Amenities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                            new Villa
                            {
                                Id = 1,
                                Name = "Suites",
                                Description = "Make yourself at home in these royal suites. Private balconies offer stunning views. Each room features a king-sized bed, lounge seating, walk-in closets, air conditioning and full-size bathrooms with double sinks, walk-in shower and tub. Rooms come fully equipped with state-of-the-art amenities including an LCD flat screen smart TV, USB ports, Keurig Coffee Brewer, mini-fridge and Wi-Fi. Available with pool or resort views.",
                                ImageUrl = "https://placehold.co/600x400",
                                Occupancy = 4,
                                Price = 200,
                                Sqft = 550,
                            },
new Villa
{
    Id = 2,
    Name = "Premium Pool Villa",
    Description = "Make yourself at home in these premium villas. Each unit has it’s own unique decor and amenities, featuring an inviting living area with a gas-burning fireplace as well as excellent lighting and a rustic feel. Cook up a meal for family and friends in the well-equipped kitchen. Enjoy a glass of wine on the balcony while enjoying pool views. Complimentary wireless internet means you can bring all your favorite devices.",
    ImageUrl = "https://placehold.co/600x401",
    Occupancy = 4,
    Price = 300,
    Sqft = 600,
},
new Villa
{
    Id = 3,
    Name = "Luxury Pool Villa",
    Description = "Make yourself at home in these luxury villas. Each unit has it’s own unique decor and amenities, featuring an inviting living area with a gas-burning fireplace as well as excellent lighting and a rustic feel. Cook up a meal for family and friends in the well-equipped kitchen. Enjoy a glass of wine on the balcony while enjoying pool views. Complimentary wireless internet means you can bring all your favorite devices.",
    ImageUrl = "https://placehold.co/600x402",
    Occupancy = 6,
    Price = 400,
    Sqft = 750,
});

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                 Villa_Number = 101,
                 VillaId = 1,

                },
                new VillaNumber
                {
                Villa_Number = 102,
                VillaId = 1,

                },
                new VillaNumber
                {
                Villa_Number = 103,
                VillaId = 1,

                },
                 new VillaNumber
                 {
                 Villa_Number = 104,
                 VillaId = 1,

                 },
                 new VillaNumber
                 {
                  Villa_Number = 201,
                  VillaId = 2,

                 },
                new VillaNumber
                {
                    Villa_Number = 202,
                    VillaId = 2,

                },
                new VillaNumber
                {
                    Villa_Number = 203,
                    VillaId = 3,

                },
                new VillaNumber
                {
                    Villa_Number = 301,
                    VillaId = 3,
                },
            new VillaNumber
            {
                Villa_Number = 302,
                VillaId = 3,
            }
        );
            modelBuilder.Entity<Amenity>().HasData(
            new Amenity
          {
              Id = 1,
              VillaId = 1,
              Name = "Private Pool"
          }, new Amenity
          {
              Id = 2,
              VillaId = 1,
              Name = "Microwave"
          }, new Amenity
          {
              Id = 3,
              VillaId = 1,
              Name = "Private Balcony"
          }, new Amenity
          {
              Id = 4,
              VillaId = 1,
              Name = "1 king bed and 1 sofa bed"
          },

          new Amenity
          {
              Id = 5,
              VillaId = 2,
              Name = "Private Plunge Pool"
          }, new Amenity
          {
              Id = 6,
              VillaId = 2,
              Name = "Microwave and Mini Refrigerator"
          }, new Amenity
          {
              Id = 7,
              VillaId = 2,
              Name = "Private Balcony"
          }, new Amenity
          {
              Id = 8,
              VillaId = 2,
              Name = "king bed or 2 double beds"
          },

          new Amenity
          {
              Id = 9,
              VillaId = 3,
              Name = "Private Pool"
          }, new Amenity
          {
              Id = 10,
              VillaId = 3,
              Name = "Jacuzzi"
          }, new Amenity
          {
              Id = 11,
              VillaId = 3,
              Name = "Private Balcony"
          }
          );
        }
    }

}
