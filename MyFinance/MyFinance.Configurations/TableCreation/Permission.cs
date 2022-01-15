using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(120120220900)]
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
