using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(040120221025)]
    public class Product : Migration
    {
        public override void Down()
        {
            Delete.Table("Product");
        }

        public override void Up()
        {
            Create.Table("Product")
                .CreateBase(true)

                .WithColumn("Name").AsString()
                .NotNullable()

                .WithColumn("barcode").AsString()
                .Nullable()

                .WithColumn("UnitaryValue").AsDecimal()
                .NotNullable()

                .WithColumn("ExpirationDate").AsDateTime()
                .Nullable()

                .WithColumn("IdProductType").AsInt32()
                .NotNullable()
                .ForeignKey("ProductType", "Id")

                .WithColumn("DateEntry").AsDateTime()
                .NotNullable();
        }
    }
}
