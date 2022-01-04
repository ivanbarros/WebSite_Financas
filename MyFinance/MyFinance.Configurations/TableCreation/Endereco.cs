using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222159)]
    public class Endereco : Migration
    {
        public override void Down()
        {
            Delete.Table("Endereco");
        }

        public override void Up()
        {
            Create.Table("Endereco")
                .CreateBase(true)
                
                .WithColumn("idEmployee").AsInt32()
                .Nullable()
                
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
