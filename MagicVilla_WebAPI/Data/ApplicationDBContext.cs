using MagicVilla_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_WebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa { 
                    Id = 1, 
                    Name = "Royal Villa",
                    Details = "aasdf asd  asdf asdf",
                    ImageUrl = "",
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
                    ImageUrl = "",
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
                    ImageUrl = "",
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
