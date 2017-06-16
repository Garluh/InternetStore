using Domain.Entities;
using System.Data.Entity;
namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Dress> Dresses { get; set; }
    }
}
