using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(050120221707)]
    public class Stock : Migration
    {
        public override void Down()
        { 
            Delete.Table("Stock");
        }

        public override void Up()
        {
            Create.Table("Stock")
               .CreateBase(false);
        }
    }
    
}
