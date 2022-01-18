﻿using Microsoft.EntityFrameworkCore;
using MyFinance.Domain.Entities;

namespace MyFinance.Data.Context
{
    public class SqlContext : DbContext
    {

        public DbSet<AccountEntity> Conta { get; set; }
        public DbSet<EnderecoEntity> Endereco { get; set; }
        public DbSet<EmployeeEntity> Empregado { get; set; }
        public DbSet<ProductEntity> Produto { get; set; }
        public DbSet<StockEntity> Estoque { get; set; }
        public DbSet<SalesEntity> Vendas { get; set; }
        public DbSet<UserEntity> Usuario { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }


        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
            
        }
        public SqlContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

}