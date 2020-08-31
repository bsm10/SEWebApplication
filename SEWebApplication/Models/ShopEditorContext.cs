using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SEWebApplication.Models
{
    public class SEClientsContext : DbContext
    {
        //public SEClientsContext(DbContextOptions<SEClientsContext> options) : base(options)
        //{
        //}

        public DbSet<Client> ClientItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=clients.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Exprise).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
