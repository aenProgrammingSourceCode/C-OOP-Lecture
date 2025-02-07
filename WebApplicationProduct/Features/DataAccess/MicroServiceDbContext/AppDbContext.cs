using Microsoft.EntityFrameworkCore;
using nurAPI.Features.DataAccess.EntityConfigurations;
using nurAPI.Features.DomainModels;

namespace nurAPI.Features.DataAccess.MicroServiceDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        }

        public DbSet<Company> Companies { get; set; }

    }
}
