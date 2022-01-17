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

                .WithColumn("IdProduct").AsInt32()
                .NotNullable()
                .ForeignKey("Product", "Id")

                .WithColumn("Qtd").AsDecimal()
                .NotNullable()

                .WithColumn("Amount").AsDecimal()

                .WithColumn("IdEmployee").AsInt32()
                .NotNullable()
                .ForeignKey("Employee","Id")

                .WithColumn("PurchaseDate").AsDateTime()
                .NotNullable()
                
                .WithColumn("IdCustomer").AsInt32()
                .NotNullable()
                .ForeignKey("Customer", "Id");
        }
    }
}
