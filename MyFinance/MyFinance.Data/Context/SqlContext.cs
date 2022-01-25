using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Context
{
    public class SqlContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<AccountEntity> Conta { get; set; }
        public DbSet<AddressEntity> Endereco { get; set; }
        public DbSet<EmployeeEntity> Empregado { get; set; }
        public DbSet<ProductEntity> Produto { get; set; }
        public DbSet<StockEntity> Estoque { get; set; }
        public DbSet<SalesEntity> Vendas { get; set; }
        public DbSet<UserEntity> Usuario { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }
        public DbSet<CashFlowEntity> CashFlow { get; set; }

        public SqlContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration["sqlDb:connectionString"]);
            }
        }
    }

}