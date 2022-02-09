using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;

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

                .WithColumn("Name").AsString()
                .NotNullable()
                .Unique();
            Insert.IntoTable("Permission")
                .Row(new { Name = "basic", IsActive = true, CreateDate = DateTime.Now});
            
            Insert.IntoTable("Permission")
                .Row(new { Name = "intermediate", IsActive = true, CreateDate = DateTime.Now });
            
            Insert.IntoTable("Permission")
                .Row(new { Name = "advanced", IsActive = true, CreateDate = DateTime.Now });
            
            Insert.IntoTable("Permission")
                .Row(new { Name = "master", IsActive = true, CreateDate = DateTime.Now });
        }
        
    }
}
