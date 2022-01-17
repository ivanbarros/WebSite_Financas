using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222129)]
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

               
                .WithColumn("Login").AsString()
                .NotNullable()
               
                .WithColumn("PassWord").AsString()
                .NotNullable()

                .WithColumn("Email").AsString()
                .NotNullable()
                .Unique()

                .WithColumn("IsActive").AsBoolean()
                .NotNullable()
                
                .WithColumn("IdPermission").AsInt32()
                .NotNullable()
                .ForeignKey("Permission","Id");
        }
    }
}
