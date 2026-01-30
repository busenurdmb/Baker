
using Baker.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Baker.WebApi.Context
{
    public class BakerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-493DFJA\\SQLEXPRESS; initial catalog=DbBakerAkademiq ;integrated Security=true; Trustservercertificate=true");  ;
        }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
