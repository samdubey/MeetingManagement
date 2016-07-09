using FluentMigrator;

namespace MeetingManagement.Migrations.DefaultDB
{
    [Migration(20160709232400)]
    public class DefaultDB_20160709_232400_MeetingLookups : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("met");

            Create.Table("AgendaTypes").InSchema("met")
                .WithColumn("AgendaTypeId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Contacts").InSchema("met")
                .WithColumn("ContactId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(30).Nullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable();

            Create.Table("Locations").InSchema("met")
                .WithColumn("LocationId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Address").AsString(300).Nullable()
                .WithColumn("Latitude").AsDouble()
                .WithColumn("Longitude").AsDouble();

            Create.Table("MeetingTypes").InSchema("met")
                .WithColumn("MeetingTypeId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Units").InSchema("met")
                .WithColumn("UnitId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();
        }
    }
}