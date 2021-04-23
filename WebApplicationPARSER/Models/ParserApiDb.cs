using System.Data.Entity;
namespace WebApplicationPARSER.Models
{
    public class ParserApiDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
