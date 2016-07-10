

namespace MeetingManagement.Meeting.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("AgendaTypes"), InstanceName("AgendaTypes"), TwoLevelCached]
    [ReadPermission("Meeting")]
    [ModifyPermission("Meeting")]
    public sealed class AgendaTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Agenda Type Id"), Identity]
        public Int32? AgendaTypeId
        {
            get { return Fields.AgendaTypeId[this]; }
            set { Fields.AgendaTypeId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AgendaTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AgendaTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AgendaTypeId;
            public StringField Name;

            public RowFields()
                : base("[met].[AgendaTypes]")
            {
                LocalTextPrefix = "Meeting.AgendaType";
            }
        }
    }
}