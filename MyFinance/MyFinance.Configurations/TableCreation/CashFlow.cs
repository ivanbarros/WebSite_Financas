﻿using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(130120221442)]
    public class CashFlow : Migration
    {
        public override void Down()
        {
            Delete.Table("CashFlow");
        }

        public override void Up()
        {
            Create.Table("CashFlow")
                .CreateBase(true)

                .WithColumn("Description").AsString()
                .NotNullable()

                .WithColumn("TypeCashFlow").AsString()
                .NotNullable()

                .WithColumn("ValueCash").AsDecimal()
                .NotNullable()

                .WithColumn("Category").AsString()
                .NotNullable()

                .WithColumn("PaymentDate").AsDateTime2()
                .Nullable()

               .WithColumn("DatePaymentRealized").AsDateTime2()
               .Nullable()

               .WithColumn("IsPago").AsBoolean()
               .Nullable()
               
               .WithColumn("UpdatedDate").AsDateTime2()
               .Nullable();
        }
    }
}
