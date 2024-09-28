using Microsoft.EntityFrameworkCore;
using TrainingDotnet.Models.Entities;

namespace TrainingDotnet.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor nhận DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) // Truyền options vào lớp cơ sở DbContext
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=QUACH_KHANG_LAP\\QUACHKHANG;Initial Catalog=TrainingDotnet;User ID=sa;Password=098098;Encrypt=True;Trust Server Certificate=True;");
        }

        // DbSet cho các thực thể (entities) của bạn
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
