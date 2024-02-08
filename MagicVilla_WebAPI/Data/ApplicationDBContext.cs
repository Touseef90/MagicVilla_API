using MagicVilla_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_WebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }
    }
}
