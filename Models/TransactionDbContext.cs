using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace DemoMVC.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext>options) : base(options) 
        {
            
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
