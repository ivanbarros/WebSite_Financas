using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

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
            .CreateBase(false)
            
            .WithColumn("IdProduct").AsInt32()
            .NotNullable()
            .ForeignKey("Product","Id")
            
            .WithColumn("Name").AsString()
            .NotNullable()
            
            .WithColumn("Doc").AsString()
            .NotNullable()
            .Unique()
            
            .WithColumn("IdAddress").AsInt32()
            .NotNullable()
            .ForeignKey("Address","Id")
            
            .WithColumn("Email").AsString()
            .NotNullable()
            
            .WithColumn("Tel").AsString()
            .NotNullable();
        }


    }
}
