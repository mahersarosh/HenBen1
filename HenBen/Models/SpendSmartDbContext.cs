using Microsoft.EntityFrameworkCore;

namespace HenBen.Models
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> Options)
            : base(Options) 
        {
            
        }

    }
}
