using Microsoft.EntityFrameworkCore;

namespace SEWebApplication.Models
{
    public class SEClientsContext : DbContext
    {
        public SEClientsContext(DbContextOptions<SEClientsContext> options) : base(options)
        {
        }

        public DbSet<Client> ClientItems { get; set; }
    }
}
