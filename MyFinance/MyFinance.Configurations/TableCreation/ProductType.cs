using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(040120221021)]
    public class ProductType : Migration
    {
        public override void Down()
        {
            Delete.Table("ProductType");
        }

        public override void Up()
        {
            Create.Table("ProductType")
                .CreateBase(false)
                
                .WithColumn("Name").AsString();
        }
    }
}
