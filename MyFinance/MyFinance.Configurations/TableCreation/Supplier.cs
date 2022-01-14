using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(140120221755)]
    public class Supplier : Migration
    {
        public override void Down()
        {
            Delete.Table("Supplier");
        }
        public override void Up()
        {
            Create.Table("Supplier")
            .CreateBase(false);


        }


    }
}
