using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222137)]
    public class User : Migration
    {
        public override void Down()
        {
            Delete.Table("User");
        }

        public override void Up()
        {
            Create.Table("User")
                .CreateBase(false)


                .WithColumn("UserName").AsString()
                .NotNullable()


                .WithColumn("Login").AsString()
                .NotNullable()
               
                .WithColumn("PassWord").AsString()
                .NotNullable()

                .WithColumn("Email").AsString()
                .NotNullable()
                .Unique()


                .WithColumn("IdPermission").AsInt32()
                .NotNullable()
                .ForeignKey("Permission","Id");
        }
    }
}
