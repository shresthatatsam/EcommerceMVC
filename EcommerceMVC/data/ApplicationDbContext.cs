using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Users> Users { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(x =>
            {
                x.ToTable("Users"); 
                x.HasKey(e => e.Id);
                x.Property(e => e.Name).IsRequired(); 
                x.Property(e => e.Password).IsRequired();
                x.Property(e => e.Isactive).HasDefaultValue(true);

            });

           

            base.OnModelCreating(modelBuilder);
        }

    }
}
