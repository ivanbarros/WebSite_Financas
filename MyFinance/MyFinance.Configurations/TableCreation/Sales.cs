using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

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

                .WithColumn("IdProduto").AsInt32()
                .NotNullable()
                .ForeignKey("Product", "Id")

                .WithColumn("Qtd").AsDecimal()
                .NotNullable()

                .WithColumn("IdVendedor").AsInt32()
                .NotNullable()
                .ForeignKey("User","Id")

                .WithColumn("DataCompra").AsDecimal()
                .NotNullable();
        }
    }
}
