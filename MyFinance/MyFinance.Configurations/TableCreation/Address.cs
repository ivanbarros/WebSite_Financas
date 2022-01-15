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
                
                              
                .WithColumn("Logradouro").AsString()
                .NotNullable()
                
                .WithColumn("Numero").AsString()
                .NotNullable()
                
                .WithColumn("Complemento").AsString()
                .Nullable()
                                
                .WithColumn("Bairro").AsString()
                .NotNullable()
                
                .WithColumn("Cidade").AsString()
                .NotNullable()
                
                .WithColumn("Estado").AsString()
                .NotNullable();
        }
    }
}
