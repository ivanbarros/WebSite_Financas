using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(170120222137)]
    public class Devolution : Migration
    {
        public override void Down()
        {
            Delete.Table("Devolution");
        }

        public override void Up()
        {
            Create.Table("Devolution")
                .CreateBase(false)
                
                .WithColumn("IdSale").AsInt32()
                .NotNullable()
                .ForeignKey("Sales","Id")
                
                .WithColumn("IdCustomer").AsInt32()
                .NotNullable()
                .ForeignKey("Customer", "Id")
                
                .WithColumn("DateDevolution").AsDateTime()
                .NotNullable();
        }
    }
}
