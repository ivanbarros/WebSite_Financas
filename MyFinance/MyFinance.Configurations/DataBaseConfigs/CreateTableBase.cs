using FluentMigrator;
using FluentMigrator.Builders.Create.Table;

namespace MyFinance.Configurations.DataBaseConfigs
{
    public static class CreateTableBase
    {
        public static ICreateTableWithColumnSyntax CreateBase(this ICreateTableWithColumnSyntax create, bool userFK = true)
        {
            create
                .WithColumn("Id")
                    .AsInt32()
                    .NotNullable()
                    .Identity()
                    .PrimaryKey()

                .WithColumn("IsActive").AsBoolean()
                .NotNullable()

                .WithColumn("CreateDate").AsDateTime()
                .NotNullable();

            if (userFK)
                create
                    .WithColumn("IdUser")
                    .AsInt32()
                    .NotNullable()
                    .ForeignKey("User", "Id");

            return create;
        }
        public static ICreateTableWithColumnSyntax CreateBaseNoActive(this ICreateTableWithColumnSyntax create, bool userFK = true)
        {
            create
                .WithColumn("Id")
                    .AsInt32()
                    .NotNullable()
                    .Identity()
                    .PrimaryKey()
                     .WithColumn("IsActive").AsBoolean()
                .NotNullable()
                .WithColumn("CreateDate")
                    .AsDateTime()
                    .NotNullable()
                    .WithDefaultValue(SystemMethods.CurrentDateTime);

            if (userFK)
                create
                    .WithColumn("IdUser")
                    .AsInt32()
                    .NotNullable()
                    .ForeignKey("User", "Id");

            return create;
        }

        public static ICreateTableWithColumnSyntax CreateBaseNotNullable(this ICreateTableWithColumnSyntax create, bool tablerFK = true)
        {
            create
                .WithColumn("Id")
                    .AsInt32()
                    .NotNullable()
                    .Identity()
                    .PrimaryKey()
                     .WithColumn("IsActive").AsBoolean()
                .NotNullable()
                .WithColumn("CreateDate")
                    .AsDateTime()
                    .NotNullable()
                    .WithDefaultValue(SystemMethods.CurrentDateTime);

            if (tablerFK)
                create
                    .WithColumn("IdTable")
                    .AsInt32()
                    .Nullable()
                    .ForeignKey("Table", "Id");

            return create;
        }
    }
}

