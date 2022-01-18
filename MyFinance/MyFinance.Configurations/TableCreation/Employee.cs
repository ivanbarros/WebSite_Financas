using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(030120222200)]
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

                .WithColumn("Doc").AsString(11)
                .NotNullable()
                .Unique()

                .WithColumn("DateBirth").AsDateTime()
                .NotNullable()

                .WithColumn("Email").AsString()
                .NotNullable()
                .Unique()

                .WithColumn("IdAddress").AsInt32()
                .NotNullable()
                .ForeignKey("Address", "Id")

                .WithColumn("Tel").AsString()
                .NotNullable()

                .WithColumn("Entry").AsDateTime()
                .NotNullable()

                .WithColumn("Out").AsDateTime()
                .Nullable()

                .WithColumn("IdTypeContract").AsInt32()
                .NotNullable()
                .ForeignKey("TypeContract", "Id")


                .WithColumn("Payment").AsDecimal()
                .NotNullable();
        }
    }
}
