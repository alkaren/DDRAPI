using Microsoft.EntityFrameworkCore;

namespace DDRAPI.Data
{
    public class DDRDataContext : DbContext
    {
        public DDRDataContext(DbContextOptions<DDRDataContext> options) : base(options)
        {
        }
        //public DbSet<Hazard> Hazards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Entities.Customer>().HasIndex(x => x.UserName)
            //    .IsUnique();

            //modelBuilder.Entity<Entities.Customer>().HasIndex(x => x.EmailAddress)
            //    .IsUnique();
        }
    }
}
