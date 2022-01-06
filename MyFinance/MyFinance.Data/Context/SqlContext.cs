using Microsoft.EntityFrameworkCore;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Context
{
    public class SqlContextt : DbContext
    {
        
        public DbSet<ContaEntity> Conta { get; set; }
        public DbSet<EnderecoEntity> Endereco { get; set; }
        public DbSet<EmployeeEntity> Empregado { get; set; }
        public DbSet<ProductEntity> Produto { get; set; }
        public DbSet<StockEntity> Estoque { get; set; }
        public DbSet<SalesEntity> Vendas { get; set; }
        public DbSet<UserEntity> Usuario { get; set; }




        
        public SqlContextt(DbContextOptions<SqlContextt> options) : base(options)
{
}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

}