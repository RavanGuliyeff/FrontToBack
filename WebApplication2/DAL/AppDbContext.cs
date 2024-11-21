using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<ServiceSlide> ServiceSlides { get; set; }
        public DbSet<TestimonialSlide> TestimonialSlides { get; set; }
    }
}
