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
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionStrings"));
        }

      /*  public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Replace "your_connection_string_here" with your actual connection string
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Product entity
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products"); // Set the table name
                entity.HasKey(e => e.Id); // Set the primary key
                entity.Property(e => e.Name).IsRequired(); // Set Name as required
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)"); // Set Price as decimal(18, 2)
            });

            // Add more configurations for other entities if needed

            base.OnModelCreating(modelBuilder);
        }*/

    }
}
