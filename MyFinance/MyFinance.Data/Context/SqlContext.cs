using Microsoft.EntityFrameworkCore;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Context
{
    public class SqlContextt : DbContext
    {
        public DbSet<ContaEntity> Conta { get; set; }
        
        public SqlContextt(DbContextOptions<SqlContextt> options) : base(options)
{
}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

}