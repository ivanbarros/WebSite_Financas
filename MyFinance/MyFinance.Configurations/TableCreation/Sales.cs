using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(050120221707)]
    public class Sales : Migration
    {
        public override void Down()
        {
            Delete.Table("Sales");
        }

        public override void Up()
        {
            Create.Table("Sales")
                .CreateBase(false)

                .WithColumn("Produto").AsString()
                .NotNullable()

                .WithColumn("Qtd").AsDecimal()
                .NotNullable()

                .WithColumn("Vendedor").AsDecimal()
                .NotNullable()

                .WithColumn("DataCompra").AsDecimal()
                .NotNullable();
        }
    }
}
