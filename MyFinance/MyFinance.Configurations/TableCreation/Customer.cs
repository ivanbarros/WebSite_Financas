using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(050120221700)]
    public class Customer : Migration
    {
        public override void Down()
        {
            Delete.Table("Customer");
        }

        public override void Up()
        {
            Create.Table("Customer")
                .CreateBase(false)
                
                .WithColumn("Name").AsString()
                .NotNullable()
                
                
                .WithColumn("email").AsString()
                .NotNullable()
                
                .WithColumn("doc").AsString()
                .NotNullable()
                .Unique()
                
                .WithColumn("DateBirth").AsDateTime()
                .NotNullable()
                
                .WithColumn("IdAddress").AsInt32()
                .NotNullable()
                .ForeignKey("Address", "Id");
        }
    }
}
