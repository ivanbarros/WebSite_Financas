using FluentMigrator;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(120120221040)]
    public class UpdateTableAccount : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Alter.Table("Account")
        .AddColumn("CreateDate")
        .AsDateTime()
        .NotNullable();

            Alter.Column("Balance")
    .OnTable("Account")
    .AsDouble()
    .NotNullable();
        }
    }
}
