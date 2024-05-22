using MagicVilla_WebAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_WebAPI.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
		public DbSet<Villa> Villas { get; set; }
		public DbSet<VillaNumber> VillaNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa { 
                    Id = 1, 
                    Name = "Royal Villa",
                    Details = "aasdf asd  asdf asdf",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 5,
                    Rate = 500,
                    SqFt = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Royal Villa 2",
                    Details = "aasdf asd  asdf asdf",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Occupancy = 5,
                    Rate = 500,
                    SqFt = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Royal Villa 3",
                    Details = "aasdf asd  asdf asdf",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                    Occupancy = 5,
                    Rate = 500,
                    SqFt = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
