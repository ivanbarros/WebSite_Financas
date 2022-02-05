using FluentMigrator;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(050220220144)]
    public class UpdateCashFlowColumnIsPago : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Alter.Table("CashFlow")
           .AddColumn("IsPago").AsBoolean()
           .Nullable();
        }
    }
}
