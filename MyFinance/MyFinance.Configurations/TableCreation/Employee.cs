using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222132)]
    public class Employee : Migration
    {
        public override void Down()
        {
            Delete.Table("Employee");
        }

        public override void Up()
        {
            Create.Table("Employee")
                .CreateBase(true)

                .WithColumn("Name").AsString()
                .NotNullable()

                .WithColumn("LastName").AsString()
                .NotNullable()

                .WithColumn("Cpf").AsString(11)
                .NotNullable()
                .Unique()

                .WithColumn("DataNascimento").AsDateTime()
                .NotNullable()

                .WithColumn("Email").AsString()
                .NotNullable()
                .Unique()

                .WithColumn("DataAdmissao").AsDateTime()
                .NotNullable()

                .WithColumn("DataDemissao").AsDateTime()
                .Nullable()

                .WithColumn("TipoContratacao").AsString()
                .NotNullable()

                .WithColumn("Tel").AsString()
                .NotNullable()

                .WithColumn("Salario").AsDecimal()
                .NotNullable()
                
                .WithColumn("IsActive").AsBinary()
                .NotNullable();
        }
    }
}
