using Lighten_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Lighten_Project.Data
{
    public class Lighten_ProjectDbContext:DbContext
    {
        public Lighten_ProjectDbContext(DbContextOptions<Lighten_ProjectDbContext> options):base(options)
        {

        }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<OurProducts> OurProducts { get; set; }

        public DbSet<ServiceProses> ServiceProses { get; set; }
        public DbSet<WhyChooseUs> WhyChooseUs { get; set; }
        

       
       
    }
}
