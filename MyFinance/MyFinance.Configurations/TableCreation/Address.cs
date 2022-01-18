using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222159)]
    public class Address : Migration
    {
        public override void Down()
        {
            Delete.Table("Address");
        }

        public override void Up()
        {
            Create.Table("Address")
                .CreateBase(true)
                
                              
                .WithColumn("PatioArea").AsString()
                .NotNullable()
                
                .WithColumn("Num").AsString()
                .NotNullable()
                
                .WithColumn("Complement").AsString()
                .Nullable()
                                
                .WithColumn("NeighborHood").AsString()
                .NotNullable()
                
                .WithColumn("City").AsString()
                .NotNullable()
                
                .WithColumn("State").AsString()
                .NotNullable();
        }
    }
}
