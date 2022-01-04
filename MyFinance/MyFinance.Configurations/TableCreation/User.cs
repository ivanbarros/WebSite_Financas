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

                .WithColumn("CreateDate").AsDateTime()
                .NotNullable()

                .WithColumn("Login").AsString()
                .NotNullable()

                .WithColumn("password").AsString()
                .NotNullable()
                
                .WithColumn("IsActive").AsBinary()
                .NotNullable();
        }
    }
}
