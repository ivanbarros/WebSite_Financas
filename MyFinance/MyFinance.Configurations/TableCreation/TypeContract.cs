using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222100)]
    public class TypeContract : Migration
    {
        public override void Down()
        {
            Delete.Table("TypeContract");
        }

        public override void Up()
        {
            Create.Table("TypeContract")
                .CreateBase(false)
                
                .WithColumn("Name").AsString()
                .NotNullable();
        }
    }
}
