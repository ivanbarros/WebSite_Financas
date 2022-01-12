using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(120120220915)]
    public class Account : Migration
    {
        public override void Down()
        {
            Delete.Table("Account");
        }

        public override void Up()
        {
            Create.Table("Account")
                .CreateBase(true)

                .WithColumn("AccountName").AsString()
                .NotNullable()

                .WithColumn("Balance").AsDecimal()
                .Nullable()
                
                .WithColumn("AccountType").AsString()
                .NotNullable()
                
                .WithColumn("DescriptionAccount").AsString()
                .Nullable()
                
                .WithColumn("CreateDate").AsDateTime()
                .NotNullable();
        }
       
    }
}
