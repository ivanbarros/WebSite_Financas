using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222129)]
    public class Permission : Migration
    {
        public override void Down()
        {
            Delete.Table("Permission");
        }

        public override void Up()
        {
            Create.Table("Permission")
                .CreateBase(false)

                .WithColumn("name").AsString()
                .NotNullable();
        }
    }
}
