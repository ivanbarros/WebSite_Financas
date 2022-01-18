using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(050120221703)]
    public class PaymentMethod : Migration
    {
        public override void Down()
        {
            Delete.Table("PaymentMethod");
        }

        public override void Up()
        {
            Create.Table("PaymentMethod")
                .CreateBase(false)
                
                .WithColumn("Name").AsString();
        }
    }
}
