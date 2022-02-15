using FluentMigrator;
using MyFinance.Configurations.DataBaseConfigs;
using System;

namespace MyFinance.Configurations.TableCreation
{
    [Migration(090220222233)]
    public class CalendarEvent : Migration
    {
        public override void Down()
        {
            Delete.Table("CalendarEvent");
        }

        public override void Up()
        {
            Create.Table("CalendarEvent")
                .CreateBase(true)
                
                .WithColumn("Start").AsDateTime2()
                .NotNullable()
                
                .WithColumn("End").AsDateTime2()
                .Nullable()
                
                .WithColumn("Text").AsString()
                .NotNullable()
                
                .WithColumn("Color").AsString()
                .Nullable();
        }
    }
}
