using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(150120221703)]
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
                .NotNullable()
                
                .WithColumn("IdPaymentMethod").AsInt32()
                .NotNullable()
                .ForeignKey("PaymentMethod", "Id")

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
