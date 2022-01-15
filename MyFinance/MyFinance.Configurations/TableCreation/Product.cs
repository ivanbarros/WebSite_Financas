using FluentMigrator;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(04012022)]
    public class Product : Migration
    {
        public override void Down()
        {
            Delete.Table("Product");
        }

        public override void Up()
        {
            throw new NotImplementedException();
        }
    }
}
