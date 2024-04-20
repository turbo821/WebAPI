using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Tom", Age = 25},
                new User { Id = 2, Name = "Sam", Age = 34},
                new User { Id = 3, Name = "Bob", Age = 61}
                );  
        }
    }
}
