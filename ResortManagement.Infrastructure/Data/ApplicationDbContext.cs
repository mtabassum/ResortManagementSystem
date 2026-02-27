using Microsoft.EntityFrameworkCore;
using ResortManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }

}
